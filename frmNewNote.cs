﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimplePlainNote
{
    public partial class frmNewNote : Form    
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private List<frmNote> notes;       

        public frmNewNote()
        {
            InitializeComponent();
            notes = new List<frmNote>();            
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if (tbTitle.Text == "")
            {
                tbTitle.BackColor = Color.Red;                
                tbTitle.Text = DateTime.Now.ToString();                
            }
            else if (rtbNote.Text == "")
            {
                rtbNote.BackColor = Color.Red;
                Console.Beep();
                rtbNote.Text = "Please type any note.";
            }
            else
            {
                CreateNote(tbTitle.Text, rtbNote.Text);                
                CancelNote();
            }

        }



        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Focused)
            {
                tbTitle.BackColor = Color.LightYellow;
                rtbNote.BackColor = Color.Gold;
            }
        }

        private void rtbNote_Enter(object sender, EventArgs e)
        {
            if (rtbNote.Focused)
            {
                rtbNote.BackColor = Color.LightYellow;
                tbTitle.BackColor = Color.Gold;                
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            tbTitle.BackColor = Color.Gold;
        }

        private void Trayicon_Click(object sender, EventArgs e)
        {
            //todo
        }

        private void createANewNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Trayicon.Dispose();
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelNote();
        }

        private void CancelNote()
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            tbTitle.Text = "";
            rtbNote.Text = "";
        }

        public void CreateNote(string title, string text)
        {
            try
            {
                int newid = notes.Count + 1;
                frmNote frmNote = new frmNote(newid, title, text, this);
                notes.Add(frmNote);
                frmNote.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: creating note. \r\n"+exc.Message);
            }
        }

        public void DeleteNote(int id)
        {
            int m = 0;
            for (int i = 0; i < notes.Count; i++)
            {
                if (id == notes[i].ID)
                {
                    notes.RemoveAt(i);
                    m = i;
                    break;
                }
            }
            /*
            for (int n=m+1; n <= notes.Count; n++)
            {
                notes[n].ID = n - 1;
            }
             */
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string allnotes ="";
            for (int i = 0; i < notes.Count; i++)
            {
                allnotes += notes[i].ID + " - " + notes[i].Title + " \r\n";
            }
            allnotes += "---------------------\r\nNumber notes: " + notes.Count;
            MessageBox.Show(allnotes);
        }

        private void tbTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rtbNote.Focus();
            }
        }

        private void pnlHeadNewNote_MouseDown(object sender, MouseEventArgs e)
        {
            pnlHeadNewNote.BackColor = Color.Orange;
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                pnlHeadNewNote.BackColor = Color.Gold;
            }
        }
    }
}
