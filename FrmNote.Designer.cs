//-----------------------------------------------------------------------
// <copyright file="FrmNote.Designer.cs" company="NoteFly">
//  NoteFly a note application.
//  Copyright (C) 2010-2015  Tom
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
    /// <summary>
    /// The Note form class
    /// </summary>
    public partial class FrmNote
    {
        /// <summary>
        /// TransparentRichTextBox rtbNote
        /// </summary>
        private TransparentRichTextBox rtbNote;

        /// <summary>
        /// Label lblTitle
        /// </summary>
        private System.Windows.Forms.Label lblNoteTitle;

        /// <summary>
        /// Panel pnlHead
        /// </summary>
        private System.Windows.Forms.Panel pnlHead;

        /// <summary>
        /// Button btnCloseNote
        /// </summary>
        private System.Windows.Forms.Button btnHideNote;

        /// <summary>
        /// Panel pnlNote
        /// </summary>
        private System.Windows.Forms.Panel pnlNote;

        /// <summary>
        /// ContextMenuStrip menuFrmNoteOptions
        /// </summary>
        private System.Windows.Forms.ContextMenuStrip menuFrmNoteOptions;

        /// <summary>
        /// ToolStripMenuItem menuEditNote
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuEditNote;

        /// <summary>
        /// ToolStripMenuItem menuNoteSkins
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuNoteSkins;

        /// <summary>
        /// PictureBox pbResizeGrip
        /// </summary>
        private System.Windows.Forms.PictureBox pbResizeGrip;

        /// <summary>
        /// ToolStripMenuItem menuOnTop
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuOnTop;

        /// <summary>
        /// ToolStripMenuItem menuLockNote
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuLockNote;

        /// <summary>
        /// ToolStripMenuItem menuHideNote
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuHideNote;

        /// <summary>
        /// ToolStripMenuItem menuRollUp
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuRollUp;

        /// <summary>
        /// BackgroundWorker SaveWorker
        /// </summary>
        private System.ComponentModel.BackgroundWorker saveWorker;

        /// <summary>
        /// ToolStripMenuItem menuSendTo
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuActions;

        /// <summary>
        /// ToolStripMenuItem menuSendToEmail
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuSendToEmail;

        /// <summary>
        /// ToolStripMenuItem menuSendToTextfile
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuSendToTextfile;

        /// <summary>
        /// ToolStripMenuItem menuCopy 
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuCopy;

        /// <summary>
        /// ToolStripMenuItem menuCopySelected
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuCopySelected;

        /// <summary>
        /// ToolStripMenuItem menuCopyContent
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuCopyContent;

        /// <summary>
        /// ToolStripMenuItem menuCopyTitle
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuCopyTitle;

        /// <summary>
        /// ToolStripMenuItem menuWordWrap
        /// </summary>
        private System.Windows.Forms.ToolStripMenuItem menuWordWrap;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNoteTitle = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.menuFrmNoteOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuEditNote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNoteSkins = new System.Windows.Forms.ToolStripMenuItem();
            this.menuActions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSendToEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSendToTextfile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLockNote = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyContent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCopyTitle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRollUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHideNote = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHideNote = new System.Windows.Forms.Button();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.pbResizeGrip = new System.Windows.Forms.PictureBox();
            this.saveWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanelHead = new System.Windows.Forms.TableLayoutPanel();
            this.rtbNote = new NoteFly.TransparentRichTextBox();
            this.pnlHead.SuspendLayout();
            this.menuFrmNoteOptions.SuspendLayout();
            this.pnlNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResizeGrip)).BeginInit();
            this.tableLayoutPanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNoteTitle
            // 
            this.lblNoteTitle.AccessibleDescription = "Note title";
            this.lblNoteTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoteTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNoteTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNoteTitle.Location = new System.Drawing.Point(3, 0);
            this.lblNoteTitle.Name = "lblNoteTitle";
            this.lblNoteTitle.Padding = new System.Windows.Forms.Padding(4);
            this.lblNoteTitle.Size = new System.Drawing.Size(193, 31);
            this.lblNoteTitle.TabIndex = 0;
            this.lblNoteTitle.Text = "?";
            this.lblNoteTitle.UseCompatibleTextRendering = true;
            this.lblNoteTitle.DoubleClick += new System.EventHandler(this.pnlHead_DoubleClick);
            this.lblNoteTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            this.lblNoteTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseMove);
            this.lblNoteTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseUp);
            // 
            // pnlHead
            // 
            this.pnlHead.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHead.ContextMenuStrip = this.menuFrmNoteOptions;
            this.pnlHead.Controls.Add(this.tableLayoutPanelHead);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(240, 32);
            this.pnlHead.TabIndex = 1;
            this.pnlHead.DoubleClick += new System.EventHandler(this.pnlHead_DoubleClick);
            this.pnlHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseDown);
            this.pnlHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseMove);
            this.pnlHead.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHead_MouseUp);
            // 
            // menuFrmNoteOptions
            // 
            this.menuFrmNoteOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditNote,
            this.menuNoteSkins,
            this.menuActions,
            this.menuOnTop,
            this.menuLockNote,
            this.menuWordWrap,
            this.menuCopy,
            this.menuRollUp,
            this.menuHideNote});
            this.menuFrmNoteOptions.Name = "contextMenuStripNoteOptions";
            this.menuFrmNoteOptions.Size = new System.Drawing.Size(185, 202);
            this.menuFrmNoteOptions.Text = "-menu-";
            this.menuFrmNoteOptions.Opening += new System.ComponentModel.CancelEventHandler(this.menuFrmNoteOptions_Opening);
            // 
            // menuEditNote
            // 
            this.menuEditNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuEditNote.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuEditNote.Name = "menuEditNote";
            this.menuEditNote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuEditNote.Size = new System.Drawing.Size(184, 22);
            this.menuEditNote.Text = "&Edit note";
            this.menuEditNote.Click += new System.EventHandler(this.menuEditNote_Click);
            // 
            // menuNoteSkins
            // 
            this.menuNoteSkins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuNoteSkins.Name = "menuNoteSkins";
            this.menuNoteSkins.Size = new System.Drawing.Size(184, 22);
            this.menuNoteSkins.Text = "S&kin";
            this.menuNoteSkins.DropDownOpening += new System.EventHandler(this.menuNoteSkins_DropDownOpening);
            // 
            // menuActions
            // 
            this.menuActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSendToEmail,
            this.menuSendToTextfile});
            this.menuActions.Name = "menuActions";
            this.menuActions.Size = new System.Drawing.Size(184, 22);
            this.menuActions.Text = "&Actions";
            this.menuActions.DropDownOpening += new System.EventHandler(this.menuSendTo_DropDownOpening);
            // 
            // menuSendToEmail
            // 
            this.menuSendToEmail.Name = "menuSendToEmail";
            this.menuSendToEmail.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.menuSendToEmail.Size = new System.Drawing.Size(157, 22);
            this.menuSendToEmail.Text = "E-&mail";
            this.menuSendToEmail.Click += new System.EventHandler(this.menuSendToEmail_Click);
            // 
            // menuSendToTextfile
            // 
            this.menuSendToTextfile.Name = "menuSendToTextfile";
            this.menuSendToTextfile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuSendToTextfile.Size = new System.Drawing.Size(157, 22);
            this.menuSendToTextfile.Text = "Save &file";
            this.menuSendToTextfile.Click += new System.EventHandler(this.menuSendToFile_Click);
            // 
            // menuOnTop
            // 
            this.menuOnTop.CheckOnClick = true;
            this.menuOnTop.Name = "menuOnTop";
            this.menuOnTop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.menuOnTop.Size = new System.Drawing.Size(184, 22);
            this.menuOnTop.Text = "Sticky on &top";
            this.menuOnTop.Click += new System.EventHandler(this.menuOnTop_Click);
            // 
            // menuLockNote
            // 
            this.menuLockNote.CheckOnClick = true;
            this.menuLockNote.Name = "menuLockNote";
            this.menuLockNote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuLockNote.Size = new System.Drawing.Size(184, 22);
            this.menuLockNote.Text = "&Lock note";
            this.menuLockNote.Click += new System.EventHandler(this.menuLockNote_Click);
            // 
            // menuWordWrap
            // 
            this.menuWordWrap.CheckOnClick = true;
            this.menuWordWrap.Name = "menuWordWrap";
            this.menuWordWrap.Size = new System.Drawing.Size(184, 22);
            this.menuWordWrap.Text = "Word wrap";
            this.menuWordWrap.Click += new System.EventHandler(this.menuWordWrap_Click);
            // 
            // menuCopy
            // 
            this.menuCopy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCopySelected,
            this.menuCopyContent,
            this.menuCopyTitle});
            this.menuCopy.Name = "menuCopy";
            this.menuCopy.Size = new System.Drawing.Size(184, 22);
            this.menuCopy.Text = "&Copy";
            // 
            // menuCopySelected
            // 
            this.menuCopySelected.Name = "menuCopySelected";
            this.menuCopySelected.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCopySelected.Size = new System.Drawing.Size(189, 22);
            this.menuCopySelected.Text = "selected text";
            this.menuCopySelected.Click += new System.EventHandler(this.menuCopySelected_Click);
            // 
            // menuCopyContent
            // 
            this.menuCopyContent.Name = "menuCopyContent";
            this.menuCopyContent.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.menuCopyContent.Size = new System.Drawing.Size(189, 22);
            this.menuCopyContent.Text = "content";
            this.menuCopyContent.Click += new System.EventHandler(this.menuCopyContent_Click);
            // 
            // menuCopyTitle
            // 
            this.menuCopyTitle.Name = "menuCopyTitle";
            this.menuCopyTitle.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.menuCopyTitle.Size = new System.Drawing.Size(189, 22);
            this.menuCopyTitle.Text = "title";
            this.menuCopyTitle.Click += new System.EventHandler(this.menuCopyTitle_Click);
            // 
            // menuRollUp
            // 
            this.menuRollUp.Name = "menuRollUp";
            this.menuRollUp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.menuRollUp.Size = new System.Drawing.Size(184, 22);
            this.menuRollUp.Text = "&Roll up";
            this.menuRollUp.Click += new System.EventHandler(this.menuRollUp_Click);
            // 
            // menuHideNote
            // 
            this.menuHideNote.Name = "menuHideNote";
            this.menuHideNote.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.menuHideNote.Size = new System.Drawing.Size(184, 22);
            this.menuHideNote.Text = "&Hide note";
            this.menuHideNote.Click += new System.EventHandler(this.menuHideNote_Click);
            // 
            // btnHideNote
            // 
            this.btnHideNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHideNote.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHideNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideNote.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnHideNote.ForeColor = System.Drawing.Color.Black;
            this.btnHideNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHideNote.Location = new System.Drawing.Point(203, 4);
            this.btnHideNote.Margin = new System.Windows.Forms.Padding(4);
            this.btnHideNote.Name = "btnHideNote";
            this.btnHideNote.Size = new System.Drawing.Size(31, 23);
            this.btnHideNote.TabIndex = 1;
            this.btnHideNote.TabStop = false;
            this.btnHideNote.Text = "X";
            this.btnHideNote.UseVisualStyleBackColor = true;
            this.btnHideNote.Click += new System.EventHandler(this.btnHideNote_Click);
            // 
            // pnlNote
            // 
            this.pnlNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNote.BackColor = System.Drawing.Color.Transparent;
            this.pnlNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNote.ContextMenuStrip = this.menuFrmNoteOptions;
            this.pnlNote.Controls.Add(this.rtbNote);
            this.pnlNote.Controls.Add(this.pbResizeGrip);
            this.pnlNote.Location = new System.Drawing.Point(0, 31);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(240, 209);
            this.pnlNote.TabIndex = 4;
            // 
            // pbResizeGrip
            // 
            this.pbResizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbResizeGrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbResizeGrip.Image = global::NoteFly.Properties.Resources.hoekje;
            this.pbResizeGrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbResizeGrip.Location = new System.Drawing.Point(222, 191);
            this.pbResizeGrip.Margin = new System.Windows.Forms.Padding(0);
            this.pbResizeGrip.Name = "pbResizeGrip";
            this.pbResizeGrip.Size = new System.Drawing.Size(16, 16);
            this.pbResizeGrip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbResizeGrip.TabIndex = 4;
            this.pbResizeGrip.TabStop = false;
            this.pbResizeGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbResizeGrip_MouseMove);
            this.pbResizeGrip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbResizeGrip_MouseUp);
            // 
            // saveWorker
            // 
            this.saveWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SavePos_DoWork);
            // 
            // tableLayoutPanelHead
            // 
            this.tableLayoutPanelHead.ColumnCount = 2;
            this.tableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHead.Controls.Add(this.lblNoteTitle, 0, 0);
            this.tableLayoutPanelHead.Controls.Add(this.btnHideNote, 1, 0);
            this.tableLayoutPanelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHead.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHead.Name = "tableLayoutPanelHead";
            this.tableLayoutPanelHead.RowCount = 1;
            this.tableLayoutPanelHead.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHead.Size = new System.Drawing.Size(238, 30);
            this.tableLayoutPanelHead.TabIndex = 5;
            // 
            // rtbNote
            // 
            this.rtbNote.AccessibleDescription = "Note content";
            this.rtbNote.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.rtbNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbNote.CausesValidation = false;
            this.rtbNote.ContextMenuStrip = this.menuFrmNoteOptions;
            this.rtbNote.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbNote.DetectUrls = false;
            this.rtbNote.Font = new System.Drawing.Font("Verdana", 10F);
            this.rtbNote.ForeColor = System.Drawing.Color.Black;
            this.rtbNote.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.rtbNote.Location = new System.Drawing.Point(7, 6);
            this.rtbNote.Margin = new System.Windows.Forms.Padding(10);
            this.rtbNote.MaxLength = 1000000;
            this.rtbNote.Name = "rtbNote";
            this.rtbNote.ReadOnly = true;
            this.rtbNote.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbNote.ShortcutsEnabled = false;
            this.rtbNote.Size = new System.Drawing.Size(218, 185);
            this.rtbNote.TabIndex = 3;
            this.rtbNote.TabStop = false;
            this.rtbNote.Text = "";
            this.rtbNote.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtbNote_LinkClicked);
            // 
            // FrmNote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnHideNote;
            this.ClientSize = new System.Drawing.Size(240, 240);
            this.ContextMenuStrip = this.menuFrmNoteOptions;
            this.ControlBox = false;
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.pnlHead);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(100, 50);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1280, 1024);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(80, 60);
            this.Name = "FrmNote";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Activated += new System.EventHandler(this.FrmNote_Activated);
            this.Deactivate += new System.EventHandler(this.FrmNote_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNote_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNote_FormClosed);
            this.pnlHead.ResumeLayout(false);
            this.menuFrmNoteOptions.ResumeLayout(false);
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResizeGrip)).EndInit();
            this.tableLayoutPanelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHead;
    }
}
