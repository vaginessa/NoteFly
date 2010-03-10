﻿/* Copyright (C) 2009-2010
 * 
 * This program is free software; you can redistribute it and/or modify it
 * Free Software Foundation; either version 2, or (at your option) any
 * later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


#if win32
using System.Runtime.InteropServices;

#endif

namespace NoteFly
{
    public partial class FrmNote : Form
    {
		#region Fields (10)

        public Notes notes;

        private TextHighlight highlight;
        private String note;
        private Int16 id, notecolor = 0;
        private Boolean notevisible = true, rolledup = false, notelock = false;
        private Skin skin;
        private Int32 locX, locY;
        private UInt16 noteWidth, noteHeight;
        private String title, twpass;
        private PictureBox pbShowLock;
        private const int minvisiblesize = 5;
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;

		#endregion Fields 

		#region Constructors (2) 

        public FrmNote(Notes notes, Int16 id, bool visible, bool ontop, string title, string note, Int16 notecolor, int locX, int locY, int notewidth, int noteheight)
        {
            this.notes = notes;
            this.notevisible = visible;
            this.FormBorderStyle = FormBorderStyle.None;
            this.skin = new Skin(notecolor);
            
            this.id = id;
            this.title = title;
            this.note = note;
            this.notecolor = notecolor;

            if ((locX + notewidth > minvisiblesize) && (locY + noteheight > minvisiblesize))
            {
                this.locX = locX;
                this.locY = locY;
            }
            else
            {
                this.locX = 10;
                this.locY = 10;
            }
            
            notes.NotesUpdated = true;

            if (this.notevisible)
            {
                
                InitializeComponent();

                this.lblTitle.Text = title;
                this.rtbNote.Text = note;

                this.SetSizeNote(notewidth, noteheight);
                this.SetPosNote();
                this.CheckThings();
            }
            else
            {
                //this.Hide();
            }

            if (ontop)
            {
                this.menuOnTop.Checked = true;
                this.TopMost = true;
            }
            else
            {
                this.menuOnTop.Checked = false;
                this.TopMost = false;
            }
        }

        public FrmNote(Notes notes, Int16 id, string title, string note, Int16 notecolor)
        {
            this.skin = new Skin(notecolor);
            this.id = id;
            this.title = title;
            this.note = note;
            //this.transparency = transparency;
            this.notecolor = notecolor;
            //set default location note
            this.locX = 10;
            this.locY = 10;
            //set width and height to default
            this.Width = 240;
            this.Height = 240;
            this.notes = notes;
            InitializeComponent();

            PaintColorNote();
            lblTitle.Text = title;
            rtbNote.Text = note;
            SetPosNote();
            CheckThings();
            notes.NotesUpdated = true;
        }

		#endregion Constructors 

		#region Properties (4) 

        public Int16 NoteColor
        {
            get
            {
                return this.notecolor;
            }
            set
            {
                value = notecolor;
            }
        }

        public Boolean NoteVisible
        {
            get
            {
                return this.notevisible;
            }
            set
            {
                this.notevisible = value;
            }
        }

        public string NoteContent
        {
            get { return this.note; }
            set
            {
                note = value;
                rtbNote.Text = note;
            }
        }

        public Int16 NoteID
        {
            get { return id; }
            set { this.id = value; }
        }

        public string NoteTitle
        {
            get { return this.title; }
            set
            {
                title = value;
                lblTitle.Text = title;
            }
        }

		#endregion Properties 

		#region Methods (32) 

		// Public Methods (2) 

        /// <summary>
        /// Check if twitter is enabled and check Syntax.
        /// </summary>
        public void CheckThings()
        {
            checkTwitter(notes.TwitterEnabled);

            PaintColorNote();

            if ((notes.HighlightHTML == true))
            {
                if (highlight == null)
                {
                    highlight = new TextHighlight(this.rtbNote, notes.HighlightHTML);
                }
                highlight.CheckSyntaxFull();
            }
        }

        /// <summary>
        /// Save the setting of the note.
        /// </summary>
        public void UpdateThisNote()
        {
            SavePos.RunWorkerAsync();
        }
		// Private Methods (30) 

        /// <summary>
        /// Find what password is entered.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="e"></param>
        private void askpassok(object obj, EventArgs e)
        {
            Button btnobj = (Button)obj;
            Form frmAskpass = btnobj.FindForm();

            Control[] passctr = frmAskpass.Controls.Find("tbPassword", false);
            if (String.IsNullOrEmpty(passctr[0].Text))
            {
                passctr[0].BackColor = Color.Red;
                return;
            }
            twpass = passctr[0].Text;
            frmAskpass.Close();
            foreach (Control cntrl in frmAskpass.Controls)
            {
                cntrl.Dispose();
            }
            frmAskpass.Dispose();

            tweetnote();
        }

        /// <summary>
        /// Hide note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseNote_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            notes.NotesUpdated = true;
            this.Hide();
        }

        /// <summary>
        /// Check if there is internet connection, if not warn user.
        /// </summary>
        /// <returns>true if there is a coonection, otherwise return false</returns>
        private bool checkConnection()
        {
            #if win32
            if (IsConnectedToInternet() == true)
            {
                return true;
            }
            else
            {
                String msgNoNetwork = "There is no network connection.";
                MessageBox.Show(msgNoNetwork);
                Log.Write(LogType.error, msgNoNetwork);
                return false;
            }
            #elif !win32
            return true;
            #endif
        }

        /// <summary>
        /// check if twitter is enabled.
        /// </summary>
        /// <param name="twitterenabled"></param>
        private void checkTwitter(bool twitterenabled)
        {
            if (twitterenabled)
            {
                tsmenuSendToTwitter.Enabled = true;
            }
            else
            {
                tsmenuSendToTwitter.Enabled = false;
            }
        }

        private void contextMenuStripNoteOptions_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (skin != null)
            {
                pnlHead.BackColor = skin.getObjColor(false);
            }
        }

        /// <summary>
        /// copy note content to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(note);
        }

        /// <summary>
        /// copy title to clipboard.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(title);
        }

        /// <summary>
        /// Edit note is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (this.NoteID > notes.NumNotes)
            {
                String cannotfindnote = "Cannot find note.";
                MessageBox.Show(cannotfindnote);
                Log.Write(LogType.error, cannotfindnote);
            }
            notes.EditNewNote(this.NoteID);
        }

        /// <summary>
        /// E-mail note is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string emailnote;

#if win32
            emailnote = note.Replace("\r\n", "%0D%0A");
#elif mac
            emailnote = note.Replace("\r", "%0D%0A");
#elif linux                        
            emailnote = note.Replace("\n", "%0D%0A");
#endif
            xmlHandler xmlsettings = new xmlHandler(true);

            string defaultemail = xmlsettings.getXMLnode("defaultemail");

            if ((!String.IsNullOrEmpty(title)) && (String.IsNullOrEmpty(emailnote)))
            {
                System.Diagnostics.Process.Start("mailto:" + defaultemail + "?subject=" + title + "&body=" + emailnote);
            }
            else if (!String.IsNullOrEmpty(title))
            {
                System.Diagnostics.Process.Start("mailto:" + defaultemail + "?subject=" + title);
            }
            else
            {
                String msgNoTitleContent = "Note has no title and content.";
                Log.Write(LogType.error, msgNoTitleContent);
                MessageBox.Show(msgNoTitleContent);
            }
        }

        /// <summary>
        /// Form got focus, remove transparency
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNote_Activated(object sender, EventArgs e)
        {
                if ((notes.Transparency) && (skin != null))
                {
                    this.Opacity = 1.0;
                }
        }

        /// <summary>
        /// Form is not active anymore, make transparent if allowed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNote_Deactivate(object sender, EventArgs e)
        {
                if ((notes.Transparency) && (skin != null))
                {
                    this.Opacity = skin.getTransparencylevel();
                }
        }

        private void hideNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCloseNote_Click(sender, e);
        }

        /// <summary>
        /// Lock note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void locknoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!notelock)
            {
                notelock = true;
                menuLockNote.Text = "lock note (click again to unlock)";

                CreatePbLock();
                
                this.menuNoteColors.Enabled = false;
                this.menuEditNote.Enabled = false;
                this.menuOnTop.Enabled = false;
            }
            else
            {
                notelock = false;
                menuLockNote.Text = "lock note";

                DestroyPbLock();

                this.menuNoteColors.Enabled = true;
                this.menuEditNote.Enabled = true;
                this.menuOnTop.Enabled = true;
            }
        }

        /// <summary>
        /// Create a PictureBox with lock picture.
        /// </summary>
        private void CreatePbLock()
        {
            this.pbShowLock = new PictureBox();
            this.pbShowLock.Name = "pbShowLock";
            this.pbShowLock.Location = new Point(btnCloseNote.Location.X - 24, 8);
            this.pbShowLock.Size = new Size(16, 16);
            this.pbShowLock.Image = new Bitmap(NoteFly.Properties.Resources.locknote);
            this.pbShowLock.Visible = true;
            this.pnlHead.Controls.Add(this.pbShowLock);
        }

        /// <summary>
        /// Removes and freese memory lock picture.
        /// </summary>
        private void DestroyPbLock()
        {
            this.pbShowLock.Visible = false;
            this.pbShowLock.Dispose();
        }

        /// <summary>
        /// Roll the note up and down.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuRollUp_Click(object sender, EventArgs e)
        {
            rolledup = !rolledup;

            if (rolledup)
            {
                this.menuRollUp.Text = menuRollUp.Text+"(click again to Roll Down)";
                this.MinimumSize = new Size(this.MinimumSize.Width, pnlHead.Height);
                this.Height = this.Height - pnlNote.Height;
                this.menuRollUp.Checked = true;
            }
            else
            {
                this.menuRollUp.Text = menuRollUp.Text.Substring(0, 7);
                this.MinimumSize = new Size(this.MinimumSize.Width, pnlHead.Height+this.pbResizeGrip.Height);
                this.Height = this.noteHeight;
                this.menuRollUp.Checked = false;
            }
        }

        /// <summary>
        /// Make a note on top
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuOnTop.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
            if (!notelock && !SavePos.IsBusy)
            {
                SavePos.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Get the color of the note and paint it.
        /// </summary>
        private void PaintColorNote()
        {
            skin = new Skin(notecolor);
            Color normalcolor = skin.getObjColor(false);

            this.BackColor = normalcolor;
            this.pnlHead.BackColor = normalcolor;
            this.pnlNote.BackColor = normalcolor;
            this.rtbNote.BackColor = normalcolor;

            if (notes.TextDirection == 0)
            {
                lblTitle.TextAlign = ContentAlignment.TopLeft;
                rtbNote.SelectionAlignment = HorizontalAlignment.Left;
            }
            else if (notes.TextDirection == 1)
            {
                lblTitle.TextAlign = ContentAlignment.TopRight;

                rtbNote.SelectAll();
                rtbNote.SelectionAlignment = HorizontalAlignment.Right;
            }
            rtbNote.Font = skin.getFontNoteContent();
        }

        /// <summary>
        /// Resize note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbResizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!notelock)
                {
                    this.Cursor = Cursors.SizeNWSE;
                    this.Size = new Size(this.PointToClient(MousePosition).X, this.PointToClient(MousePosition).Y);
                }
            }
            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Save resized note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbResizeGrip_MouseUp(object sender, MouseEventArgs e)
        {
            if (!notelock && !SavePos.IsBusy)
            {
                SavePos.RunWorkerAsync();
            }
        }

       /// <summary>
       /// pnlHead the grab area is selected.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void pnlHead_MouseDown(object sender, MouseEventArgs e)
        {
            if (skin != null)
            {
                pnlHead.BackColor = skin.getObjColor(true);
            }

            if (e.Button == MouseButtons.Left)
            {
#if win32
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
#endif

                if (skin != null)
                {
                    pnlHead.BackColor = skin.getObjColor(false);
                }

                this.locX = this.Location.X;
                this.locY = this.Location.Y;
            }

            if (SavePos.IsBusy == false)
            {
                SavePos.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Resize note
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlResizeWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.SizeNWSE;
        }

        /// <summary>
        /// hyperlink clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rtbNote_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            xmlHandler getSettings = new xmlHandler(true);
            if (getSettings.getXMLnodeAsBool("askurl"))
            {
                DialogResult result = MessageBox.Show(this, "Are you sure you want to visted: " + e.LinkText, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(e.LinkText);
                }
            }
            else
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
        }

        /// <summary>
        /// Thread to save note settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavePos_DoWork(object sender, DoWorkEventArgs e)
        {
                this.locX = this.Location.X;
                this.locY = this.Location.Y;

                if (!this.rolledup)
                {
                    this.noteWidth = Convert.ToUInt16(this.Width);
                    this.noteHeight = Convert.ToUInt16(this.Height);
                }

                if ((this.locX + this.Width > minvisiblesize) && (this.locY + this.Height > minvisiblesize) && (notecolor >= 0) && notecolor <= skin.MaxNotesColors)
                {
                    string notefile = System.IO.Path.Combine(notes.NoteSavePath, this.id + ".xml");
                    xmlHandler updateposnote = new xmlHandler(notefile);
                    updateposnote.WriteNote(this.Visible, this.TopMost, notecolor, this.title, this.note, this.locX, this.locY, this.noteWidth, this.noteHeight);
                    
                }
                else if (notecolor < 0 || notecolor > skin.MaxNotesColors)
                {
                    throw new CustomException("Note color unknow.");
                }
                else
                {
                    String msgOutOfScreen = "Position note (ID:" + this.NoteID + ") is out of screen.";
                    Log.Write(LogType.error, msgOutOfScreen);
                    MessageBox.Show(msgOutOfScreen);
                }
            
        }

        /// <summary>
        /// Set the color of the note.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setColorNote(object sender, EventArgs e)
        {
            Int16 i = 0;
            foreach (ToolStripMenuItem curitem in menuNoteColors.DropDownItems)
            {
                if (curitem == sender)
                {
                    curitem.Checked = true;
                    notecolor = i;
                    string notefile = System.IO.Path.Combine(notes.NoteSavePath, this.id + ".xml");
                    xmlHandler savenotecolor = new xmlHandler(notefile);
                    savenotecolor.WriteNote(this.NoteVisible, menuOnTop.Checked, notecolor, this.title, this.note, this.locX, this.locY, this.Width, this.Height);
                    Log.Write(LogType.info, "Color note (ID:" + this.NoteID + ") changed.");
                }
                else
                {
                    curitem.Checked = false;
                }
                i++;
            }

            PaintColorNote();
        }

        /// <summary>
        /// Set the position of frmNote
        /// </summary>
        private void SetPosNote()
        {
            this.Location = new Point(locX, locY);
        }

        /// <summary>
        /// Set the size of frmNote
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void SetSizeNote(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Send note to Facebook.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmenuSendToFacebook_Click(object sender, EventArgs e)
        {
            if (!checkConnection()) return;
            Facebook fb = new Facebook();
            fb.StartPostingNote(note);
        }

        /// <summary>
        /// Save the note to a plain textfile.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmenuSendToTextfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.DefaultExt = "txt";
            sfdlg.AddExtension = true;
            sfdlg.ValidateNames = true;
            sfdlg.CheckPathExists = true;
            sfdlg.OverwritePrompt = true;
            if (title.Length > 100)
            {
                sfdlg.FileName = title.Substring(0, 100);
            }
            else
            {
                sfdlg.FileName = title;
            }
            sfdlg.Title = "Save note to textfile";
            sfdlg.Filter = "Textfile (*.txt)|*.txt|Webpage (*.htm)|*.htm";
            if (sfdlg.ShowDialog() == DialogResult.OK)
            {
                new Textfile(true, sfdlg.FileName, this.title, this.note);
                Log.Write(LogType.info, "Note (ID:" + this.NoteID + ") saved to textfile.");
            }
            
        }

        /// <summary>
        /// Request to tweet note. Check if allow, if so call tweetnote() methode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmenuSendToTwitter_Click(object sender, EventArgs e)
        {
            if (!checkConnection()) return;

            if ((String.IsNullOrEmpty(note) == false) && (note.Length < 140))
            {
                tweetnote();
                Log.Write(LogType.info, "Note send to twitter.");
            }
            else if (note.Length > 140)
            {
                DialogResult result;
                string shrttweet = note.Substring(0, 140);
                result = MessageBox.Show("Your note is more than the 140 chars. Do you want to publish only the first 140 characters? ", "too long note", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tweetnote();
                    Log.Write(LogType.info, "Shorted note send to twitter.");
                }
            }
            else
            {
                String emptynote = "Note is empty.";
                MessageBox.Show(emptynote);
                Log.Write(LogType.error, emptynote);
            }
        }

        /// <summary>
        /// Tweet a note.
        /// </summary>
        private void tweetnote()
        {
            if (!checkConnection()) return;

            xmlHandler getSettings = new xmlHandler(true);
            string twitteruser = getSettings.getXMLnode("twitteruser");
            string twitterpass = getSettings.getXMLnode("twitterpass");
            if (!String.IsNullOrEmpty(twpass))
            {
                twitterpass = twpass;
            }

            if (String.IsNullOrEmpty(twitteruser))
            {
                string notwusername = "You haven't set your twitter username yet.\r\nSettings window will now open.";
                MessageBox.Show(notwusername);
                Log.Write(LogType.error, notwusername);
                FrmSettings settings = new FrmSettings(notes);
                settings.Show();
                return;
            }
            else if (String.IsNullOrEmpty(twpass))
            {
                Form askpass = new Form();
                askpass.ShowIcon = false;
                askpass.Height = 80;
                askpass.Width = 280;
                askpass.Text = "Twitter password needed";
                askpass.Show();
                TextBox tbpass = new TextBox();
                tbpass.Location = new Point(10, 10);
                tbpass.Width = 160;
                tbpass.Name = "tbPassword";
                tbpass.PasswordChar = 'X'; ;
                Button btnOk = new Button();
                btnOk.Location = new Point(180, 10);
                btnOk.Text = "Ok";
                btnOk.Width = 80;
                btnOk.Name = "btnOk";
                btnOk.Click += askpassok;
                askpass.Controls.Add(tbpass);
                askpass.Controls.Add(btnOk);
            }
            else
            {
                Twitter twitter = new Twitter();
                if (twitter.UpdateAsXML(twitteruser, twitterpass, note) != null)
                {
                    MessageBox.Show("Your note is Tweeted.");
                }
                else
                {
                    String sendtwfail = "Sending note to twitter failed.";
                    MessageBox.Show(sendtwfail);
                    Log.Write(LogType.error, sendtwfail);
                }
                twpass.Remove(0);
            }
        }

        /// <summary>
        /// Change check in menu colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateMenuNoteColor(object sender, EventArgs e)
        {
            foreach (ToolStripMenuItem curitem in menuNoteColors.DropDownItems)
            {
                curitem.Checked = false;
            }

            switch (this.notecolor)
            {
                case 0:
                    yellowToolStripMenuItem.Checked = true;
                    break;
                case 1:
                    orangeToolStripMenuItem.Checked = true;
                    break;
                case 2:
                    whiteToolStripMenuItem.Checked = true;
                    break;
                case 3:
                    greenToolStripMenuItem.Checked = true;
                    break;
                case 4:
                    blueToolStripMenuItem.Checked = true;
                    break;
                case 5:
                    purpleToolStripMenuItem.Checked = true;
                    break;
                case 6:
                    redToolStripMenuItem.Checked = true;
                    break;
            }
        }

		#endregion Methods 

#if win32
        /// <summary>
        /// Check internet state.
        /// </summary>
        /// <returns></returns>
        private static bool IsConnectedToInternet()
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int msg, int wParam, int lParam);
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
#endif
    }
}