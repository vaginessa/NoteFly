﻿/* Copyright (C) 2009
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
#define win32

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using System.IO;
using System.Xml;

namespace SimplePlainNote
{
    /// <summary>
    /// Class to create new note.
    /// </summary>
    public partial class frmNewNote : Form
    {
        #region Fields (5)
        
        private Notes notes;
        private int notecolor;
        private int editnoteid = 0;
        private bool transparency = false;
        private bool editnote = false;
        #if win32
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        #endif
        
        #endregion Fields

        #region Constructors (1)
      
        public frmNewNote(Notes notes, bool transparency)
        {
            InitializeComponent();
            this.editnote = false;
            this.notes = notes;
            this.transparency = transparency;      
        }

        public frmNewNote(Notes notes, bool transparency, int editnoteid, string editnotetitle, string editnotecontent, int editnotecolor)
        {
            InitializeComponent();
            this.editnote = true;
            this.editnoteid = editnoteid;
            this.notes = notes;
            this.transparency = transparency;
            this.tbTitle.Text = editnotetitle;
            this.rtbNote.Text = editnotecontent;
            this.notecolor = editnotecolor;
        }

        #endregion Constructors

        #region Methods (24)

        // Public Methods (2) 

        #if win32
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        #endif
        // Private Methods (19) 

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            skin Skin = getSkin();
            if (tbTitle.Text == "")
            {
                tbTitle.BackColor = Skin.getObjColor(false, false, true);
                tbTitle.Text = DateTime.Now.ToString();
            }
            else if (rtbNote.Text == "")
            {
                rtbNote.BackColor = Skin.getObjColor(false, false, true);
                rtbNote.Text = "Please type any text.";
            }
            else
            {
                if (editnote)
                {
                    notes.UpdateNote(editnoteid, this.tbTitle.Text, this.rtbNote.Text, true);
                }
                else
                {
                    xmlHandler getSettings = new xmlHandler(true);
                    int notecolordefault = getSettings.getXMLnodeAsInt("defaultcolor");
                    //new note
                    notes.CreateNewNote(tbTitle.Text, rtbNote.Text, notecolordefault);                 
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Redraw reset FrmNewNote.
        /// </summary>
        private void ResetNewNoteForm()
        {
            tbTitle.Text = "";
            rtbNote.Text = "";

            skin Skin = getSkin();
            Color normalcolor = Skin.getObjColor(false);

            pnlNoteEdit.BackColor = normalcolor;
            rtbNote.BackColor = normalcolor;
            pnlHeadNewNote.BackColor = normalcolor;

            pnlNoteEdit.Refresh();
            rtbNote.Refresh();
            pnlHeadNewNote.Refresh();

            tbTitle.BackColor = Skin.getObjColor(true);
            tbTitle.Focus();
        }


        private void frmNewNote_Activated(object sender, EventArgs e)
        {
            if (transparency)
            {
                this.Opacity = 1.0;
                this.Refresh();
            }
        }

        private void frmNewNote_Deactivate(object sender, EventArgs e)
        {
            if (transparency)
            {
                this.Opacity = 0.9;
                this.Refresh();
            }
        }

        private skin getSkin()
        {
            int numcolor = 0;
            xmlHandler getSettings = new xmlHandler(true);            
            numcolor = getSettings.getXMLnodeAsInt("defaultcolor");
            skin getSkin = new skin(numcolor);
            return getSkin;
        }

        private void pbResizeGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Cursor = Cursors.SizeNWSE;
                this.Size = new Size(this.PointToClient(MousePosition).X, this.PointToClient(MousePosition).Y);
            }
            this.Cursor = Cursors.Default;
        }

        private void pnlHeadNewNote_MouseDown(object sender, MouseEventArgs e)
        {
            skin Skin = getSkin();
            pnlHeadNewNote.BackColor = Skin.getObjColor(true);
            #if win32
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                pnlHeadNewNote.BackColor = Skin.getObjColor(false);
            }
            #endif
        }

        private void rtbNote_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to visted: " + e.LinkText, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
        } 

        private void tbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbNote.Focus();
            }
        }

        #region highlight controls
        private void tbTitle_Enter(object sender, EventArgs e)
        {
            skin Skin = getSkin();
            tbTitle.BackColor = Skin.getObjColor(false, true, false);
        }
        private void tbTitle_Leave(object sender, EventArgs e)
        {
            skin Skin = getSkin();
            tbTitle.BackColor = Skin.getObjColor(false);
        }
        private void rtbNote_Enter(object sender, EventArgs e)
        {
            skin Skin = getSkin();
            rtbNote.BackColor = Skin.getObjColor(false, true, false);
        }
        private void rtbNote_Leave(object sender, EventArgs e)
        {
            skin Skin = getSkin();
            rtbNote.BackColor = Skin.getObjColor(false);
        }
        #endregion

        #endregion Methods
    } 
}
