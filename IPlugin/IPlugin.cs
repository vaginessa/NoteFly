﻿//-----------------------------------------------------------------------
// <copyright file="IPlugin.cs" company="NoteFly">
// Copyright 2011-2013 Tom
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//-----------------------------------------------------------------------
using System;

[assembly: CLSCompliant(true)]

/// <summary>
/// Provides interfaces for plugins
/// </summary>
namespace IPlugin
{    
    using System.Windows.Forms;

    /// <summary>
    /// Plugin interface
    /// status: DRAFT (Subject to change)
    /// revision: 10
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Gets the filename of this plugin.
        /// </summary>
        string Filename { get; }

        /// <summary>
        /// Gets the interface to let a plugin talk to NoteFly.
        /// </summary>
        IPluginHost Host { get; }

        /// <summary>
        /// Register plugin
        /// </summary>
        /// <param name="file">The plugin file.</param>
        /// <param name="host">Interface to notefly core.</param>
        void Register(string file, IPluginHost host);

        /// <summary>
        /// Plugin is being disabled.
        /// </summary>
        void Unregister();

        /// <summary>
        /// Adds ToolStripItem to the right click submenu share on FrmNote.
        /// </summary>
        /// <returns>A ToolStripMenuItem</returns>
        ToolStripMenuItem InitFrmNoteShareMenu();

        /// <summary>
        /// Executed if share menu clicked.
        /// </summary>
        /// <param name="rtbnote">The richedit component with the note content in memory.</param>
        /// <param name="title">The note title</param>
        void ShareMenuClicked(System.Windows.Forms.RichTextBox rtbnote, string title);

        /// <summary>
        /// Executed if settings tab loaded.
        /// </summary>
        /// <returns>A Tabpage with all components to draw.</returns>
        TabPage InitShareSettingsTab();

        /// <summary>
        /// Create a button in the bottom in FrmNewNote.
        /// </summary>
        /// <returns>The buttons created in FrmNewNote.</returns>
        Button[] InitNoteFormatBtns();

        /// <summary>
        /// Adds ToolStripItem to the right click menu on FrmNewNote.
        /// </summary>
        /// <returns>A ToolStripItem for the contextmenu of FrmNewNote.</returns>
        ToolStripItem InitFrmNewNoteMenu();

        /// <summary>
        /// Adds ToolStripItem to the right click menu on FrmNote.
        /// </summary>
        /// <returns>A ToolStripItem to add to the contextmenu of FrmNote.</returns>
        ToolStripItem InitFrmNoteMenu();

        /// <summary>
        /// Adds ToolStripItem to the right click menu of the trayicon.
        /// </summary>
        /// <returns>A ToolStripItem to the rightclick menu of the trayicon.</returns>
        ToolStripItem InitTrayIconMenu();

        /// <summary>
        /// Create button(s) in the top FrmManageNotes window.
        /// </summary>
        /// <returns>Array with the button or buttons to create.</returns>
        Button[] InitFrmManageNotesBtns();

        /// <summary>
        /// A plugin format button is cliked.
        /// </summary>
        /// <param name="rtbnote">The RichTextbox.</param>
        /// <param name="btn">The button is clicked.</param>
        /// <returns>The new rtf note content</returns>
        string NoteFormatBtnClicked(System.Windows.Forms.RichTextBox rtbnote, Button btn);

        /// <summary>
        /// Menu item in right click menu FrmNewNote is clicked.
        /// </summary>
        /// <param name="rtbnote">The RichTextbox.</param>
        /// <param name="menuitem">The button is clicked.</param>
        /// <returns>The new rtf note content</returns>
        string MenuFrmNewNoteClicked(System.Windows.Forms.RichTextBox rtbnote, ToolStripItem menuitem);

        /// <summary>
        /// Executed if Ok on FrmSettings is pressed.
        /// </summary>
        /// <returns>True if allowed to close FrmSettings.</returns>
        bool SaveSettingsTab();

        /// <summary>
        /// Executed if a note is saved
        /// </summary>
        /// <param name="content">The note content.</param>
        /// <param name="title">The note title.</param>
        void SavingNote(string filename, string content, string title);

        /// <summary>
        /// A note file is deleted within NoteFly.
        /// </summary>
        /// <param name="filename">The note filename.</param>
        void DeletingNote(string filename);

        /// <summary>
        /// A note file is being edited.
        /// </summary>
        /// <param name="filename"></param>
        void EditingNote(string filename);

        /// <summary>
        /// Executed if a note is made visible.
        /// </summary>
        /// <param name="content">The note content.</param>
        /// <param name="title">The note title.</param>
        void ShowingNote(string content, string title);

        /// <summary>
        /// Executed if a note is being hiden.
        /// </summary>
        /// <param name="content">The note content.</param>
        /// <param name="title">The note title.</param>
        void HidingNote(string content, string title);

        /// <summary>
        /// Executed if NoteFly is first runned with a newer version.
        /// </summary>
        void ProgramUpgraded();

        /// <summary>
        /// Get a additional filters for the save all notes to file in the manage notes window.
        /// </summary>
        /// <returns></returns>
        string ExportNotesDlgFilter();

        /// <summary>
        /// Export all notes to a signle file.
        /// </summary>
        /// <param name="filtername"></param>
        /// <returns>True if handled by plugin</returns>
        bool ExportNotesFile(string filtername);

        /// <summary>
        /// Add open dialog filters to the import notes window
        /// </summary>
        /// <returns></returns>
        string ImportNotesDlgFilter();

        /// <summary>
        /// Import notes backup/archive file.
        /// </summary>
        /// <param name="filtername"></param>
        /// <param name="file"></param>
        /// <returns></returns>
        bool ImportNotesFile(string filtername, string file);

        /// <summary>
        /// Validate syntax part
        /// </summary>
        /// <param name="part"></param>
        /// <param name="rtb"></param>
        /// <param name="rtf"></param>
        /// <param name="lastpos"></param>
        string ValidateSyntaxPart(string part, RichTextBox rtb, string rtf, int lastpos);

        /// <summary>
        /// Add a tab on initizilazting form settings 
        /// </summary>
        /// <returns></returns>
        TabPage InitTabFrmSettings();

        /// <summary>
        /// Export the note content save file dialog filter
        /// </summary>
        string ExportNoteContentDlgFilter();

        /// <summary>
        /// Export the note content via save note as file options with send to.menu.
        /// </summary>
        /// <param name="rtb">The richTextBox with note content</param>
        /// <returns></returns>
        bool ExportNoteContent(RichTextBox rtb);

        /// <summary>
        /// Start plugin actions on search in Manage notes window.
        /// </summary>
        /// <param name="keyword"></param>
        void ManageNotesSearch(string keyword);
    }
}