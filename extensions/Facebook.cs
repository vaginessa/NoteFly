//-----------------------------------------------------------------------
// <copyright file="Facebook.cs" company="GNU">
//  NoteFly a note application.
//  Copyright (C) 2010  Tom
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
#define windows //platform can be: windows, linux, macos
/*
 * Decreated class, use OAuth instead.
 * 
 */

namespace NoteFly
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Communicates with facebook.
    /// </summary>
    public class Facebook
    {
        // Fields(10)
        //private OAuth.OAuthBase oauth;

        /// <summary>
        /// The API version.
        /// </summary>
        private const string APIVERISON = "1.0";

        /// <summary>
        /// The application key of NoteFly.
        /// </summary>
        private const string APPKEY = "cced88bcd1585fa3862e7fd17b2f6986";

        /// <summary>
        /// URL to figure out if signed in has failed.
        /// </summary>
        private const string FBCANCELURL = "http://www.facebook.com/connect/login_failure.html";

        /// <summary>
        /// URL to the login page.
        /// </summary>
        private const string FBLOGINPAGE = "http://www.facebook.com/login.php";

        /// <summary>
        /// The URL of the REST server page.
        /// </summary>
        //private const string FBRESTSERVERURL = "http://api.facebook.com/restserver.php";
        private const string FBRESTSERVERURL = "https://api.facebook.com/restserver.php";

        /// <summary>
        /// URL to figure out if signed in has succeed.
        /// </summary>
        private const string FBSUCCEEDURL = "http://www.facebook.com/connect/login_success.html";

        /// <summary>
        /// Title to display in the error messagebox.
        /// </summary>
        private const string MSGERRORTITLE = "Error sending note to Facebook";
        
        /// <summary>
        /// The form with webbrowser
        /// </summary>
        private Form frmLoginFb;

        /// <summary>
        /// The message to post on users wall.
        /// </summary>
        private string message;

        /// <summary>
        /// The signature of the request.
        /// </summary>
		private string sig;

        // Methods(10)

        // Public Methods(5)

        /// <summary>
        /// parser xml response, return errorcode if it returned by facebook.
        /// </summary>
        /// <param name="responsestream">The response we got from the rest server.</param>
        public void CheckResponse(string responsestream)
        {
            int responsecode = 0;
            string errorcodestartnode = "<error_code>";
            string errorcodeendnode = "</error_code>";

            if (String.IsNullOrEmpty(responsestream))
            { 
                responsecode = 1; 
            }
            else if (responsestream.Contains(errorcodestartnode))
            {
                responsecode = 1;
                int startpos = responsestream.IndexOf(errorcodestartnode) + errorcodestartnode.Length;
                int lenvalnode = responsestream.IndexOf(errorcodeendnode) - startpos;
                string errorcode = responsestream.Substring(startpos, lenvalnode);
                try
                {
                    responsecode = Convert.ToInt32(errorcode);
                }
                catch (Exception)
                {
                    responsecode = -1;
                }
            }

            const string SFACEBOOK = "Facebook";

            switch (responsecode)
            {
                case 0:
                    string notefbposted = "Your note is succefully posted on your facebook wall.";
                    Log.Write(LogType.info, notefbposted);
                    MessageBox.Show(notefbposted);
                    break;

                case 1:
                    string unknowfberror = "Unknow " + SFACEBOOK + " error occurred";
                    Log.Write(LogType.error, unknowfberror);
                    MessageBox.Show(unknowfberror, MSGERRORTITLE);
                    break;

                case 100:
                    string fbinvalidparam = SFACEBOOK + " Invalid paramters.";
                    Log.Write(LogType.error, fbinvalidparam);
                    MessageBox.Show(fbinvalidparam, MSGERRORTITLE);
                    break;

                case 104:
                    string fbinvalidsig = SFACEBOOK + " signature was invalid.";
                    Log.Write(LogType.error, fbinvalidsig);
                    MessageBox.Show(fbinvalidsig, MSGERRORTITLE);
                    break;

                case 200:
                    string fbprimission = SFACEBOOK + " no proper permission to post on your wall.";
                    Log.Write(LogType.error, fbprimission);
                    MessageBox.Show(fbprimission, MSGERRORTITLE);
                    break;

                case 210:
                    string fbusernotvisible = SFACEBOOK + " user not visible.\r\nThe user doesn't have permission to act on that object.";
                    Log.Write(LogType.error, fbusernotvisible);
                    MessageBox.Show(fbusernotvisible, MSGERRORTITLE);
                    break;

                case 240:
                    string fberror240 = SFACEBOOK + " userid(uid) wrong.";
                    Log.Write(LogType.error, fberror240);
                    MessageBox.Show(fberror240, MSGERRORTITLE);
                    break;

                case 340:
                    string fbfeedlimit = SFACEBOOK + " feed action request limit reached.";
                    Log.Write(LogType.error, fbfeedlimit);
                    MessageBox.Show(fbfeedlimit, MSGERRORTITLE);
                    break;

                case -1:
                    string notparsererrcode = SFACEBOOK + " could not parser the errorcode that was returned.";
                    Log.Write(LogType.error, notparsererrcode);
                    MessageBox.Show(notparsererrcode, MSGERRORTITLE);
                    break;

                default:
                    string errcode = SFACEBOOK+" returned unknow errorcode " + responsecode;
                    Log.Write(LogType.error, errcode);
                    MessageBox.Show(errcode, MSGERRORTITLE);
                    break;
            }
        }

		/*
        /// <summary>
        /// Check the url if facebook navigated to the succeed page
        /// meaning that we have a session.
        /// This also gets all parameters needed from the Url.
        /// </summary>
        /// <param name="url">The url to check</param>
        /// <returns>True if url is on the succeed page</returns>
        public bool IsSucceedUrl(string url)
        {
			this.sig = "";
            if (url.StartsWith(FBSUCCEEDURL) == true)
            {
                string parm = url.ToString().Substring(60, url.Length - 61);
                string[] parms = parm.Split(',');

                if (!String.IsNullOrEmpty(parms[0]) && !String.IsNullOrEmpty(parms[4]))
                {
                    foreach (string curparm in parms)
                    {
                        if (curparm.StartsWith("\"session_key\":"))
                        {
                            FacebookSettings.Sessionkey = curparm.Substring(15, curparm.Length - 16);
                        }
                        else if (curparm.StartsWith("\"uid\":"))
                        {
                            FacebookSettings.Uid = curparm.Substring(7, curparm.Length - 8);
                        }
                        else if (curparm.StartsWith("\"expires\":"))
                        {
                            try
                            {
                                FacebookSettings.Sesionexpires = Convert.ToDouble(curparm.Substring(10, curparm.Length - 10));
                            }
                            catch (Exception)
                            {
                                throw new CustomException("cannot parser unix time.");
                            }
                        }
                        else if (curparm.StartsWith("\"secret\":"))
                        {
                            FacebookSettings.Sessionsecret = curparm.Substring(10, curparm.Length - 11);
                        }
                        else if (curparm.StartsWith("\"sig\":"))
                        {
                            this.sig = curparm.Substring(7, curparm.Length - 8);
                        }
                    }

                    return true;
                }
                else
                {
                    throw new CustomException("cannot parser url parameters.");
                }
            }
            else if (url.StartsWith(FBCANCELURL) == true)
            {
                return false;
            }

            return false;
        }
	*/
		
        /// <summary>
        /// Generate a md5 hash from the given string.
        /// </summary>
        /// <param name="input">The content to create an hash of.</param>
        /// <returns>The MD5 hash</returns>
        public string MakeMD5(string input)
        {
            MD5 md5hasher = MD5.Create();
            byte[] data = md5hasher.ComputeHash(Encoding.Default.GetBytes(input));
            StringBuilder strbuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                strbuilder.Append(data[i].ToString("x2"));
            }

            return strbuilder.ToString();
        }

        /// <summary>
        /// Post a message to the stream.
        /// </summary>
        /// <param name="message">the message</param>
        /// <returns>response code (as json or xml?)</returns>
        public string PostStream(string message)
        {
//            WebRequest request = WebRequest.Create(FBRESTSERVERURL);
//            request.Method = "POST";
//            request.ContentType = "application/x-www-form-urlencoded";
//
//            xmlHandler settting = new xmlHandler(true);
//            if (settting.getXMLnodeAsBool("useproxy") == true)
//            {
//                string addr = settting.getXMLnode("proxyaddr");
//                if (String.IsNullOrEmpty(addr) || addr == "0.0.0.0" || addr == "255.255.255.255")
//                {
//                    string novalidproxy = "Proxy address is not given";
//                    MessageBox.Show(novalidproxy);
//                    Log.Write(LogType.error, novalidproxy);
//                    return String.Empty;
//                }
//                else
//                {
//                    request.Proxy = new WebProxy(settting.getXMLnode("proxyaddr"));
//                }
//            }
//
//            if (settting.getXMLnodeAsBool("savesession"))
//            {
//                try
//                {
//                    bool[] boolsettings = settting.ParserSettingsBool();
//
//                    settting.WriteSettings(
//                        boolsettings[0],
//                        Convert.ToDecimal(settting.getXMLnodeAsInt("transparecylevel")), 
//                        settting.getXMLnodeAsInt("defaultcolor"),
//                        settting.getXMLnodeAsInt("actionleftclick"),
//                        boolsettings[1],
//                        settting.getXMLnode("fontcontent"),
//                        Convert.ToDecimal(settting.getXMLnodeAsInt("fontsize")),
//                        settting.getXMLnodeAsInt("textdirection"),
//                        settting.getXMLnode("notesavepath"),
//                        settting.getXMLnode("defaultemail"),
//                        boolsettings[4],
//                        boolsettings[5],
//                        boolsettings[6],
//                        settting.getXMLnode("twitteruser"),
//                        settting.getXMLnode("twitterpass"),
//                        boolsettings[2],
//                        boolsettings[3],
//                        boolsettings[7],
//                        settting.getXMLnode("proxyaddr"),
//                        settting.getXMLnodeAsInt("timeout"),
//                        true,
//                        boolsettings[8]);
//                }
//                catch (Exception fbsessionexc)
//                {
//                    string fbsessionsave = "Cannot save facebook session.\r\n" + fbsessionexc.StackTrace;
//                    Log.Write(LogType.exception, fbsessionsave);
//                    MessageBox.Show(fbsessionsave);
//                }
//            }
//
//            request.Timeout = settting.getXMLnodeAsInt("timeout");
//
//            string data = this.CreatePostData(message);
//
//            byte[] bytes = Encoding.UTF8.GetBytes(data);
//            request.ContentLength = bytes.Length;
//            using (Stream requestStream = request.GetRequestStream())
//            {
//                requestStream.Write(bytes, 0, bytes.Length);
//                try
//                {
//                    using (WebResponse response = request.GetResponse())
//                    {
//                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
//                        {
//                            return reader.ReadToEnd();
//                        }
//                    }
//                }
//                catch (TimeoutException)
//                {
//                    string contimeout = "connection timeout";
//                    Log.Write(LogType.error, contimeout);
//                    MessageBox.Show(contimeout);
//                }
//                catch (Exception exc)
//                {
//                    Log.Write(LogType.exception, exc.Message);
//                    MessageBox.Show("Exception: " + exc.Message);
//                }
//            }
//
            return null;
        }

        /// <summary>
        /// Begin with posting a note.
        /// </summary>
        /// <param name="note">The note to post</param>
        public void StartPostingNote(string note)
        {
//            this.message = note;
//            if (String.IsNullOrEmpty(FacebookSettings.Sessionkey) || FacebookSettings.Sessionsecret.Length == 0 || String.IsNullOrEmpty(FacebookSettings.Uid))
//            {
//                this.ShowFBLoginForm();
//            }
//            else
//            {
//                System.DateTime dtexpiressession = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
//                dtexpiressession = dtexpiressession.AddSeconds(FacebookSettings.Sesionexpires);
//
//                if (dtexpiressession.Month == DateTime.Now.Month)
//                {
//                    if ((dtexpiressession.Day == DateTime.Now.Day + 1) || ((dtexpiressession.Day == DateTime.Now.Day) && (dtexpiressession.Hour > DateTime.Now.Hour)))
//                    {
//                        this.CheckResponse(this.PostStream(this.message));
//                    }
//                    else
//                    {
//                        this.ShowFBLoginForm();
//                    }
//                }
//                else if ((dtexpiressession.Month + 1 == DateTime.Now.Month) && (dtexpiressession.Day == 1))
//                {
//                    this.CheckResponse(this.PostStream(this.message));
//                }
//                else
//                {
//                    this.ShowFBLoginForm();
//                }
//            }
        }

        // Private Methods(5)

        /// <summary>
        /// Construct a right login url.
        /// </summary>
        /// <returns>The url to the login page with the right parameters.</returns>
        private string CreateLoginURL()
        {
            return FBLOGINPAGE + "?api_key=" + APPKEY + "&connect_display=popup&v=" + APIVERISON + "&fbconnect=true&session_key_only=true&return_session=true&next=" + FBSUCCEEDURL + "&cancel_url=" + FBCANCELURL;
        }

        /// <summary>
        /// Create the data to post and attach the generated signature.
        /// </summary>
        /// <param name="message">The message to post.</param>
        /// <returns>The data to post.</returns>
        private string CreatePostData(string message)
        {
            string data = "api_key=" + APPKEY;
            string callid = DateTime.Now.Ticks.ToString("x", CultureInfo.InvariantCulture);
            data += "&call_id=" + callid;
            data += "&message=" + message;
            string methode = "facebook.stream.publish";
            data += "&method=" + methode;
            //data += "&session_key=" + FacebookSettings.Sessionkey;
            string usesessionsecret = "1";
            data += "&ss=" + usesessionsecret;
            data += "&uid=0"; //use 0 not FacebookSettings.Uid;  bug: #0000007
            data += "&v=" + APIVERISON;
            //data += "&sig=" + this.GenerateSignature(callid, message, methode, usesessionsecret);
            if (data.Length > 0)
            {
                return data;
            }
            else
            {
                throw new CustomException("data too small.");
            }
        }

        /// <summary>
        /// Login is happening.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">webbrowser event arguments</param>
        private void FbWeb_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //if (this.IsSucceedUrl(e.Url.ToString()) == true)
            //{
                this.CheckResponse(this.PostStream(this.message));
                this.frmLoginFb.Close();
            //}
        }

		/*
        /// <summary>
        /// Create a signature based on serveral parameters.
        /// </summary>
        /// <param name="call_id">Something higher than previous call_id</param>
        /// <param name="message">The content to send.</param>
        /// <param name="methode">The methode for rest api.</param>
        /// <param name="sessionsecret">1 for using sessionsecret</param>
        /// <returns>The generated signature based on the parameters.</returns>
        private string GenerateSignature(string call_id, string message, string methode, string usesessionsecret)
        {
            StringBuilder secret = new StringBuilder();
            for (int i = 0; i < FacebookSettings.Sessionsecret.Length; i++)
            {
                secret.Append(FacebookSettings.Sessionsecret[i]);
            }

            string data = "api_key=" + APPKEY + "call_id=" + call_id + "message=" + message + "method=" + methode + "session_key=" + FacebookSettings.Sessionkey + "ss=" + usesessionsecret + "uid=0" + "v=" + APIVERISON + secret.ToString(); //use 0 not FacebookSettings.Uid  bug: #0000007

            string hash = this.MakeMD5(data);
            if (hash.Length == 32)
            {
                return hash;
            }
            else
            {
                throw new CustomException("Cannot generate MD5 hash.");
            }
        }
		 */
        /// <summary>
        /// create a form with webbrowser and navigate to
        /// the facebook login page for this application.
        /// </summary>
        private void ShowFBLoginForm()
        {
            // Grant access.form
            this.frmLoginFb = new Form();
            this.frmLoginFb.ShowIcon = false;
            this.frmLoginFb.StartPosition = FormStartPosition.CenterScreen;
            this.frmLoginFb.Text = "Post note on FaceBook";
            this.frmLoginFb.Width = 640;
            this.frmLoginFb.Height = 480;
            WebBrowser fbweb = new WebBrowser();
            fbweb.Name = "FbWeb";
            fbweb.Location = new System.Drawing.Point(10, 10);
            fbweb.Dock = DockStyle.Fill;
            this.frmLoginFb.Controls.Add(fbweb);
            fbweb.Navigated += new WebBrowserNavigatedEventHandler(this.FbWeb_Navigated);
            fbweb.Navigate(this.CreateLoginURL());
            this.frmLoginFb.Show();
        }
    }
}