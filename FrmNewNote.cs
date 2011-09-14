//-----------------------------------------------------------------------
// <copyright file="FrmNewNote.cs" company="GNU">
//  NoteFly a note application.
//  Copyright (C) 2010-2011  Tom
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
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// New and edit note window.
    /// </summary>
    public partial class FrmNewNote : Form
    {
        #region Fields (4)

        /// <summary>
        /// Margin between format buttons and content.
        /// </summary>
        private const int MARGIN = 5;

        /// <summary>
        /// Indicated if the form is being moved.
        /// </summary>
        private bool moving = false;

        /// <summary>
        /// Reference to a new or editing note,
        /// </summary>
        private Note note;

        /// <summary>
        /// Pointer to the notes class.
        /// </summary>
        private Notes notes;

        /// <summary>
        /// The old position of the mouse while resizing.
        /// </summary>
        private Point oldp;

        #endregion Fields

        #region Constructors (2)

        /// <summary>
        /// Initializes a new instance of the FrmNewNote class for editing a exist note.
        /// </summary>
        /// <param name="notes">The class with access to all notes.</param>
        /// <param name="note">the note to edit.</param>
        /// <param name="locfrmnewnote">The location of the FrmNewNote should get.</param>
        /// <param name="sizefrmnewnote">The size of the FrnNewNote should get.</param>
        /// <param name="wordwrap">Wrap words that exceeded the width of the richedittext control.</param>
        public FrmNewNote(Notes notes, Note note, Point locfrmnewnote, Size sizefrmnewnote, bool wordwrap)
        {
            this.ConstructFrmNewNote(notes);
            this.Location = locfrmnewnote;
            this.Size = sizefrmnewnote;
            this.rtbNewNote.WordWrap = wordwrap;
            this.menuWordWarp.Checked = wordwrap;
            this.note = note;
            this.Text = "edit note";
            this.SetColorsForm(this.note.SkinNr);
            this.tbTitle.Text = note.Title;
            if (string.IsNullOrEmpty(this.note.Tempcontent))
            {
                this.rtbNewNote.Rtf = note.GetContent();
            }
            else
            {
                this.rtbNewNote.Rtf = this.note.Tempcontent;

                // clear memory:
                this.note.Tempcontent = string.Empty;
                this.note.Tempcontent = null;
            }
        }

        /// <summary>
        /// Initializes a new instance of the FrmNewNote class for a new note.
        /// </summary>
        /// <param name="notes">The class with access to all notes.</param>
        public FrmNewNote(Notes notes)
        {
            this.ConstructFrmNewNote(notes);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width / 2) - (this.Width / 2), (Screen.PrimaryScreen.WorkingArea.Height / 2) - (this.Height / 2));
            this.note = null;
            this.Text = "new note";
            if (Settings.NotesDefaultRandomSkin)
            {
                Settings.NotesDefaultSkinnr = notes.GenerateRandomSkinnr();
            }

            this.SetColorsForm(Settings.NotesDefaultSkinnr);
            this.tbTitle.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        #endregion Constructors

        #region Methods (30)

        /// <summary>
        /// Initialize components FrmNewNote, set font, tooltip and richtextbox settings
        /// </summary>
        /// <param name="notes">Reference to notes class.</param>
        private void ConstructFrmNewNote(Notes notes)
        {
            this.InitializeComponent();
            this.notes = notes;
            this.SetFontSettings();
            this.toolTip.Active = Settings.NotesTooltipsEnabled;
            this.rtbNewNote.DetectUrls = Settings.HighlightHyperlinks;
            this.tbTitle.Select();
        }

        /// <summary>
        /// Set all the form colors by the skinnr.
        /// </summary>
        /// <param name="skinnr">Skin number</param>
        private void SetColorsForm(int skinnr)
        {
            this.BackColor = this.notes.GetPrimaryClr(skinnr);
            this.pnlHeadNewNote.BackColor = this.notes.GetPrimaryClr(skinnr);
            this.lbTextTitle.ForeColor = this.notes.GetTextClr(skinnr);
            this.tbTitle.ForeColor = this.notes.GetTextClr(skinnr);
            this.rtbNewNote.ForeColor = this.notes.GetTextClr(skinnr);
            this.tbTitle.BackColor = this.notes.GetHighlightClr(skinnr);
            this.rtbNewNote.BackColor = this.notes.GetSelectClr(skinnr); //this.notes.GetPrimaryClr(skinnr);

            this.btnTextBold.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnTextItalic.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnTextStriketrough.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnTextUnderline.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnTextBulletlist.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnFontBigger.ForeColor = this.notes.GetTextClr(skinnr);
            this.btnFontSmaller.ForeColor = this.notes.GetTextClr(skinnr);

            this.btnTextBold.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnTextItalic.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnTextStriketrough.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnTextUnderline.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnTextBulletlist.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnFontBigger.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);
            this.btnFontSmaller.FlatAppearance.MouseOverBackColor = this.notes.GetSelectClr(skinnr);

            if (this.notes.GetPrimaryTexture(skinnr) != null)
            {
                this.BackgroundImage = this.notes.GetPrimaryTexture(skinnr);
                this.pnlHeadNewNote.BackColor = Color.Transparent;
                this.lbTextTitle.BackColor = Color.Transparent;
                this.lbTextTitle.BackColor = Color.Transparent;
                ////this.btnAddNote.BackColor = Color.Transparent;
                ////this.btnCancel.BackColor = Color.Transparent;
            }
        }

        /// <summary>
        /// User pressed the accept note button. Note will now be saved.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbTitle.Text))
            {
                this.tbTitle.Text = DateTime.Now.ToString();
            }
            else if (string.IsNullOrEmpty(this.rtbNewNote.Text))
            {
                this.rtbNewNote.Text = "Please enter some content.";
                this.rtbNewNote.Focus();
                this.rtbNewNote.SelectAll();
            }
            else
            {
                bool newnote = false;
                if (this.note == null)
                {
                    newnote = true;
                    this.note = this.notes.CreateNote(this.tbTitle.Text, Settings.NotesDefaultSkinnr, this.Location.X, this.Location.Y, this.Width, this.Height);
                }

                this.note.Title = this.tbTitle.Text;
                this.note.Visible = true;
                if (string.IsNullOrEmpty(this.note.Filename))
                {
                    this.note.Filename = this.notes.GetNoteFilename(this.note.Title);
                }

                if (xmlUtil.WriteNote(this.note, this.notes.GetSkinName(this.note.SkinNr), this.rtbNewNote.Rtf))
                {
                    if (newnote)
                    {
                        this.notes.AddNote(this.note);
                    }

                    if (Program.plugins != null && Settings.ProgramPluginsAllEnabled)
                    {
                        for (int i = 0; i < Program.plugins.Length; i++)
                        {
                            if (Program.plugins[i].Enabled)
                            {
                                Program.plugins[i].SavingNote(this.rtbNewNote.Rtf, this.note.Title);
                            }
                        }
                    }

                    TrayIcon.Frmneweditnoteopen = false;
                    this.note.Tempcontent = this.rtbNewNote.Rtf;
                    this.note.CreateForm(this.rtbNewNote.WordWrap);
                    if (this.note.Tempcontent != null)
                    {
                        this.note.Tempcontent = null;
                    }

                    SyntaxHighlight.DeinitHighlighter();
                    this.notes.FrmManageNotesNeedUpdate = true;
                    TrayIcon.RefreshFrmManageNotes();
                    this.Close();
                    GC.Collect();
                }
                else
                {
                    throw new ApplicationException("Could not write note");
                }
            }
        }

        /// <summary>
        /// User pressed the cancel button, all things typed in FrmNewNote window will be lost.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TrayIcon.Frmneweditnoteopen = false;
            if (this.note != null)
            {
                this.note.CreateForm(this.rtbNewNote.WordWrap);
            }

            this.Close();
        }

        /// <summary>
        /// Make note content text bold, or if the selected text is already bold
        /// then remove the bold style.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnTextBold_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                if (this.rtbNewNote.SelectionFont.Bold)
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, this.removestyle(this.rtbNewNote.SelectionFont.Style, FontStyle.Bold));
                }
                else
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, (this.rtbNewNote.SelectionFont.Style | System.Drawing.FontStyle.Bold));
                }
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Italic text
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnTextItalic_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                if (this.rtbNewNote.SelectionFont.Italic)
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, this.removestyle(this.rtbNewNote.SelectionFont.Style, FontStyle.Italic));
                }
                else
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, (this.rtbNewNote.SelectionFont.Style | System.Drawing.FontStyle.Italic));
                }
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Striketrough text
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnTextStriketrough_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                if (this.rtbNewNote.SelectionFont.Strikeout)
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, this.removestyle(this.rtbNewNote.SelectionFont.Style, FontStyle.Strikeout));
                }
                else
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, (this.rtbNewNote.SelectionFont.Style | System.Drawing.FontStyle.Strikeout));
                }
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Underline text
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnTextUnderline_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                if (this.rtbNewNote.SelectionFont.Underline)
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, this.removestyle(this.rtbNewNote.SelectionFont.Style, FontStyle.Underline));
                }
                else
                {
                    this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, this.rtbNewNote.SelectionFont.SizeInPoints, (this.rtbNewNote.SelectionFont.Style | System.Drawing.FontStyle.Underline));
                }
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Make text bigger.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnFontBigger_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                this.ChangeFontSizeSelected(this.rtbNewNote.SelectionFont.SizeInPoints + 1);
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Make text smaller.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnFontSmaller_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                this.ChangeFontSizeSelected(this.rtbNewNote.SelectionFont.SizeInPoints - 1);
            }

            this.rtbNewNote.Focus();
        }

        /// <summary>
        /// Change the fontsize of the selected text limited from 6pt to 108pt.
        /// </summary>
        /// <param name="newsize">Event arguments</param>
        private void ChangeFontSizeSelected(float newsize)
        {
            if ((newsize < 6) || (newsize > 108))
            {
                return;
            }
            else
            {
                this.rtbNewNote.SelectionFont = new System.Drawing.Font(this.rtbNewNote.SelectionFont.FontFamily, newsize, this.rtbNewNote.SelectionFont.Style);
            }
        }

        /// <summary>
        /// Check if selection length of rtbNote is larger than zero.
        /// </summary>
        /// <returns>true if length is larger than 0.</returns>
        private bool checksellen()
        {
            if (this.rtbNewNote.SelectedText.Length > 0)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Avoid that if there is no content the user select to copy the content.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void contextMenuStripTextActions_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.rtbNewNote.TextLength == 0)
            {
                this.menuCopyContent.Enabled = false;
            }
            else
            {
                this.menuCopyContent.Enabled = true;
            }
        }

        /// <summary>
        /// Copy the note content.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void copyTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.rtbNewNote.Text))
            {
                Log.Write(LogType.error, "No content to copy.");
            }
            else
            {
                Clipboard.SetText(this.rtbNewNote.Text);
            }
        }

        /// <summary>
        /// Check whether pastTextToolStripMenuItem should be enabled.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void copyTextToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                this.menuPasteToContent.Enabled = true;
            }
            else
            {
                this.menuPasteToContent.Enabled = false;
            }
        }

        /// <summary>
        /// Form got focus, remove transparency.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void frmNewNote_Activated(object sender, EventArgs e)
        {
            if (Settings.NotesTransparencyEnabled)
            {
                this.Opacity = 1.0;
            }
        }

        /// <summary>
        /// Form lost focus, make transparent.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void frmNewNote_Deactivate(object sender, EventArgs e)
        {
            if (Settings.NotesTransparencyEnabled)
            {
                this.Opacity = Settings.NotesTransparencyLevel;
                this.Refresh();
            }
        }

        /// <summary>
        /// Import a file as note.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlgresopennote = openNoteFileDialog.ShowDialog();
            if (dlgresopennote == DialogResult.OK)
            {
                StreamReader reader = null;
                try
                {
                    if (File.Exists(openNoteFileDialog.FileName))
                    {
                        reader = new StreamReader(openNoteFileDialog.FileName, true); // detect encoding
                        switch (openNoteFileDialog.FilterIndex)
                        {
                            case 1:
                                this.ReadTextfile(reader);
                                break;
                            case 2:
                                this.ReadRTFfile(reader);
                                break;
                            case 3:
                                this.ReadKeyNotefile(reader);
                                break;
                            case 4:
                                this.ReadTomboyfile(reader, openNoteFileDialog.FileName);
                                break;
                            case 5:
                                this.ReadMicroSENotefile(reader);
                                break;
                        }

                    }
                }
                finally
                {
                    reader.Close();
                }
            }
        }

        /// <summary>
        /// Import a textfile as note content for a new note.
        /// </summary>
        /// <param name="reader"></param>
        private void ReadTextfile(StreamReader reader)
        {
            this.rtbNewNote.Text = reader.ReadToEnd();
        }

        /// <summary>
        /// Import a rtf file as note content for a new note.
        /// </summary>
        /// <param name="reader"></param>
        private void ReadRTFfile(StreamReader reader)
        {
            this.rtbNewNote.Rtf = reader.ReadToEnd();
            this.SetDefaultFontFamilyAndSize();
        }

        /// <summary>
        /// Import a KeyNote note file as note content for a new note.
        /// </summary>
        /// <param name="reader"></param>
        private void ReadKeyNotefile(StreamReader reader)
        {
            uint linenum = 0;
            string curline = reader.ReadLine(); // no CR+LF characters
            const string IMPORTERROR = "import error";
            if (curline == "#!GFKNT 2.0")
            {
                while (curline != "%:")
                {
                    curline = reader.ReadLine();
                    linenum++;

                    // should normally be except %: around line 42.
                    if (linenum > 50)
                    {
                        const string CANNOTFINDKEYNOTECONTENT = "Cannot find KeyNote NF note content.";
                        MessageBox.Show(CANNOTFINDKEYNOTECONTENT, IMPORTERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Log.Write(LogType.error, CANNOTFINDKEYNOTECONTENT);
                    }
                }

                curline = reader.ReadLine();
                StringBuilder sb = new StringBuilder(curline);
                while (curline != "%%")
                {
                    curline = reader.ReadLine();
                    sb.Append(curline);
                    linenum++;

                    // limit to 16000 lines
                    if (linenum > 16000)
                    {
                        break;
                    }
                }

                this.rtbNewNote.Rtf = sb.ToString();
                this.SetDefaultFontFamilyAndSize();
            }
            else
            {
                const string NOTKEYNOTEFILE = "Not a KeyNote NF note.";
                MessageBox.Show(NOTKEYNOTEFILE, IMPORTERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Write(LogType.error, NOTKEYNOTEFILE);
            }
        }

        /// <summary>
        ///  Import a Tomboy note file as note content for a new note.
        ///  And set the new note title.
        /// </summary>
        /// <param name="reader"></param>
        private void ReadTomboyfile(StreamReader reader, string tomboynotefile)
        {
            this.tbTitle.Text = xmlUtil.GetContentString(tomboynotefile, "title");
            // TomBoy uses nodes within the note-content node so we use StreamReader to do node xml parsering.
            const string startnotecontent = "<note-content version=\"0.1\">";
            const string endnotecontent = "</note-content>";
            long posdocument = 0;
            long posstartcontent = 0;
            long posendcontent = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.Contains(startnotecontent))
                {
                    posstartcontent = posdocument + line.IndexOf(startnotecontent) + startnotecontent.Length + 3; // +3 for ?
                }
                else if (line.Contains(endnotecontent))
                {
                    posendcontent = posdocument + line.IndexOf(endnotecontent) + 3; // +3 for ?
                }

                posdocument += line.Length + 1; // +1 for EoL
            }

            reader.BaseStream.Position = posstartcontent;
            StringBuilder sbcontent = new StringBuilder();
            int lenbuf = Convert.ToInt32(posendcontent - posstartcontent);
            char[] buf = new char[lenbuf + 1]; // FIXME no fixed buffers used, memory bloat
            reader.BaseStream.Position = posstartcontent;
            if (lenbuf < buf.Length)
            {
                int retval = reader.ReadBlock(buf, 0, lenbuf);
                this.rtbNewNote.Clear();
                for (int i = 0; i < buf.Length; i++)
                {
                    this.rtbNewNote.Text += buf[i];
                }
            } 
        }

        /// <summary>
        /// Import a MicroSE note file as note content for a new note.
        /// </summary>
        /// <param name="reader"></param>
        private void ReadMicroSENotefile(StreamReader reader)
        {
            bool contentstarted = false;
            StringBuilder sbcontent = new StringBuilder();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line.StartsWith("title;"))
                {
                    int possep = line.LastIndexOf(';') + 1; // without ';' itself
                    string title = line.Substring(possep, line.Length - possep);
                    this.tbTitle.Text = title;
                }

                if (line.StartsWith(@"{\rtf1") || contentstarted)
                {                    
                    sbcontent.AppendLine(line);
                    if (line.Equals("}"))
                    {
                        this.rtbNewNote.Rtf = sbcontent.ToString();
                        contentstarted = false;
                    }
                    else
                    {
                        contentstarted = true;
                    }
                }
            }
        }

        /// <summary>
        /// Set this note ontop, CheckOnClick is set to true.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void menuStickyOnTop_Click(object sender, EventArgs e)
        {
            this.TopMost = this.menuStickyOnTop.Checked;
        }

        /// <summary>
        /// Pasting text as note content.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void pastTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                this.rtbNewNote.Text = this.rtbNewNote.Text + Clipboard.GetText();
            }
            else
            {
                const string EMPTYCLIPBOARD = "There is no text on the clipboard.";
                MessageBox.Show(EMPTYCLIPBOARD);
                Log.Write(LogType.error, EMPTYCLIPBOARD);
            }
        }

        /// <summary>
        /// Resizing the FtmNewNote form.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Mouse event arguments</param>
        private void pbResizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeNWSE;
                this.Size = new Size(this.PointToClient(MousePosition).X, this.PointToClient(MousePosition).Y);
            }

            this.Cursor = Cursors.Default;
        }

        /// <summary>
        /// Moving the note.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Mouse event arguments</param>
        private void pnlHeadNewNote_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.moving = true;
                this.oldp = e.Location;
                if (this.note != null)
                {
                    this.pnlHeadNewNote.BackColor = this.notes.GetSelectClr(this.note.SkinNr);
                }
                else
                {
                    this.pnlHeadNewNote.BackColor = this.notes.GetSelectClr(Settings.NotesDefaultSkinnr);
                }
            }
        }

        /// <summary>
        /// Move note if pnlHead is being left clicked.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Mouse event arguments</param>
        private void pnlHeadNewNote_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.moving && e.Button == MouseButtons.Left)
            {
                if (this.note != null)
                {
                    this.pnlHeadNewNote.BackColor = this.notes.GetSelectClr(this.note.SkinNr);
                }
                else
                {
                    this.pnlHeadNewNote.BackColor = this.notes.GetSelectClr(Settings.NotesDefaultSkinnr);
                }

                int dpx = e.Location.X - this.oldp.X;
                int dpy = e.Location.Y - this.oldp.Y;
#if linux
                if (dpx > 8)
                {
                    dpx = 8;
                }
                else if (dpx < -8)
                {
                    dpx = -8;
                }

                if (dpy > 8)
                {
                    dpy = 8;
                }
                else if (dpy < -8)
                {
                    dpy = -8;
                }

#endif
                this.Location = new Point(this.Location.X + dpx, this.Location.Y + dpy);
            }
        }

        /// <summary>
        /// End moving note.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void pnlHeadNewNote_MouseUp(object sender, MouseEventArgs e)
        {
            this.moving = false;
            if (this.note != null)
            {
                this.pnlHeadNewNote.BackColor = this.notes.GetPrimaryClr(this.note.SkinNr);
                if (this.BackgroundImage != null)
                {
                    this.pnlHeadNewNote.BackColor = Color.Transparent;
                }
            }
            else
            {
                this.pnlHeadNewNote.BackColor = this.notes.GetPrimaryClr(Settings.NotesDefaultSkinnr);
            }
        }

        /// <summary>
        /// Removes 1 fontsyle from the fontsyles of the checkstyle rtb text.
        /// This methode does not check if selection lenght is okay.
        /// </summary>
        /// <param name="checkstyles">The FontStyle apply operations on.</param>
        /// <param name="removestyle">The FontStyle to remove.</param>
        /// <returns>The new fontstyle</returns>
        private FontStyle removestyle(FontStyle checkstyles, FontStyle removestyle)
        {
            FontStyle newstyles = checkstyles;
            newstyles -= removestyle;
            return newstyles;
        }

        /// <summary>
        /// User entered the note content box.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void rtbNote_Enter(object sender, EventArgs e)
        {
            if (this.note != null)
            {
                this.rtbNewNote.BackColor = this.notes.GetHighlightClr(this.note.SkinNr);
            }
            else
            {
                this.rtbNewNote.BackColor = this.notes.GetHighlightClr(Settings.NotesDefaultSkinnr);
            }

            this.SetToolbarEnabled(true);
        }

        /// <summary>
        /// User leaved the note content box.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void rtbNote_Leave(object sender, EventArgs e)
        {
            if (this.note != null)
            {
                this.rtbNewNote.BackColor = this.notes.GetSelectClr(this.note.SkinNr);
            }
            else
            {
                this.rtbNewNote.BackColor = this.notes.GetSelectClr(Settings.NotesDefaultSkinnr);
            }
        }

        /// <summary>
        /// A hyperlink is clicked, check settings to see if confirm launch dialog have
        /// to be showed, if not then directly launch the URL.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void rtbNote_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Program.LoadLink(e.LinkText, true);
        }

        /// <summary>
        /// Force context menu to show up.
        /// </summary>
        /// <param name="sender">sender object</param>
        /// <param name="e">Event arguments</param>
        private void rtbNote_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStripTextActions.Show(this.Location.X + e.X, this.Location.X + e.Y);
            }
        }

        /// <summary>
        /// Set font family and size.
        /// </summary>
        private void SetDefaultFontFamilyAndSize()
        {
            this.rtbNewNote.SelectAll();
            this.rtbNewNote.Font = new Font(Settings.FontContentFamily, (float)Settings.FontContentSize);
            this.rtbNewNote.Select(0, 0);
        }

        /// <summary>
        /// Set the font and textdirection FrmNewNote.
        /// </summary>
        private void SetFontSettings()
        {
            this.tbTitle.Font = new Font(Settings.FontTitleFamily, 11);
            this.rtbNewNote.Font = new Font(Settings.FontContentFamily, this.rtbNewNote.Font.Size);
            switch (Settings.FontTextdirection)
            {
                case 0:
                    this.tbTitle.RightToLeft = RightToLeft.No;
                    this.rtbNewNote.RightToLeft = RightToLeft.No;
                    break;
                case 1:
                    this.tbTitle.RightToLeft = RightToLeft.Yes;
                    this.rtbNewNote.RightToLeft = RightToLeft.Yes;
                    break;
                default:
                    this.tbTitle.RightToLeft = RightToLeft.No;
                    this.rtbNewNote.RightToLeft = RightToLeft.No;
                    break;
            }

            this.rtbNewNote.Focus();
            this.rtbNewNote.Select();
            this.BringToFront();
        }

        /// <summary>
        /// Toggle toolbar buttons.
        /// </summary>
        /// <param name="enabled">true if toolbar should be enabled.</param>
        private void SetToolbarEnabled(bool enabled)
        {
            this.btnTextBold.Enabled = enabled;
            this.btnTextItalic.Enabled = enabled;
            this.btnTextStriketrough.Enabled = enabled;
            this.btnTextUnderline.Enabled = enabled;
            this.btnTextBulletlist.Enabled = enabled;
            this.btnFontBigger.Enabled = enabled;
            this.btnFontSmaller.Enabled = enabled;
        }

        /// <summary>
        /// User entered the title box.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (this.note != null)
            {
                this.tbTitle.BackColor = this.notes.GetHighlightClr(this.note.SkinNr);
            }
            else
            {
                this.tbTitle.BackColor = this.notes.GetHighlightClr(Settings.NotesDefaultSkinnr);
            }

            this.SetToolbarEnabled(false);
        }

        /// <summary>
        /// User leaved the title box
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (this.note != null)
            {
                this.tbTitle.BackColor = this.notes.GetSelectClr(this.note.SkinNr);
            }
            else
            {
                this.tbTitle.BackColor = this.notes.GetSelectClr(Settings.NotesDefaultSkinnr);
            }

            this.SetToolbarEnabled(true);
        }

        /// <summary>
        /// Handle keyboard shortcuts
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">KeyEvent arguments</param>
        private void FrmNewNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        this.btnTextBold_Click(null, EventArgs.Empty);
                        break;
                    case Keys.I:
                        this.btnTextItalic_Click(null, EventArgs.Empty);
                        break;
                    case Keys.U:
                        this.btnTextUnderline_Click(null, EventArgs.Empty);
                        break;
                    case Keys.T:
                        this.btnTextStriketrough_Click(null, EventArgs.Empty);
                        break;
                }
            }
        }

        /// <summary>
        /// Make buttet item of current selected line(s).
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void btnTextBulletlist_Click(object sender, EventArgs e)
        {
            if (this.checksellen())
            {
                this.rtbNewNote.SelectionBullet = !this.rtbNewNote.SelectionBullet;
            }
        }

        /// <summary>
        /// Show or hide buttons for formatting.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void menuShowtoolbar_Click(object sender, EventArgs e)
        {
            this.menuShowtoolbar.Checked = !this.menuShowtoolbar.Checked;
            if (this.menuShowtoolbar.Checked)
            {
                this.rtbNewNote.Height = this.Height - this.rtbNewNote.Location.Y - (this.Height - this.tableLayoutPanelFormatbtn.Location.Y + MARGIN);
            }
            else
            {
                this.rtbNewNote.Height = this.Height - this.rtbNewNote.Location.Y - (this.Height - (this.tableLayoutPanelFormatbtn.Location.Y + this.tableLayoutPanelFormatbtn.Height));
            }

            this.SetToolbarEnabled(this.menuShowtoolbar.Checked);
        }

        /// <summary>
        /// Toggle to wrap lines in the richedit control
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void menuWordWarp_Click(object sender, EventArgs e)
        {
            this.rtbNewNote.WordWrap = this.menuWordWarp.Checked;
        }

        /// <summary>
        /// Do a quick text highlight.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNote_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                // todo Do a quick highlight of change. Every space creates a new keyword to highlight.
            }
        }

        #endregion Methods
    }
}
