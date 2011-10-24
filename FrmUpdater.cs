﻿//-----------------------------------------------------------------------
// <copyright file="FrmUpdater.cs" company="NoteFly">
//  NoteFly a note application.
//  Copyright (C) 2011  Tom
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
// </copyright>
//-----------------------------------------------------------------------
namespace NoteFly
{
    using System;
    using System.ComponentModel;
    using System.IO;
    using System.Net;
    using System.Windows.Forms;

    /// <summary>
    /// FrmUpdater window.
    /// </summary>
    public sealed partial class FrmUpdater : Form
    {
        /// <summary>
        /// The download filepath
        /// </summary>
        private string downloadfilepath;

        /// <summary>
        /// The GPGVerifWrapper class
        /// </summary>
        private GPGVerifWrapper gpgverif;

        /// <summary>
        /// Initializes a new instance of the FrmUpdater class.
        /// </summary>
        /// <param name="downloadurl">The url of the update to download</param>
        public FrmUpdater(string downloadurl)
        {
            this.InitializeComponent();
            int locx = (Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2);
            int locy = 10;
            this.Location = new System.Drawing.Point(locx, locy);
            this.backgroundWorkerDownloader.RunWorkerAsync(downloadurl);
            if (Settings.UpdatecheckUseGPG)
            {
                this.gpgverif = new GPGVerifWrapper();
            }
        }

