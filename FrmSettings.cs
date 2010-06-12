//-----------------------------------------------------------------------
// <copyright file="FrmSettings.cs" company="GNU">
// 
// This program is free software; you can redistribute it and/or modify it
// Free Software Foundation; either version 2, 
// or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// </copyright>
//-----------------------------------------------------------------------
#define linux //platform can be: windows, linux, macos

namespace NoteFly
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
#if windows
    using Microsoft.Win32;
#endif

    /// <summary>
    /// Setting window.
    /// </summary>
    public partial class FrmSettings : Form
    {
        #region Fields (2)

        private Notes notes;
        private xmlHandler xmlsettings;

        #endregion Fields

        #region Constructors (1)

        /// <summary>
        /// Initializes a new instance of the FrmSettings class.
        /// </summary>
        /// <param name="notes">The notes class.</param>
        public FrmSettings(Notes notes)
        {
            this.InitializeComponent();
            this.xmlsettings = new xmlHandler(true);
            
            //read setting and display them correctly.
            bool[] boolsetting = this.xmlsettings.ParserSettingsBool();
            this.chxTransparecy.Checked = boolsetting[0];
            this.chxConfirmLink.Checked = boolsetting[1];
            this.chxLogErrors.Checked = boolsetting[2];
            this.chxLogDebug.Checked = boolsetting[3];
            this.chxSyntaxHighlightHTML.Checked = boolsetting[4];
            this.chxConfirmExit.Checked = boolsetting[5];
            this.chxConfirmDeleteNote.Checked = boolsetting[6];
            this.chxUseProxy.Checked = boolsetting[7];
            this.chxSaveFBSession.Checked = boolsetting[8];
            if (boolsetting[6])
            {
                this.iptbProxyAddress.Enabled = true;
            }

            this.numProcTransparency.Value = this.GetTransparecylevel();
            this.cbxDefaultColor.SelectedIndex = this.GetDefaultColor();
            this.cbxActionLeftClick.SelectedIndex = this.GetActionLeftClick();

            this.tbNotesSavePath.Text = this.GetNotesSavePath();
            this.tbTwitterUser.Text = this.GetTwitterusername();
            this.tbTwitterPass.Text = this.GetTwitterpassword();
            this.tbDefaultEmail.Text = this.GetDefaultEmail();

            this.cbxTextDirection.SelectedIndex = this.GetTextDirection();
#if windows
            this.chxStartOnBootWindows.Checked = this.GetStatusStartlogin();
#endif
            this.numTimeout.Value = this.GetTimeout();

            if (String.IsNullOrEmpty(this.tbDefaultEmail.Text))
            {
                this.tbDefaultEmail.Enabled = false;
                this.cbxDefaultEmailToBlank.Checked = true;
            }
            else
            {
                this.tbDefaultEmail.Enabled = true;
                this.cbxDefaultEmailToBlank.Checked = false;
            }

            this.DrawCbxFonts();
#if DEBUG
            this.btnCrash.Visible = true;
#endif
            this.notes = notes;

            boolsetting = null;
        }

        #endregion Constructors

        #region Methods (24)

        // Private Methods (24) 

        /// <summary>
        /// User want to browse for notes save path.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments</param>
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgresult = this.folderBrowserDialog1.ShowDialog();
            if (dlgresult == DialogResult.OK)
            {
                string newpathsavenotes = this.folderBrowserDialog1.SelectedPath;
                
                if (Directory.Exists(newpathsavenotes))
                {
                    this.tbNotesSavePath.Text = this.folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    const string dirnotexist = "Directory does not exist.\r\nPlease choice a valid directory.";
                    Log.Write(LogType.info, dirnotexist);
                    MessageBox.Show(dirnotexist, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Cancel button pressed.
        /// Don't save any change made.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Test method to see how custom exceptions are handled.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event arguments</param>
        private void btnCrash_Click(object sender, EventArgs e)
        {
            #if DEBUG
            throw new CustomException("This is a crash test, to test if exceptions are thrown correctly.");
            #endif
        }

        /// <summary>
        /// Check the form input. If everything is okay
        /// call xmlHandler class to save the xml setting file.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(this.tbNotesSavePath.Text))
            {
                const string invalidfoldersavenote = "Invalid folder for saving notes folder.";
                Log.Write(LogType.info, invalidfoldersavenote);
                MessageBox.Show(invalidfoldersavenote);
                this.tabControlSettings.SelectedTab = this.tabGeneral;
            }
            else if (String.IsNullOrEmpty(this.cbxFontNoteContent.Text) == true)
            {
                const string nofont = "Select a font.";
                Log.Write(LogType.info, nofont);
                MessageBox.Show(nofont);
                this.tabControlSettings.SelectedTab = this.tabAppearance;
            }
            else if ((this.numFontSize.Value < 4) || (this.numFontSize.Value > 128))
            {
                const string invalidfontsize = "Font size invalid. minimal 4pt max. 128pt";
                Log.Write(LogType.info, invalidfontsize);
                MessageBox.Show(invalidfontsize);
                this.tabControlSettings.SelectedTab = this.tabAppearance;
            }
            else if (this.cbxTextDirection.SelectedIndex > 1)
            {
                const string noknowtextdir = "Settings text direction unknow.";
                Log.Write(LogType.error, noknowtextdir);
                MessageBox.Show(noknowtextdir);
                this.tabControlSettings.SelectedTab = this.tabAppearance;
            }
            else if ((this.chxSyntaxHighlightHTML.CheckState == CheckState.Indeterminate) 
                    #if windows 
                      || (this.chxStartOnBootWindows.CheckState == CheckState.Indeterminate)
                   #endif 
                      || (this.chxConfirmExit.CheckState == CheckState.Indeterminate) || (this.chxLogErrors.CheckState == CheckState.Indeterminate) || (this.chxLogDebug.CheckState == CheckState.Indeterminate))
            {
                const string notallowcheckstate = "Checkstate not allowed.";
                Log.Write(LogType.error, notallowcheckstate);
                MessageBox.Show(notallowcheckstate);
                this.tabControlSettings.SelectedTab = this.tabAppearance;
            }

            else if (this.tbTwitterUser.Text.Length > 16)
            {
                const string twnametoolong = "Settings Twitter: username is too long.";
                Log.Write(LogType.error, twnametoolong);
                MessageBox.Show(twnametoolong);
            }
            else if ((this.tbTwitterPass.Text.Length < 6) && (this.chxRememberTwPass.Checked == true))
            {
                const string twpaswtooshort = "Settings Twitter: password is too short.";
                Log.Write(LogType.error, twpaswtooshort);
                MessageBox.Show(twpaswtooshort);
            }
            else if ((!this.tbDefaultEmail.Text.Contains("@") || !this.tbDefaultEmail.Text.Contains(".")) && (!this.cbxDefaultEmailToBlank.Checked))
            {
                const string emailnotvalid = "Settings advance: default emailadres not valid.";
                Log.Write(LogType.error, emailnotvalid);
                MessageBox.Show(emailnotvalid);
            }
            else
            {
                //everything looks okay 
                string oldnotesavepath = this.GetNotesSavePath();
                if (this.tbNotesSavePath.Text != oldnotesavepath)
                {
                    this.MoveNotes(this.tbNotesSavePath.Text);
                }

                this.xmlsettings.WriteSettings(
                    this.chxTransparecy.Checked,
                    this.numProcTransparency.Value,
                    this.cbxDefaultColor.SelectedIndex,
                    this.cbxActionLeftClick.SelectedIndex,
                    this.chxConfirmLink.Checked,
                    this.cbxFontNoteContent.Text, 
                    this.numFontSize.Value,
                    this.cbxTextDirection.SelectedIndex,
                    this.tbNotesSavePath.Text,
                    this.tbDefaultEmail.Text,
                    this.chxSyntaxHighlightHTML.Checked,
                    this.chxConfirmExit.Checked,
                    this.chxConfirmDeleteNote.Checked,
                    this.tbTwitterUser.Text,
                    this.tbTwitterPass.Text,
                    this.chxLogErrors.Checked,
                    this.chxLogDebug.Checked,
                    this.chxUseProxy.Checked,
                    this.iptbProxyAddress.GetIPAddress(),
                    Convert.ToInt32(this.numTimeout.Value),
                    true,
                    this.chxSaveFBSession.Checked);
#if windows
                RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (key != null)
                {
                    if (this.chxStartOnBootWindows.Checked == true)
                    {
                        try
                        {
                            key.SetValue(TrayIcon.AssemblyTitle, "\"" + Application.ExecutablePath + "\"");
                        }
                        catch (UnauthorizedAccessException unauthexc)
                        {
                            Log.Write(LogType.exception, unauthexc.Message);
                            MessageBox.Show(unauthexc.Message);
                        }
                        catch (Exception exc)
                        {
                            throw new CustomException(exc.Message + " " + exc.StackTrace);
                        }
                    }
                    else if (this.chxStartOnBootWindows.Checked == false)
                    {
                        if (key.GetValue(TrayIcon.AssemblyTitle, null) != null)
                        {
                            key.DeleteValue(TrayIcon.AssemblyTitle, false);
                        }
                    }
                }
                else
                {
                    const string regkeynotexistfound = "Run subkey in registery does not exist.\r\nOr it cannot be found.";
                    Log.Write(LogType.error, regkeynotexistfound);
                    MessageBox.Show(regkeynotexistfound);
                }
#endif
                this.notes.SetSettings();
                this.notes.UpdateAllFonts();
                Log.Write(LogType.info, "settings updated.");
                this.Close();
            }
        }

        /// <summary>
        /// reset button clicked.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            DialogResult dlgres = MessageBox.Show("Are you sure, you want to reset your settings?", "reset settings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlgres == DialogResult.Yes)
            {
                string settingsfile = Path.Combine(this.xmlsettings.AppDataFolder, "settings.xml");
                if (File.Exists(settingsfile))
                {
                    File.Delete(settingsfile);
                    this.xmlsettings = new xmlHandler(true);
                }
                else
                {
                    throw new Exception("Could not find settings file in application directory.");
                }

                this.Close();
            }
        }

        /// <summary>
        /// User changed if the default e-mail should be blank or not.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">event arguments</param>
        private void cbxDefaultEmailToBlank_CheckedChanged(object sender, EventArgs e)
        {
            this.tbDefaultEmail.Enabled = !this.cbxDefaultEmailToBlank.Checked;
            if (this.cbxDefaultEmailToBlank.Checked)
            {
                this.tbDefaultEmail.Text = String.Empty;
            }
        }

        /// <summary>
        /// Enable password editbox on checking remember password
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void cbxRememberTwPass_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chxRememberTwPass.Checked == true)
            {
                this.tbTwitterPass.Enabled = true;
            }
            else
            {
                this.tbTwitterPass.Enabled = false;
                this.tbTwitterPass.Text = String.Empty;
            }
        }

        /// <summary>
        /// Enable nummericupdown control if transparecy is checked.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void cbxTransparecy_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chxTransparecy.Checked == false)
            {
                this.numProcTransparency.Enabled = false;
            }
            else if (this.chxTransparecy.Checked == true)
            {
                this.numProcTransparency.Enabled = true;
            }
        }

        /// <summary>
        /// Fill combobox list with fonts
        /// </summary>
        private void DrawCbxFonts()
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                this.cbxFontNoteContent.Items.Add(oneFontFamily.Name);
            }

            string curfont = this.xmlsettings.getXMLnode("fontcontent");
            if (String.IsNullOrEmpty(curfont))
            {
                const string fontnotfound = "Current font not found.";
                Log.Write(LogType.error, fontnotfound);
                MessageBox.Show(fontnotfound, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.cbxFontNoteContent.Text = curfont;
            }
        }

        /// <summary>
        /// Gets setting what happens if user clicks left on trayicon.
        /// </summary>
        /// <returns>The integer setting.</returns>
        private int GetActionLeftClick()
        {
            return this.xmlsettings.getXMLnodeAsInt("actionleftclick");
        }

        /// <summary>
        /// Gets the default color.
        /// </summary>
        /// <returns>The defaultcolor setting as integer.</returns>
        private int GetDefaultColor()
        {
            return this.xmlsettings.getXMLnodeAsInt("defaultcolor");
        }

        /// <summary>
        /// Gets the textdirection setting.
        /// </summary>
        /// <returns>The text direction setting as integer.</returns>
        private int GetTextDirection()
        {
            return this.xmlsettings.getXMLnodeAsInt("textdirection");
        }

        /// <summary>
        /// Gets if notefly is used to run at logon.
        /// bugfix: 0000006
        /// </summary>
        /// <returns>The boolean if it starts at logon.</returns>
        private bool GetStatusStartlogin()
        {
#if windows
            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (key != null)
            {
                if (key.GetValue("NoteFly", null) != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
#endif
            return false;
        }

        /// <summary>
        /// The default email address.
        /// </summary>
        /// <returns>default email address as string</returns>
        private string GetDefaultEmail()
        {
            return this.xmlsettings.getXMLnode("defaultemail");
        }

        /// <summary>
        /// The notes save path.
        /// </summary>
        /// <returns>notes save path as string</returns>
        private string GetNotesSavePath()
        {
            return this.xmlsettings.getXMLnode("notesavepath");
        }

        /// <summary>
        /// The proxy address.
        /// </summary>
        /// <returns>proxy address as string</returns>
        private string GetProxyAddr()
        {
            return this.xmlsettings.getXMLnode("proxyaddr");
        }

        /// <summary>
        /// The twitter username.
        /// </summary>
        /// <returns>twitter username as string.</returns>
        private string GetTwitterusername()
        {
            return this.xmlsettings.getXMLnode("twitteruser");
        }

        /// <summary>
        /// Get the twitter password from the settings.
        /// </summary>
        /// <returns>the password as string</returns>
        private string GetTwitterpassword()
        {
            string twpass = this.xmlsettings.getXMLnode("twitterpass");
            if (String.IsNullOrEmpty(twpass))
            {
                this.chxRememberTwPass.Checked = false;
                this.tbTwitterPass.Enabled = false;
            }

            return twpass;
        }

        /// <summary>
        /// Get the timeout settting.
        /// </summary>
        /// <returns>The timeout as decimal.</returns>
        private decimal GetTimeout()
        {
            int timeout = this.xmlsettings.getXMLnodeAsInt("networktimeout");
            if (timeout < 0)
            {
                Log.Write(LogType.error, "Network timeout not set or negative.");
                return 10000;
            }
            else
            {
                return Convert.ToDecimal(timeout);
            }
        }

        /// <summary>
        /// Get the transparecy level.
        /// </summary>
        /// <returns>The transparecy level as decimal</returns>
        private decimal GetTransparecylevel()
        {
            decimal transparecylvl = Convert.ToDecimal(this.xmlsettings.getXMLnode("transparecylevel"), System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            if ((transparecylvl < 1) || (transparecylvl > 100))
            {
                String translvlrang = "transparecylevel out of range.";
                Log.Write(LogType.error, translvlrang);
                MessageBox.Show(translvlrang);
                return 95;
            }
            else { return transparecylvl; }
        }

        /// <summary>
        /// Move note files.
        /// </summary>
        /// <param name="newpathsavenotes">The new path wear to save the notes to.</param>
        private void MoveNotes(string newpathsavenotes)
        {
            bool errorshowed = false;
            string oldpathsavenotes = this.GetNotesSavePath();
            int id = 1;
            while (File.Exists(Path.Combine(oldpathsavenotes, id + ".xml")) == true)
            {
                if (Directory.Exists(newpathsavenotes))
                {
                    string oldfile = Path.Combine(oldpathsavenotes, id + ".xml");
                    string newfile = Path.Combine(newpathsavenotes, id + ".xml");
                    if (!File.Exists(newfile))
                    {
                        FileInfo fi = new FileInfo(oldfile);
                        if (fi.Attributes != FileAttributes.System)
                        {
                            File.Move(oldfile, newfile);
                        }
                        else { throw new CustomException("File is marked as system file. Did not move."); }
                    }
                    else
                    {
                        if (!errorshowed)
                        {
                            string fileexist = "File " + id + ".xml already exist in new folder.";
                            Log.Write(LogType.error, fileexist);
                            MessageBox.Show(fileexist);
                            errorshowed = true;
                        }
                    }
                }

                id++;
            }
        }

        /// <summary>
        /// The user changed the proxy settings.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chxUseProxy_CheckedChanged(object sender, EventArgs e)
        {
            this.iptbProxyAddress.Enabled = this.chxUseProxy.Checked;
        }

        #endregion Methods
    }
}
