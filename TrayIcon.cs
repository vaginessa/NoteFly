//-----------------------------------------------------------------------
// <copyright file="TrayIcon.cs" company="NoteFly">
//  NoteFly a note application.
//  Copyright (C) 2010-2013  Tom
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
    using System.Windows.Forms;

    /// <summary>
    /// TrayIcon gui object class.
    /// </summary>
    public sealed class TrayIcon
    {
        /// <summary>
        /// Reference to the FormManager class.
        /// </summary>
        private FormManager formmanager;

        /// <summary>
        /// Container that holds some objects.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Indicated wheter confirm exit is showed.
        /// </summary>
        private bool confirmexitshowed = false;

        /// <summary>
        /// The trayicon itself.
        /// </summary>
        private NotifyIcon icon;

        /// <summary>
        /// The trayicon contextmenu
        /// </summary>
        private ContextMenuStrip menuTrayIcon;

        /// <summary>
        /// New note menu option
        /// </summary>
        private ToolStripMenuItem menuNewNote;

        /// <summary>
        /// Create a new note from clipboard.
        /// </summary>
        private ToolStripMenuItem menuNewNoteClipboard;

        /// <summary>
        /// Manage notes menu option
        /// </summary>
        private ToolStripMenuItem menuManageNotes;

        /// <summary>
        /// Settings application menu option
        /// </summary>
        private ToolStripMenuItem menuSettings;

        /// <summary>
        /// Plugins menu option
        /// </summary>
        private ToolStripMenuItem menuPlugins;

        /// <summary>
        /// About menu option
        /// </summary>
        private ToolStripMenuItem menuAbout;

        /// <summary>
        /// Exit menu option
        /// </summary>
        private ToolStripMenuItem menuExit;

        /// <summary>
        /// Initializes a new instance of the TrayIcon class.
        /// New trayicon in the systray.
        /// </summary>
        /// <param name="formmanager">Reference to FormManager class.</param>
        public TrayIcon (FormManager formmanager)
        {
            this.formmanager = formmanager;
            this.components = new System.ComponentModel.Container ();

            // Start building icon and icon contextmenu
            this.icon = new System.Windows.Forms.NotifyIcon (this.components);
            this.menuTrayIcon = new System.Windows.Forms.ContextMenuStrip (this.components);
            this.menuTrayIcon.Opening += new System.ComponentModel.CancelEventHandler (menuTrayIcon_Opening);
            this.menuTrayIcon.AllowDrop = false;
            this.menuTrayIcon.RightToLeft = (RightToLeft)Settings.FontTextdirection;
            this.menuNewNote = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuNewNoteClipboard = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuManageNotes = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuPlugins = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuSettings = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem ();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem ();
            this.icon.ContextMenuStrip = this.menuTrayIcon;
            if (Program.CurrentOS == Program.OS.WINDOWS) {
                    if (Settings.TrayiconAlternateIcon) {
                            this.icon.Icon = new Icon (NoteFly.Properties.Resources.trayicon_white, NoteFly.Properties.Resources.trayicon_white.Size);
                    } else {
                            this.icon.Icon = new Icon (NoteFly.Properties.Resources.trayicon_yellow, NoteFly.Properties.Resources.trayicon_yellow.Size);
                    }
            } else {
                Bitmap bm = NoteFly.Properties.Resources.trayicon_yellow_altformat;
                Icon trayicon = Icon.FromHandle(bm.GetHicon());
                this.icon.Icon = trayicon;
            }

            this.icon.MouseClick += new MouseEventHandler(this.Icon_Click);
            this.icon.Visible = true;
            this.icon.Icon.InitializeLifetimeService();
            this.icon.ContextMenuStrip.Name = "MenuTrayIcon";
            this.icon.ContextMenuStrip.ShowImageMargin = false;
            this.icon.ContextMenuStrip.Size = new System.Drawing.Size(145, 114);
            FontStyle menufontstyle = FontStyle.Regular;
            Font menufont;
            try
            {
                menufont = new Font(Settings.FontTrayicon, Settings.TrayiconFontsize, menufontstyle);
            }
            catch (ArgumentException argexc)
            {
                Log.Write(LogType.exception, argexc.Message);
                menufont = new Font("Arial", 10, menufontstyle);
            }

            // MenuNewNote
            this.menuNewNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuNewNote.Name = "MenuNewNote";
            this.menuNewNote.Size = new System.Drawing.Size(144, 22);
            this.menuNewNote.Text = Strings.T("&New note");
            if (Settings.TrayiconCreatenotebold)
            {
                menufontstyle = FontStyle.Bold;
            }

            this.menuNewNote.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, menufontstyle);
            this.menuNewNote.Click += new System.EventHandler(this.MenuNewNote_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuNewNote);

            this.menuNewNoteClipboard.DisplayStyle = ToolStripItemDisplayStyle.Text;
            //this.menuNewNoteClipboard.Enabled = Clipboard.ContainsText();
            this.menuNewNoteClipboard.Visible = Clipboard.ContainsText();
            this.menuNewNoteClipboard.Name = "MenuNewNoteClipboard";
            this.menuNewNoteClipboard.Size = new Size(144, 22);
            this.menuNewNoteClipboard.Text = Strings.T("&New note from clipboard");
            this.menuNewNoteClipboard.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, FontStyle.Regular);
            this.menuNewNoteClipboard.Click += new EventHandler(menuNewNoteClipboard_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuNewNoteClipboard);

            // MenuManageNotes
            this.menuManageNotes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuManageNotes.Name = "listToolStripMenuItem";
            this.menuManageNotes.Size = new System.Drawing.Size(144, 22);
            this.menuManageNotes.Text = Strings.T("&Manage notes");
            if (Settings.TrayiconManagenotesbold)
            {
                menufontstyle = FontStyle.Bold;
            }
            else
            {
                menufontstyle = FontStyle.Regular;
            }

            this.menuManageNotes.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, menufontstyle);
            this.menuManageNotes.Click += new System.EventHandler(this.MenuManageNotes_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuManageNotes);

            // MenuSettings
            this.menuSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuSettings.Name = "MenuSettings";
            this.menuSettings.Size = new System.Drawing.Size(144, 22);
            this.menuSettings.Text = Strings.T("&Settings");
            if (Settings.TrayiconSettingsbold)
            {
                menufontstyle = FontStyle.Bold;
            }
            else
            {
                menufontstyle = FontStyle.Regular;
            }

            this.menuSettings.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, menufontstyle);
            this.menuSettings.Click += new System.EventHandler(this.MenuSettings_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuSettings);

            // menuPlugins
            this.menuPlugins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuPlugins.Name = "MenuPlugins";
            this.menuPlugins.Size = new System.Drawing.Size(144, 22);
            this.menuPlugins.Text = Strings.T("&Plugins");
            this.menuPlugins.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, FontStyle.Regular);
            this.menuPlugins.Click += new System.EventHandler(this.MenuPlugins_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuPlugins);

            // Create trayicon plugin ToolStripMenuItem items, if any.
            if (PluginsManager.EnabledPlugins != null)
            {
                for (int p = 0; p < PluginsManager.EnabledPlugins.Count; p++)
                {
                    if (PluginsManager.EnabledPlugins[p].InitTrayIconMenu() != null)
                    {
                        ToolStripItem toolstripitem = PluginsManager.EnabledPlugins[p].InitTrayIconMenu();
                        toolstripitem.Size = new System.Drawing.Size(144, 22);
                        toolstripitem.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, FontStyle.Regular);
                        this.icon.ContextMenuStrip.Items.Add(toolstripitem);
                    }
                }
            }

            // MenuAbout
            this.menuAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuAbout.Name = "MenuAbout";
            this.menuAbout.Size = new System.Drawing.Size(144, 22);
            this.menuAbout.Text = Strings.T("About");
            this.menuAbout.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, FontStyle.Regular);
            this.menuAbout.Click += new System.EventHandler(this.MenuAbout_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuAbout);

            // MenuExit
            this.menuExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuExit.Name = "MenuExit";
            this.menuExit.Size = new System.Drawing.Size(144, 22);
            this.menuExit.Text = Strings.T("E&xit");
            if (Settings.TrayiconExitbold)
            {
                menufontstyle = FontStyle.Bold;
            }
            else
            {
                menufontstyle = FontStyle.Regular;
            }

            this.menuExit.Font = new Font(menufont.FontFamily.Name, menufont.SizeInPoints, menufontstyle);
            this.menuExit.Click += new System.EventHandler(this.MenuExit_Click);
            this.icon.ContextMenuStrip.Items.Add(this.menuExit);

            // Show balloontip on firstrun about trayicon how to access notefly functions.
            if (!Settings.ProgramFirstrunned)
            {
                string trayicon_trayiconaccesshint = Strings.T("You can access {0} functions with this trayicon.", Program.AssemblyTitle);
                this.icon.ShowBalloonTip(6000, Program.AssemblyTitle, trayicon_trayiconaccesshint, ToolTipIcon.Info);
            }
        }

        /// <summary>
        /// Destroy NotifyIcon with ContextMenuStrip and ToolStripMenuItems etc.
        /// </summary>
        public void Dispose()
        {
            this.icon.Visible = false; // Mono needs Visible set to false otherwise it keeps showing the trayicon.
            this.components.Dispose();
        }

        /// <summary>
        /// There is left clicked on the icon.
        /// If actionleftclick is 0 do nothing.
        /// If actionleftclick is 1 actived all notes.
        /// If actionleftclick is 2 create a new note.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void Icon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Settings.TrayiconLeftclickaction == 1)
                {
                    this.formmanager.BringToFrontNotes();
                }
                else if (Settings.TrayiconLeftclickaction == 2)
                {
                    this.formmanager.OpenNewNote(false);
                }
            }
        }

        /// <summary>
        /// Trayicon menu is being openened.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void menuTrayIcon_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //this.menuNewNoteClipboard.Enabled = Clipboard.ContainsText();
            this.menuNewNoteClipboard.Visible = Clipboard.ContainsText();
        }

        /// <summary>
        /// Open new note window with content set from clipboard text.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event arguments</param>
        private void menuNewNoteClipboard_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenNewNote(true);
        }

        /// <summary>
        /// Open new note window.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuNewNote_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenNewNote(false);
        }

        /// <summary>
        /// Open manage notes window.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuManageNotes_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenFrmManageNotes();
        }

        /// <summary>
        /// Open settings window.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuSettings_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenFrmSettings();
        }

        /// <summary>
        /// Open plugins window.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuPlugins_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenFrmPlugins();
        }

        /// <summary>
        /// Open about window.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuAbout_Click(object sender, EventArgs e)
        {
            this.formmanager.OpenFrmAbout();
        }

        /// <summary>
        /// User request to shutdown application.
        /// Check if confirm box is needed. 
        /// If confirm box is still open and menuExit_Click event is fired then shutdown application anyway.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Event argument</param>
        private void MenuExit_Click(object sender, EventArgs e)
        {
            string trayicon_sureexittitle = Strings.T("confirm exit");
            if (Settings.ConfirmExit)
            {
                // Two times exit in contextmenu systray icon will always exit.
                if (!this.confirmexitshowed)
                {
                    this.confirmexitshowed = true;
                    string trayicon_sureexit = Strings.T("Are sure you want to exit {0}?", Program.AssemblyTitle);
                    DialogResult resdlgconfirmexit = MessageBox.Show(trayicon_sureexit, trayicon_sureexittitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resdlgconfirmexit == DialogResult.No)
                    {
                        this.confirmexitshowed = false;
                        return;
                    }
                }
            }

            if (this.formmanager.Frmneweditnoteopen)
            {
                string trayicon_notestillopen = Strings.T("A note is still open for editing.\nAre you sure you want to shutdown {0}?", Program.AssemblyTitle);
                DialogResult resdlg = MessageBox.Show(trayicon_notestillopen, trayicon_sureexittitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resdlg == DialogResult.No)
                {
                    return;
                }
            }

            this.components.Dispose();
            Application.Exit();
        }
    }
}