        /// <summary>
        /// Downloading update
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">DoWorkEventArgs arguments</param>
        private void backgroundWorkerDownloader_DoWork(object sender, DoWorkEventArgs e)
        {
            string useragent = Program.AssemblyTitle + " " + Program.AssemblyVersionAsString;
            string downloadurl = (string)e.Argument;
            string downloadfilename = Path.GetFileName(downloadurl);
            if (downloadfilename.Contains("="))
            {
                int posparm = downloadfilename.LastIndexOf('=') + 1;
                if (posparm < downloadfilename.Length)
                {
                    downloadfilename = downloadfilename.Substring(posparm, downloadfilename.Length - posparm);
                }
            }

            try
            {
                this.downloadfilepath = Path.Combine(System.Environment.GetEnvironmentVariable("TEMP"), downloadfilename);
            }
            catch (NullReferenceException nullexc)
            {
                Log.Write(LogType.exception, nullexc.Message);
#if windows
                const string UNKNOWFILENAME = "NoteFly_update.exe";
                const string UNKNOWTEMPFOLDER = "C:\\temp";
#elif linux
                const string UNKNOWFILENAME = "NoteFly_update.deb";
                const string UNKNOWTEMPFOLDER = "/tmp";
#endif
                if ((string.IsNullOrEmpty(System.Environment.GetEnvironmentVariable("TEMP"))) && (string.IsNullOrEmpty(downloadfilename)))
                {
                    Directory.CreateDirectory(UNKNOWTEMPFOLDER);
                    this.downloadfilepath = Path.Combine(UNKNOWTEMPFOLDER, UNKNOWFILENAME);
                }
                else if (string.IsNullOrEmpty(System.Environment.GetEnvironmentVariable("TEMP")))
                {
                    Directory.CreateDirectory(UNKNOWTEMPFOLDER);
                    this.downloadfilepath = Path.Combine(UNKNOWTEMPFOLDER, downloadfilename);
                }
                else if (string.IsNullOrEmpty(downloadfilename))
                {
                    this.downloadfilepath = Path.Combine(System.Environment.GetEnvironmentVariable("TEMP"), UNKNOWFILENAME);
                }
            }

            if (this.CheckValidPath())
            {
                // first, we need to get the exact size (in bytes) of the file we are downloading
                Uri url = new Uri(downloadurl);
                System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                request.Timeout = Settings.NetworkConnectionTimeout;
                request.UserAgent = Program.AssemblyTitle + " " + Program.AssemblyVersionAsString;
                request.Method = "GET";
                request.AutomaticDecompression = System.Net.DecompressionMethods.GZip;
                if (Settings.NetworkProxyEnabled && !string.IsNullOrEmpty(Settings.NetworkProxyAddress))
                {
                    request.Proxy = new WebProxy(Settings.NetworkProxyAddress);
                }

                System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                response.Close();

                // gets the size of the file in bytes
                long filesize = response.ContentLength;
                if (filesize > 1073741824)
                {
                    Log.Write(LogType.exception, "To downloaded file too large, more than 1.0 Gb");
                    return;
                }


                // keeps track of the total bytes downloaded so we can update the progress bar
                long downloadedsize = 0;
                // use the webclient object to download the file
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    if (!this.CheckFileExist(this.downloadfilepath, filesize))
                    {
                        client.Headers["user-agent"] = useragent;

                        if (Settings.NetworkProxyEnabled && !string.IsNullOrEmpty(Settings.NetworkProxyAddress))
                        {
                            client.Proxy = new WebProxy(Settings.NetworkProxyAddress);
                        }

                        // open the file at the remote URL for reading
                        using (System.IO.Stream streamRemote = client.OpenRead(new Uri(downloadurl)))
                        {
                            // using the FileStream object, we can write the downloaded bytes to the file system
                            using (Stream streamLocal = new FileStream(this.downloadfilepath, FileMode.Create, FileAccess.Write, FileShare.None))
                            {
                                this.PreallocateFile(streamLocal, filesize);

                                // loop the stream and get the file into the byte buffer
                                int iByteSize = 0;
                                byte[] byteBuffer = new byte[filesize];
                                while ((iByteSize = streamRemote.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                {
                                    // write the bytes to the file system at the file path specified
                                    streamLocal.Write(byteBuffer, 0, iByteSize);
                                    downloadedsize += iByteSize;

                                    // calculate the progress out of a base "100"
                                    double dIndex = (double)downloadedsize;
                                    double dTotal = (double)byteBuffer.Length;
                                    double dProgressPercentage = dIndex / dTotal;
                                    int iProgressPercentage;
                                    if (Settings.UpdatecheckUseGPG)
                                    {
                                        iProgressPercentage = (int)(dProgressPercentage * 80);
                                    }
                                    else
                                    {
                                        iProgressPercentage = (int)(dProgressPercentage * 100);
                                    }

                                    // update the progress bar
                                    this.backgroundWorkerDownloader.ReportProgress(iProgressPercentage);
                                }

                                // clean up the file stream
                                streamLocal.Close();
                            }

                            // close the connection to the remote server
                            streamRemote.Close();
                        }
                    }

                    if (Settings.UpdatecheckUseGPG)
                    {
                        string sigfilepath = this.gpgverif.GetSignature(this.downloadfilepath);

                        // first, we need to get the exact size (in bytes) of the file we are downloading
                        Uri urlsigfileserver = new Uri(this.gpgverif.GetSignature(downloadurl));
                        System.Net.HttpWebRequest requestsig = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(urlsigfileserver);
                        requestsig.Timeout = Settings.NetworkConnectionTimeout;
                        requestsig.UserAgent = Program.AssemblyTitle + " " + Program.AssemblyVersionAsString;
                        requestsig.Method = "GET";
                        requestsig.AutomaticDecompression = System.Net.DecompressionMethods.GZip;
                        if (Settings.NetworkProxyEnabled && !string.IsNullOrEmpty(Settings.NetworkProxyAddress))
                        {
                            request.Proxy = new WebProxy(Settings.NetworkProxyAddress);
                        }

                        System.Net.HttpWebResponse responsesig = (System.Net.HttpWebResponse)requestsig.GetResponse();
                        responsesig.Close();
                        // gets the size of the signature file, should be 72 bytes
                        long filesizesig = responsesig.ContentLength;
                        if (filesizesig > 144)
                        {
                            Log.Write(LogType.exception, "To signature file too large, more than 144 bytes, excepted 72bytes");
                            return;
                        }

                        // open new stream for downloading of signature file
                        try
                        {
                            client.Headers["user-agent"] = useragent;
                            using (System.IO.Stream streamsigdownload = client.OpenRead(urlsigfileserver))
                            {
                                // using the FileStream object, we can write the downloaded bytes to the file system
                                using (Stream streamLocal = new FileStream(sigfilepath, FileMode.Create, FileAccess.Write, FileShare.None))
                                {
                                    this.PreallocateFile(streamLocal, filesizesig);

                                    // loop the stream and get the file into the byte buffer
                                    int iByteSize = 0;
                                    byte[] byteBuffer = new byte[filesizesig];
                                    while ((iByteSize = streamsigdownload.Read(byteBuffer, 0, byteBuffer.Length)) > 0)
                                    {
                                        // write the bytes to the file system at the file path specified
                                        streamLocal.Write(byteBuffer, 0, iByteSize);
                                        downloadedsize += iByteSize;
                                    }

                                    streamLocal.Close();
                                }

                                streamsigdownload.Close();
                            }
                        }
                        catch (WebException webexc)
                        {
                            Log.Write(LogType.exception, webexc.Message);
                        }

                        this.backgroundWorkerDownloader.ReportProgress(100);
                    }
                }
            }
            else
            {
                const string INVLAIDFILENAMEORPATH = "Invalid filepath/filename downloaded file";
                Log.Write(LogType.exception, INVLAIDFILENAMEORPATH);
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Check if update setup already exist
        /// </summary>
        /// <param name="file">The full path to the update file</param>
        /// <param name="filesize">The filesize of the update file</param>
        /// <returns>True if the file already exist</returns>
        private bool CheckFileExist(string file, long filesize)
        {
            bool fileexist = false;
            if (File.Exists(file))
            {
                FileInfo fi = new FileInfo(file);
                if (fi.Length == filesize)
                {
                    fileexist = true;
                }
            }

            return fileexist;
        }

        /// <summary>
        /// update download process.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">ProgressChangedEventArgs arguments</param>
        private void backgroundWorkerDownloader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressbarDownload.Value = e.ProgressPercentage;
            this.lblStatusUpdate.Text = e.ProgressPercentage + " %";
        }

        /// <summary>
        /// run download if download is compleet.
        /// </summary>
        /// <param name="sender">Sender objects</param>
        /// <param name="e">RunWorkerCompletedEventArgs arguments</param>
        private void backgroundWorkerDownloader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                const string DOWNLOADCOMPLEET = "download compleet, ";
                if (Settings.UpdatecheckUseGPG && this.gpgverif != null)
                {
                    const string VERIFDOWNLOAD = "verify download";
                    this.lblStatusUpdate.Text = DOWNLOADCOMPLEET + VERIFDOWNLOAD;
                    Log.Write(LogType.info, VERIFDOWNLOAD);

                    this.lblStatusUpdate.Refresh();
                    if (File.Exists(Settings.UpdatecheckGPGPath))
                    {
                        if (!this.gpgverif.VerifDownload(this.downloadfilepath))
                        {
                            const string INSTALLABORTED = "Aborted";
                            this.lblStatusUpdate.Text = INSTALLABORTED;
                            return;
                        }
                    }
                    else
                    {
                        const string CANNOTFINDGPG = "Verify download failed, cannot find gpg: ";
                        Log.Write(LogType.exception, CANNOTFINDGPG + Settings.UpdatecheckGPGPath);
                        return;
                    }
                }

                const string INSTALLING = "installing.. ";
                this.lblStatusUpdate.Text = DOWNLOADCOMPLEET + INSTALLING;
                this.lblStatusUpdate.Refresh();
                System.Threading.Thread.Sleep(50);

                System.Diagnostics.ProcessStartInfo procstartinfo;
                if (Settings.UpdateSilentInstall)
                {
                    procstartinfo = new System.Diagnostics.ProcessStartInfo(this.downloadfilepath, "/S");
                }
                else
                {
                    procstartinfo = new System.Diagnostics.ProcessStartInfo(this.downloadfilepath);
                }

                procstartinfo.ErrorDialog = true;
                System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.AppStarting;
                try
                {
                    System.Diagnostics.Process.Start(procstartinfo);
                }
                catch (System.ComponentModel.Win32Exception w32exc)
                {
                    Log.Write(LogType.exception, w32exc.Message);
                    this.Close();
                }

                Application.Exit();
            }
            else
            {
                this.lblStatusUpdate.Text = "aborted.";
            }
        }

        /// <summary>
        /// Check if the path does not contain forbidden filename/filepath characters
        /// </summary>
        /// <returns>true if the path is valid, false if it contains a illegal path character.</returns>
        private bool CheckValidPath()
        {
            char[] forbiddencharspath = Path.GetInvalidPathChars(); // "?<>*|\"".ToCharArray();
            if (this.downloadfilepath.IndexOfAny(forbiddencharspath) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Preallocate file
        /// </summary>
        /// <param name="filestream">A filestream</param>
        /// <param name="filesize">The filesize of the file to preallocate</param>
        private void PreallocateFile(Stream filestream, long filesize)
        {
            try
            {
                if (filesize != 0)
                {
                    filestream.SetLength(filesize);
                }
                else
                {
                    throw new ApplicationException("Empty Preallocate file");
                }
            }
            catch (IOException ioexc)
            {
                MessageBox.Show(ioexc.Message);
                Log.Write(LogType.exception, ioexc.Message);
            }
        }
    }
}
