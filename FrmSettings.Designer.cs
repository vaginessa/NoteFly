//-----------------------------------------------------------------------
// <copyright file="FrmSettings.Designer.cs" company="NoteFly">
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
    /// <summary>
    /// FrmSettings class.
    /// </summary>
    public partial class FrmSettings
    {
        /// <summary>
        /// Button btnOK
        /// </summary>
        private System.Windows.Forms.Button btnOK;

        /// <summary>
        /// Button btnCancel
        /// </summary>
        private System.Windows.Forms.Button btnCancel;

        /// <summary>
        /// TabControl tabControlSettings
        /// </summary>
        private System.Windows.Forms.TabControl tabControlSettings;

        /// <summary>
        /// TabPage tabAppearance
        /// </summary>
        private System.Windows.Forms.TabPage tabAppearance;

        /// <summary>
        /// TabPage tabSharing
        /// </summary>
        private System.Windows.Forms.TabPage tabSharing;

        /// <summary>
        /// TabPage tabAdvance
        /// </summary>
        private System.Windows.Forms.TabPage tabAdvance;

        /// <summary>
        /// FolderBrowserDialog folderBrowserDialogNotessavepath
        /// </summary>
        private System.Windows.Forms.FolderBrowserDialog folderBrowseDialogNotessavepath;

        /// <summary>
        /// TabPage tabGeneral
        /// </summary>
        private System.Windows.Forms.TabPage tabGeneral;

        /// <summary>
        /// CheckBox chxConfirmLink
        /// </summary>
        private System.Windows.Forms.CheckBox chxConfirmLink;

        /// <summary>
        /// CheckBox chxLogErrors
        /// </summary>
        private System.Windows.Forms.CheckBox chxLogErrors;

        /// <summary>
        /// Button btnResetSettings
        /// </summary>
        private System.Windows.Forms.Button btnResetSettings;

        /// <summary>
        /// TabPage tabNetwerk
        /// </summary>
        private System.Windows.Forms.TabPage tabNetwork;

        /// <summary>
        /// CheckBox chxProxyEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxProxyEnabled;

        /// <summary>
        /// CheckBox chxLogDebug
        /// </summary>
        private System.Windows.Forms.CheckBox chxLogDebug;

        /// <summary>
        /// TabPage tabHighlight
        /// </summary>
        private System.Windows.Forms.TabPage tabHighlight;

        /// <summary>
        /// CheckBox chxHighlightHTML
        /// </summary>
        private System.Windows.Forms.CheckBox chxHighlightHTML;

        /// <summary>
        /// Label lblTextNetworkMiliseconds
        /// </summary>
        private System.Windows.Forms.Label lblTextNetworkMiliseconds;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// CheckBox chxHighlightHyperlinks
        /// </summary>
        private System.Windows.Forms.CheckBox chxHighlightHyperlinks;

        /// <summary>
        /// CheckBox chxHighlightSQL
        /// </summary>
        private System.Windows.Forms.CheckBox chxHighlightSQL;

        /// <summary>
        /// CheckBox chxHighlightPHP
        /// </summary>
        private System.Windows.Forms.CheckBox chxHighlightPHP;

        /// <summary>
        /// TabControl tabControlSocialNetworks
        /// </summary>
        private System.Windows.Forms.TabControl tabControlSharing;

        /// <summary>
        /// TabPage tabEmail
        /// </summary>
        private System.Windows.Forms.TabPage tabEmail;

        /// <summary>
        /// CheckBox chxSocialEmailDefaultaddressBlank
        /// </summary>
        private System.Windows.Forms.CheckBox chxActionsEmailDefaultaddressSet;

        /// <summary>
        /// CheckBox chxSocialEmailEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxActionsEmailEnabled;

        /// <summary>
        /// CheckBox chxCheckUpdates
        /// </summary>
        private System.Windows.Forms.CheckBox chxCheckUpdates;

        /// <summary>
        /// Label lblTextCheckforupdatesevery
        /// </summary>
        private System.Windows.Forms.Label lblTextCheckforupdatesevery;

        /// <summary>
        /// NumericUpDown numUpdateCheckDays
        /// </summary>
        private System.Windows.Forms.NumericUpDown numUpdateCheckDays;

        /// <summary>
        /// Label lblTextDayAtStartup
        /// </summary>
        private System.Windows.Forms.Label lblTextDayAtStartup;

        /// <summary>
        /// TabControl tabAppearanceColors
        /// </summary>
        private System.Windows.Forms.TabControl tabctrlAppearance;

        /// <summary>
        /// TabPage tabPageFonts
        /// </summary>
        private System.Windows.Forms.TabPage tabPageFonts;

        /// <summary>
        /// Label lblTextFontTitlePoints
        /// </summary>
        private System.Windows.Forms.Label lblTextFontTitlePoints;

        /// <summary>
        /// NumericUpDown numFontSizeTitle
        /// </summary>
        private System.Windows.Forms.NumericUpDown numFontSizeTitle;

        /// <summary>
        /// Label lblTextFontTitleSize
        /// </summary>
        private System.Windows.Forms.Label lblTextFontTitleSize;

        /// <summary>
        /// ComboBox cbxFontNoteTitle
        /// </summary>
        private System.Windows.Forms.ComboBox cbxFontNoteTitle;

        /// <summary>
        /// Label lblTextFontTitleFamily
        /// </summary>
        private System.Windows.Forms.Label lblTextFontTitleFamily;

        /// <summary>
        /// Label lblTextDirection
        /// </summary>
        private System.Windows.Forms.Label lblTextDirection;

        /// <summary>
        /// ComboBox cbxTextDirection
        /// </summary>
        private System.Windows.Forms.ComboBox cbxTextDirection;

        /// <summary>
        /// Label lblTextFontContentPoints
        /// </summary>
        private System.Windows.Forms.Label lblTextFontContentPoints;

        /// <summary>
        /// NumericUpDown numFontSizeContent
        /// </summary>
        private System.Windows.Forms.NumericUpDown numFontSizeContent;

        /// <summary>
        /// Label lblTextFontContentSize
        /// </summary>
        private System.Windows.Forms.Label lblTextFontContentSize;

        /// <summary>
        /// Label lblTextNoteFont
        /// </summary>
        private System.Windows.Forms.Label lblTextNoteFont;

        /// <summary>
        /// ComboBox cbxFontNoteContent
        /// </summary>
        private System.Windows.Forms.ComboBox cbxFontNoteContent;

        /// <summary>
        /// CheckBox cbxFontNoteTitleBold
        /// </summary>
        private System.Windows.Forms.CheckBox cbxFontNoteTitleBold;

        /// <summary>
        /// Label lblTextLogging
        /// </summary>
        private System.Windows.Forms.Label lblTextLogging;

        /// <summary>
        /// CheckBox chxLogExceptions
        /// </summary>
        private System.Windows.Forms.CheckBox chxLogExceptions;

        /// <summary>
        /// TabPage tabPageTrayicon
        /// </summary>
        private System.Windows.Forms.TabPage tabPageTrayicon;

        /// <summary>
        /// CheckBox chxTrayiconBoldExit
        /// </summary>
        private System.Windows.Forms.CheckBox chxTrayiconBoldExit;

        /// <summary>
        /// CheckBox chxTrayiconBoldSettings
        /// </summary>
        private System.Windows.Forms.CheckBox chxTrayiconBoldSettings;

        /// <summary>
        /// CheckBox chxTrayiconBoldManagenotes
        /// </summary>
        private System.Windows.Forms.CheckBox chxTrayiconBoldManagenotes;

        /// <summary>
        /// CheckBox chxTrayiconBoldNewnote
        /// </summary>
        private System.Windows.Forms.CheckBox chxTrayiconBoldNewnote;

        /// <summary>
        /// Label lblTextFontsizeMenu
        /// </summary>
        private System.Windows.Forms.Label lblTextFontsizeMenu;

        /// <summary>
        /// NumericUpDown numTrayiconFontsize
        /// </summary>
        private System.Windows.Forms.NumericUpDown numTrayiconFontsize;

        /// <summary>
        /// Label lblFontsizePoints
        /// </summary>
        private System.Windows.Forms.Label lblFontsizePoints;

        /// <summary>
        /// Button btnCheckUpdates
        /// </summary>
        private System.Windows.Forms.Button btnCheckUpdates;

        /// <summary>
        /// Label lblTextLatestUpdateCheck
        /// </summary>
        private System.Windows.Forms.Label lblTextLatestUpdateCheck;

        /// <summary>
        /// Label lblLatestUpdateCheck
        /// </summary>
        private System.Windows.Forms.Label lblLatestUpdateCheck;

        /// <summary>
        /// CheckBox chxSettingsExpertEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxSettingsExpertEnabled;

        /// <summary>
        /// TabControl tabControlNetwork
        /// </summary>
        private System.Windows.Forms.TabControl tabControlNetwork;

        /// <summary>
        /// TabPage tabUpdates
        /// </summary>
        private System.Windows.Forms.TabPage tabUpdates;

        /// <summary>
        /// TabPage tabProxy
        /// </summary>
        private System.Windows.Forms.TabPage tabProxy;

        /// <summary>
        /// OpenFileDialog openFileDialogBrowseGPG
        /// </summary>
        private System.Windows.Forms.OpenFileDialog openFileDialogBrowseGPG;

        /// <summary>
        /// CheckBox chxUpdateSilentInstall
        /// </summary>
        private System.Windows.Forms.CheckBox chxUpdateSilentInstall;

        /// <summary>
        /// CheckBox chxUseAlternativeTrayicon
        /// </summary>
        private System.Windows.Forms.CheckBox chxUseAlternativeTrayicon;

        /// <summary>
        /// Label lblTextMiliseconds
        /// </summary>
        private System.Windows.Forms.Label lblTextMiliseconds;

        /// <summary>
        /// NumericUpDown numWarnLimitVisible
        /// </summary>
        private System.Windows.Forms.NumericUpDown numWarnLimitVisible;

        /// <summary>
        /// Label lblTextVisibleNotesWarnLimit
        /// </summary>
        private System.Windows.Forms.Label lblTextVisibleNotesWarnLimit;

        /// <summary>
        /// Label lblTextTotalNotesWarnLimit
        /// </summary>
        private System.Windows.Forms.Label lblTextTotalNotesWarnLimit;

        /// <summary>
        /// NumericUpDown numWarnLimitTotal
        /// </summary>
        private System.Windows.Forms.NumericUpDown numWarnLimitTotal;

        /// <summary>
        /// TabPage tabAppearanceOverall
        /// </summary>
        private System.Windows.Forms.TabPage tabAppearanceOverall;

        /// <summary>
        /// CheckBox chxShowTooltips
        /// </summary>
        private System.Windows.Forms.CheckBox chxShowTooltips;

        /// <summary>
        /// CheckBox chxTransparecy
        /// </summary>
        private System.Windows.Forms.CheckBox chxTransparecy;

        /// <summary>
        /// NumericUpDown  numProcTransparency
        /// </summary>
        private System.Windows.Forms.NumericUpDown numProcTransparency;

        /// <summary>
        /// Label lblTextTransparentProcVisibl
        /// </summary>
        private System.Windows.Forms.Label lblTextTransparentProcVisible;

        /// <summary>
        /// TabPage tabPageNewNote
        /// </summary>
        private System.Windows.Forms.TabPage tabPageNewNote;

        /// <summary>
        /// CheckBox chxUseRandomDefaultNot
        /// </summary>
        private System.Windows.Forms.CheckBox chxUseRandomDefaultNote;

        /// <summary>
        /// Label lblDefaultNewNoteColor
        /// </summary>
        private System.Windows.Forms.Label lblDefaultNewNoteColor;

        /// <summary>
        /// ComboBox cbxDefaultSkin
        /// </summary>
        private System.Windows.Forms.ComboBox cbxDefaultSkin;

        /// <summary>
        /// Label  lblTextDefaultsizenewnote
        /// </summary>
        private System.Windows.Forms.Label lblTextDefaultsizenewnote;

        /// <summary>
        /// Label lblTextHeight
        /// </summary>
        private System.Windows.Forms.Label lblTextHeight;

        /// <summary>
        /// Label lblTextWidth
        /// </summary>
        private System.Windows.Forms.Label lblTextWidth;

        /// <summary>
        /// NumericUpDown numNotesDefaultHeigh
        /// </summary>
        private System.Windows.Forms.NumericUpDown numNotesDefaultHeight;

        /// <summary>
        /// NumericUpDown numNotesDefaultWidth
        /// </summary>
        private System.Windows.Forms.NumericUpDown numNotesDefaultWidth;

        /// <summary>
        /// IPTextBox iptbProxy
        /// </summary>
        private IPTextBox iptbProxy;

        /// <summary>
        /// TabPage tabAppereanceManagenotes
        /// </summary>
        private System.Windows.Forms.TabPage tabAppereanceManagenotes;

        /// <summary>
        /// CheckBox chxManagenotesTooltipContent
        /// </summary>
        private System.Windows.Forms.CheckBox chxManagenotesTooltipContent;

        /// <summary>
        /// ComboBox cbxManageNotesSkin
        /// </summary>
        private System.Windows.Forms.ComboBox cbxManageNotesSkin;

        /// <summary>
        /// Label lblTextSkinManagenotes
        /// </summary>
        private System.Windows.Forms.Label lblTextSkinManagenotes;

        /// <summary>
        /// CheckBox chxUseDateAsDefaultTitle
        /// </summary>
        private System.Windows.Forms.CheckBox chxUseDateAsDefaultTitle;

        /// <summary>
        /// NumericUpDown numManagenotesFon
        /// </summary>
        private System.Windows.Forms.NumericUpDown numManagenotesFont;

        /// <summary>
        /// Label lbTextManagesnotesFontSize
        /// </summary>
        private System.Windows.Forms.Label lbTextManagesnotesFontSize;

        /// <summary>
        /// Label lblTextPoints
        /// </summary>
        private System.Windows.Forms.Label lblTextPoints;

        /// <summary>
        /// CheckBox chxCaseSentiveSearch
        /// </summary>
        private System.Windows.Forms.CheckBox chxCaseSentiveSearch;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel1
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel2
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTrayicon;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanelNotes
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNotes;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel3
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanelNewNot
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelNewNote;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel4
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel6
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel7
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel8
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;

        /// <summary>
        /// TabPage tabPageGPG
        /// </summary>
        private System.Windows.Forms.TabPage tabPageGPG;

        /// <summary>
        /// Button btnGPGPathBrowse
        /// </summary>
        private System.Windows.Forms.Button btnGPGPathBrowse;

        /// <summary>
        /// Label lblTextGPGPath
        /// </summary>
        private System.Windows.Forms.Label lblTextGPGPath;

        /// <summary>
        /// CheckBox chxCheckUpdatesSignature
        /// </summary>
        private System.Windows.Forms.CheckBox chxCheckUpdatesSignature;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel9
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;

        /// <summary>
        /// Label lblTextAddress
        /// </summary>
        private System.Windows.Forms.Label lblTextAddress;

        /// <summary>
        /// NumericUpDown numProxyPort
        /// </summary>
        private System.Windows.Forms.NumericUpDown numProxyPort;

        /// <summary>
        /// Label lblTextPort
        /// </summary>
        private System.Windows.Forms.Label lblTextPort;

        /// <summary>
        /// IOTextBox tbGPGPath
        /// </summary>
        private IOTextBox tbGPGPath;

        /// <summary>
        /// EmailTextBox tbDefaultEmail
        /// </summary>
        private EmailTextBox tbDefaultEmail;

        /// <summary>
        /// IOTextBox tbNotesSavePath
        /// </summary>
        private IOTextBox tbNotesSavePath;

        /// <summary>
        /// Button btnBrowse
        /// </summary>
        private System.Windows.Forms.Button btnBrowse;

        /// <summary>
        /// Label lblTextNoteLocation
        /// </summary>
        private System.Windows.Forms.Label lblTextNoteLocation;

        /// <summary>
        /// TabPage tabHotkeys
        /// </summary>
        private System.Windows.Forms.TabPage tabHotkeys;

        /// <summary>
        /// Label lblTextShortcutManageNotes
        /// </summary>
        private System.Windows.Forms.Label lblTextHotkeyManageNotes;

        /// <summary>
        /// Label lblTextShortcutNewNote
        /// </summary>
        private System.Windows.Forms.Label lblTextHotkeyNewNote;

        /// <summary>
        /// CheckBox chxNotesDeleteRecyclebin
        /// </summary>
        private System.Windows.Forms.CheckBox chxNotesDeleteRecyclebin;

        /// <summary>
        /// CheckBox chxConfirmDeletenote
        /// </summary>
        private System.Windows.Forms.CheckBox chxConfirmDeletenote;

        /// <summary>
        /// CheckBox chxStartOnLogin
        /// </summary>
        private System.Windows.Forms.CheckBox chxStartOnLogin;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel5
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

        /// <summary>
        /// Label lblTextActionLeftClicktTrayicon
        /// </summary>
        private System.Windows.Forms.Label lblTextActionLeftClicktTrayicon;

        /// <summary>
        /// Forms.ComboBox cbxLanguage
        /// </summary>
        private System.Windows.Forms.ComboBox cbxLanguage;

        /// <summary>
        /// Label lblTextLanguage
        /// </summary>
        private System.Windows.Forms.Label lblTextLanguage;

        /// <summary>
        /// ComboBox cbxActionLeftclick
        /// </summary>
        private System.Windows.Forms.ComboBox cbxActionLeftclick;

        /// <summary>
        /// CheckBox chxConfirmExit
        /// </summary>
        private System.Windows.Forms.CheckBox chxConfirmExit;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanelShortcuts
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelShortcuts;

        /// <summary>
        /// ShortcutTextBox shortcutTextBoxManageNotes
        /// </summary>
        private ShortcutTextBox shortcutTextBoxManageNotes;

        /// <summary>
        /// ShortcutTextBox shortcutTextBoxNewNote
        /// </summary>
        private ShortcutTextBox shortcutTextBoxNewNote;

        /// <summary>
        /// Label lblTextHotkeyNotesToFront
        /// </summary>
        private System.Windows.Forms.Label lblTextHotkeyNotesToFront;

        /// <summary>
        /// ShortcutTextBox shortcutTextBoxNotesToFront
        /// </summary>
        private ShortcutTextBox shortcutTextBoxNotesToFront;

        /// <summary>
        /// ComboBox cbxNetworkIPversion
        /// </summary>
        private System.Windows.Forms.ComboBox cbxNetworkIPversion;

        /// <summary>
        /// Label lblTextNetworkTimeout
        /// </summary>
        private System.Windows.Forms.Label lblTextNetworkTimeout;

        /// <summary>
        /// Label lblTextPreferedIPversion
        /// </summary>
        private System.Windows.Forms.Label lblTextPreferedIPversion;

        /// <summary>
        /// NumericUpDown numTimeout
        /// </summary>
        private System.Windows.Forms.NumericUpDown numTimeout;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel10
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;

        /// <summary>
        /// Button btnOpenSettingsFolder
        /// </summary>
        private System.Windows.Forms.Button btnOpenSettingsFolder;

        /// <summary>
        /// ComboBox cbxFontTrayicon
        /// </summary>
        private System.Windows.Forms.ComboBox cbxFontTrayicon;

        /// <summary>
        /// Label lblTextTrayiconFont
        /// </summary>
        private System.Windows.Forms.Label lblTextTrayiconFont;

        /// <summary>
        /// CheckBox chxHotkeyNewNoteEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxHotkeyNewNoteEnabled;

        /// <summary>
        /// CheckBox chxHotkeyManageNotesEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxHotkeyManageNotesEnabled;

        /// <summary>
        /// Checkbox chxHotkeyNotesFrontEnabled
        /// </summary>
        private System.Windows.Forms.CheckBox chxHotkeyNotesFrontEnabled;

        /// <summary>
        /// TableLayoutPanel tableLayoutPanel11
        /// </summary>
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chxNotesDeleteRecyclebin = new System.Windows.Forms.CheckBox();
            this.chxLoadPlugins = new System.Windows.Forms.CheckBox();
            this.lblTextActionLeftClicktTrayicon = new System.Windows.Forms.Label();
            this.chxConfirmDeletenote = new System.Windows.Forms.CheckBox();
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.chxStartOnLogin = new System.Windows.Forms.CheckBox();
            this.lblTextLanguage = new System.Windows.Forms.Label();
            this.chxConfirmExit = new System.Windows.Forms.CheckBox();
            this.cbxActionLeftclick = new System.Windows.Forms.ComboBox();
            this.tabHotkeys = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelShortcuts = new System.Windows.Forms.TableLayoutPanel();
            this.shortcutTextBoxNotesToFront = new NoteFly.ShortcutTextBox();
            this.lblTextHotkeyNotesToFront = new System.Windows.Forms.Label();
            this.shortcutTextBoxManageNotes = new NoteFly.ShortcutTextBox();
            this.lblTextHotkeyNewNote = new System.Windows.Forms.Label();
            this.lblTextHotkeyManageNotes = new System.Windows.Forms.Label();
            this.shortcutTextBoxNewNote = new NoteFly.ShortcutTextBox();
            this.chxHotkeyNewNoteEnabled = new System.Windows.Forms.CheckBox();
            this.chxHotkeyManageNotesEnabled = new System.Windows.Forms.CheckBox();
            this.chxHotkeyNotesFrontEnabled = new System.Windows.Forms.CheckBox();
            this.tabAppearance = new System.Windows.Forms.TabPage();
            this.tabctrlAppearance = new System.Windows.Forms.TabControl();
            this.tabAppearanceOverall = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.chxTransparecy = new System.Windows.Forms.CheckBox();
            this.chxShowTooltips = new System.Windows.Forms.CheckBox();
            this.numProcTransparency = new System.Windows.Forms.NumericUpDown();
            this.lblTextTransparentProcVisible = new System.Windows.Forms.Label();
            this.tabPageNewNote = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextWidth = new System.Windows.Forms.Label();
            this.lblTextHeight = new System.Windows.Forms.Label();
            this.lblTextDefaultsizenewnote = new System.Windows.Forms.Label();
            this.numNotesDefaultHeight = new System.Windows.Forms.NumericUpDown();
            this.numNotesDefaultWidth = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanelNewNote = new System.Windows.Forms.TableLayoutPanel();
            this.chxUseRandomDefaultNote = new System.Windows.Forms.CheckBox();
            this.lblDefaultNewNoteColor = new System.Windows.Forms.Label();
            this.cbxDefaultSkin = new System.Windows.Forms.ComboBox();
            this.chxUseDateAsDefaultTitle = new System.Windows.Forms.CheckBox();
            this.tabPageFonts = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelNotes = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextFontContentPoints = new System.Windows.Forms.Label();
            this.numFontSizeContent = new System.Windows.Forms.NumericUpDown();
            this.lblTextFontContentSize = new System.Windows.Forms.Label();
            this.cbxFontNoteContent = new System.Windows.Forms.ComboBox();
            this.lblTextNoteFont = new System.Windows.Forms.Label();
            this.cbxFontNoteTitleBold = new System.Windows.Forms.CheckBox();
            this.lblTextFontTitlePoints = new System.Windows.Forms.Label();
            this.numFontSizeTitle = new System.Windows.Forms.NumericUpDown();
            this.lblTextFontTitleSize = new System.Windows.Forms.Label();
            this.cbxFontNoteTitle = new System.Windows.Forms.ComboBox();
            this.lblTextFontTitleFamily = new System.Windows.Forms.Label();
            this.lblTextDirection = new System.Windows.Forms.Label();
            this.cbxTextDirection = new System.Windows.Forms.ComboBox();
            this.tabPageTrayicon = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelTrayicon = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextTrayiconFont = new System.Windows.Forms.Label();
            this.lblTextFontsizeMenu = new System.Windows.Forms.Label();
            this.numTrayiconFontsize = new System.Windows.Forms.NumericUpDown();
            this.lblFontsizePoints = new System.Windows.Forms.Label();
            this.cbxFontTrayicon = new System.Windows.Forms.ComboBox();
            this.chxUseAlternativeTrayicon = new System.Windows.Forms.CheckBox();
            this.chxTrayiconBoldExit = new System.Windows.Forms.CheckBox();
            this.chxTrayiconBoldSettings = new System.Windows.Forms.CheckBox();
            this.chxTrayiconBoldManagenotes = new System.Windows.Forms.CheckBox();
            this.chxTrayiconBoldNewnote = new System.Windows.Forms.CheckBox();
            this.tabAppereanceManagenotes = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTextManagesnotesFontSize = new System.Windows.Forms.Label();
            this.lblTextSkinManagenotes = new System.Windows.Forms.Label();
            this.cbxManageNotesSkin = new System.Windows.Forms.ComboBox();
            this.numManagenotesFont = new System.Windows.Forms.NumericUpDown();
            this.lblTextPoints = new System.Windows.Forms.Label();
            this.chxCaseSentiveSearch = new System.Windows.Forms.CheckBox();
            this.chxManagenotesTooltipContent = new System.Windows.Forms.CheckBox();
            this.tabHighlight = new System.Windows.Forms.TabPage();
            this.chxLexiconMemory = new System.Windows.Forms.CheckBox();
            this.chxHighlightSQL = new System.Windows.Forms.CheckBox();
            this.chxHighlightPHP = new System.Windows.Forms.CheckBox();
            this.chxHighlightHyperlinks = new System.Windows.Forms.CheckBox();
            this.chxConfirmLink = new System.Windows.Forms.CheckBox();
            this.chxHighlightHTML = new System.Windows.Forms.CheckBox();
            this.tabSharing = new System.Windows.Forms.TabPage();
            this.tabControlSharing = new System.Windows.Forms.TabControl();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.tbDefaultEmail = new NoteFly.EmailTextBox();
            this.chxActionsEmailEnabled = new System.Windows.Forms.CheckBox();
            this.chxActionsEmailDefaultaddressSet = new System.Windows.Forms.CheckBox();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.tabControlNetwork = new System.Windows.Forms.TabControl();
            this.tabUpdates = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextDaysPlugins = new System.Windows.Forms.Label();
            this.numUpdateCheckPluginsDays = new System.Windows.Forms.NumericUpDown();
            this.lblTextCheckpluginsupdatesevery = new System.Windows.Forms.Label();
            this.numUpdateCheckDays = new System.Windows.Forms.NumericUpDown();
            this.lblTextDayAtStartup = new System.Windows.Forms.Label();
            this.lblTextCheckforupdatesevery = new System.Windows.Forms.Label();
            this.chxCheckUpdates = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextLatestUpdateCheck = new System.Windows.Forms.Label();
            this.lblLatestUpdateCheck = new System.Windows.Forms.Label();
            this.chxUpdateSilentInstall = new System.Windows.Forms.CheckBox();
            this.btnCheckUpdates = new System.Windows.Forms.Button();
            this.tabProxy = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.chxProxyEnabled = new System.Windows.Forms.CheckBox();
            this.numProxyPort = new System.Windows.Forms.NumericUpDown();
            this.lblTextAddress = new System.Windows.Forms.Label();
            this.iptbProxy = new NoteFly.IPTextBox();
            this.lblTextPort = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTextNetworkTimeout = new System.Windows.Forms.Label();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.lblTextMiliseconds = new System.Windows.Forms.Label();
            this.lblTextPreferedIPversion = new System.Windows.Forms.Label();
            this.cbxNetworkIPversion = new System.Windows.Forms.ComboBox();
            this.tabPageGPG = new System.Windows.Forms.TabPage();
            this.tbGPGPath = new NoteFly.IOTextBox();
            this.btnGPGPathBrowse = new System.Windows.Forms.Button();
            this.lblTextGPGPath = new System.Windows.Forms.Label();
            this.chxCheckUpdatesSignature = new System.Windows.Forms.CheckBox();
            this.lblTextNetworkMiliseconds = new System.Windows.Forms.Label();
            this.tabAdvance = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnOpenSettingsFolder = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblTextNoteLocation = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.numWarnLimitVisible = new System.Windows.Forms.NumericUpDown();
            this.lblTextTotalNotesWarnLimit = new System.Windows.Forms.Label();
            this.lblTextVisibleNotesWarnLimit = new System.Windows.Forms.Label();
            this.numWarnLimitTotal = new System.Windows.Forms.NumericUpDown();
            this.chxLogExceptions = new System.Windows.Forms.CheckBox();
            this.lblTextLogging = new System.Windows.Forms.Label();
            this.chxLogDebug = new System.Windows.Forms.CheckBox();
            this.chxLogErrors = new System.Windows.Forms.CheckBox();
            this.tbNotesSavePath = new NoteFly.IOTextBox();
            this.chxSettingsExpertEnabled = new System.Windows.Forms.CheckBox();
            this.folderBrowseDialogNotessavepath = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialogBrowseGPG = new System.Windows.Forms.OpenFileDialog();
            this.tabControlSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabHotkeys.SuspendLayout();
            this.tableLayoutPanelShortcuts.SuspendLayout();
            this.tabAppearance.SuspendLayout();
            this.tabctrlAppearance.SuspendLayout();
            this.tabAppearanceOverall.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcTransparency)).BeginInit();
            this.tabPageNewNote.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotesDefaultHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotesDefaultWidth)).BeginInit();
            this.tableLayoutPanelNewNote.SuspendLayout();
            this.tabPageFonts.SuspendLayout();
            this.tableLayoutPanelNotes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSizeContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSizeTitle)).BeginInit();
            this.tabPageTrayicon.SuspendLayout();
            this.tableLayoutPanelTrayicon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrayiconFontsize)).BeginInit();
            this.tabAppereanceManagenotes.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManagenotesFont)).BeginInit();
            this.tabHighlight.SuspendLayout();
            this.tabSharing.SuspendLayout();
            this.tabControlSharing.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            this.tabControlNetwork.SuspendLayout();
            this.tabUpdates.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCheckPluginsDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCheckDays)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            this.tabProxy.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.tabPageGPG.SuspendLayout();
            this.tabAdvance.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWarnLimitVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWarnLimitTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOK.BackColor = System.Drawing.Color.LightGray;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOK.Location = new System.Drawing.Point(205, 372);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(127, 25);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "&OK";
            this.btnOK.UseCompatibleTextRendering = true;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(338, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(134, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabGeneral);
            this.tabControlSettings.Controls.Add(this.tabHotkeys);
            this.tabControlSettings.Controls.Add(this.tabAppearance);
            this.tabControlSettings.Controls.Add(this.tabHighlight);
            this.tabControlSettings.Controls.Add(this.tabSharing);
            this.tabControlSettings.Controls.Add(this.tabNetwork);
            this.tabControlSettings.Controls.Add(this.tabAdvance);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tabControlSettings.HotTrack = true;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(476, 366);
            this.tabControlSettings.TabIndex = 17;
            this.tabControlSettings.SelectedIndexChanged += new System.EventHandler(this.tabControlSettings_SelectedIndexChanged);
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tableLayoutPanel5);
            this.tabGeneral.Location = new System.Drawing.Point(4, 25);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(468, 337);
            this.tabGeneral.TabIndex = 3;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.chxNotesDeleteRecyclebin, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.chxLoadPlugins, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lblTextActionLeftClicktTrayicon, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.chxConfirmDeletenote, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.cbxLanguage, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.chxStartOnLogin, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblTextLanguage, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.chxConfirmExit, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbxActionLeftclick, 1, 6);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(20, 45);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 8;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(415, 206);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // chxNotesDeleteRecyclebin
            // 
            this.chxNotesDeleteRecyclebin.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chxNotesDeleteRecyclebin, 2);
            this.chxNotesDeleteRecyclebin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxNotesDeleteRecyclebin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxNotesDeleteRecyclebin.Location = new System.Drawing.Point(3, 75);
            this.chxNotesDeleteRecyclebin.Name = "chxNotesDeleteRecyclebin";
            this.chxNotesDeleteRecyclebin.Size = new System.Drawing.Size(226, 18);
            this.chxNotesDeleteRecyclebin.TabIndex = 35;
            this.chxNotesDeleteRecyclebin.Text = "Move deleted notes to recycle bin.";
            this.chxNotesDeleteRecyclebin.UseCompatibleTextRendering = true;
            this.chxNotesDeleteRecyclebin.UseVisualStyleBackColor = true;
            // 
            // chxLoadPlugins
            // 
            this.chxLoadPlugins.AccessibleDescription = "Allow NoteFly to load plugins";
            this.chxLoadPlugins.AutoSize = true;
            this.chxLoadPlugins.Checked = true;
            this.chxLoadPlugins.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel5.SetColumnSpan(this.chxLoadPlugins, 2);
            this.chxLoadPlugins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxLoadPlugins.Location = new System.Drawing.Point(3, 99);
            this.chxLoadPlugins.Name = "chxLoadPlugins";
            this.chxLoadPlugins.Size = new System.Drawing.Size(146, 18);
            this.chxLoadPlugins.TabIndex = 25;
            this.chxLoadPlugins.Text = "Allow to load plugins";
            this.chxLoadPlugins.UseCompatibleTextRendering = true;
            this.chxLoadPlugins.UseVisualStyleBackColor = true;
            // 
            // lblTextActionLeftClicktTrayicon
            // 
            this.lblTextActionLeftClicktTrayicon.AutoSize = true;
            this.lblTextActionLeftClicktTrayicon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextActionLeftClicktTrayicon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextActionLeftClicktTrayicon.Location = new System.Drawing.Point(3, 145);
            this.lblTextActionLeftClicktTrayicon.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextActionLeftClicktTrayicon.Name = "lblTextActionLeftClicktTrayicon";
            this.lblTextActionLeftClicktTrayicon.Size = new System.Drawing.Size(148, 20);
            this.lblTextActionLeftClicktTrayicon.TabIndex = 15;
            this.lblTextActionLeftClicktTrayicon.Text = "Action left click trayicon:";
            this.lblTextActionLeftClicktTrayicon.UseCompatibleTextRendering = true;
            // 
            // chxConfirmDeletenote
            // 
            this.chxConfirmDeletenote.AutoSize = true;
            this.chxConfirmDeletenote.Checked = true;
            this.chxConfirmDeletenote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel5.SetColumnSpan(this.chxConfirmDeletenote, 2);
            this.chxConfirmDeletenote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxConfirmDeletenote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxConfirmDeletenote.Location = new System.Drawing.Point(3, 51);
            this.chxConfirmDeletenote.Name = "chxConfirmDeletenote";
            this.chxConfirmDeletenote.Size = new System.Drawing.Size(161, 18);
            this.chxConfirmDeletenote.TabIndex = 34;
            this.chxConfirmDeletenote.Text = "Confirm deleting notes.";
            this.chxConfirmDeletenote.UseCompatibleTextRendering = true;
            this.chxConfirmDeletenote.UseVisualStyleBackColor = true;
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Location = new System.Drawing.Point(157, 173);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(199, 24);
            this.cbxLanguage.TabIndex = 26;
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // chxStartOnLogin
            // 
            this.chxStartOnLogin.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chxStartOnLogin, 2);
            this.chxStartOnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxStartOnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxStartOnLogin.Location = new System.Drawing.Point(3, 3);
            this.chxStartOnLogin.Name = "chxStartOnLogin";
            this.chxStartOnLogin.Size = new System.Drawing.Size(111, 18);
            this.chxStartOnLogin.TabIndex = 31;
            this.chxStartOnLogin.Text = "Start on logon.";
            this.chxStartOnLogin.UseCompatibleTextRendering = true;
            this.chxStartOnLogin.UseVisualStyleBackColor = true;
            // 
            // lblTextLanguage
            // 
            this.lblTextLanguage.AutoSize = true;
            this.lblTextLanguage.Location = new System.Drawing.Point(3, 175);
            this.lblTextLanguage.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextLanguage.Name = "lblTextLanguage";
            this.lblTextLanguage.Size = new System.Drawing.Size(145, 16);
            this.lblTextLanguage.TabIndex = 27;
            this.lblTextLanguage.Text = "Language programme:";
            // 
            // chxConfirmExit
            // 
            this.chxConfirmExit.AutoSize = true;
            this.tableLayoutPanel5.SetColumnSpan(this.chxConfirmExit, 2);
            this.chxConfirmExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxConfirmExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxConfirmExit.Location = new System.Drawing.Point(3, 27);
            this.chxConfirmExit.Name = "chxConfirmExit";
            this.chxConfirmExit.Size = new System.Drawing.Size(173, 18);
            this.chxConfirmExit.TabIndex = 32;
            this.chxConfirmExit.Text = "Ask to confirm shutdown.";
            this.chxConfirmExit.UseCompatibleTextRendering = true;
            this.chxConfirmExit.UseVisualStyleBackColor = true;
            // 
            // cbxActionLeftclick
            // 
            this.cbxActionLeftclick.AutoCompleteCustomSource.AddRange(new string[] {
            "Bring all notes to front.",
            "Create a new note.",
            "Show manage notes.",
            "Do nothing."});
            this.cbxActionLeftclick.CausesValidation = false;
            this.cbxActionLeftclick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxActionLeftclick.FormattingEnabled = true;
            this.cbxActionLeftclick.Location = new System.Drawing.Point(157, 143);
            this.cbxActionLeftclick.Name = "cbxActionLeftclick";
            this.cbxActionLeftclick.Size = new System.Drawing.Size(199, 24);
            this.cbxActionLeftclick.TabIndex = 16;
            // 
            // tabHotkeys
            // 
            this.tabHotkeys.Controls.Add(this.tableLayoutPanelShortcuts);
            this.tabHotkeys.Location = new System.Drawing.Point(4, 25);
            this.tabHotkeys.Name = "tabHotkeys";
            this.tabHotkeys.Padding = new System.Windows.Forms.Padding(3);
            this.tabHotkeys.Size = new System.Drawing.Size(468, 337);
            this.tabHotkeys.TabIndex = 6;
            this.tabHotkeys.Text = "Hotkeys";
            this.tabHotkeys.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelShortcuts
            // 
            this.tableLayoutPanelShortcuts.ColumnCount = 3;
            this.tableLayoutPanelShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanelShortcuts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelShortcuts.Controls.Add(this.shortcutTextBoxNotesToFront, 1, 2);
            this.tableLayoutPanelShortcuts.Controls.Add(this.lblTextHotkeyNotesToFront, 0, 2);
            this.tableLayoutPanelShortcuts.Controls.Add(this.shortcutTextBoxManageNotes, 1, 1);
            this.tableLayoutPanelShortcuts.Controls.Add(this.lblTextHotkeyNewNote, 0, 0);
            this.tableLayoutPanelShortcuts.Controls.Add(this.lblTextHotkeyManageNotes, 0, 1);
            this.tableLayoutPanelShortcuts.Controls.Add(this.shortcutTextBoxNewNote, 1, 0);
            this.tableLayoutPanelShortcuts.Controls.Add(this.chxHotkeyNewNoteEnabled, 2, 0);
            this.tableLayoutPanelShortcuts.Controls.Add(this.chxHotkeyManageNotesEnabled, 2, 1);
            this.tableLayoutPanelShortcuts.Controls.Add(this.chxHotkeyNotesFrontEnabled, 2, 2);
            this.tableLayoutPanelShortcuts.Location = new System.Drawing.Point(20, 37);
            this.tableLayoutPanelShortcuts.Name = "tableLayoutPanelShortcuts";
            this.tableLayoutPanelShortcuts.RowCount = 3;
            this.tableLayoutPanelShortcuts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelShortcuts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelShortcuts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanelShortcuts.Size = new System.Drawing.Size(440, 88);
            this.tableLayoutPanelShortcuts.TabIndex = 16;
            // 
            // shortcutTextBoxNotesToFront
            // 
            this.shortcutTextBoxNotesToFront.BackColor = System.Drawing.Color.White;
            this.shortcutTextBoxNotesToFront.Location = new System.Drawing.Point(152, 61);
            this.shortcutTextBoxNotesToFront.Name = "shortcutTextBoxNotesToFront";
            this.shortcutTextBoxNotesToFront.ShortcutKeyposition = 112;
            this.shortcutTextBoxNotesToFront.Size = new System.Drawing.Size(202, 22);
            this.shortcutTextBoxNotesToFront.TabIndex = 14;
            this.shortcutTextBoxNotesToFront.Text = "CTRL + SHIFT + F1";
            this.shortcutTextBoxNotesToFront.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shortcutTextBoxNotesToFront.UseAltInsteadofShift = false;
            this.shortcutTextBoxNotesToFront.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ingore_hotkeys);
            this.shortcutTextBoxNotesToFront.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Allow_hotkeys);
            // 
            // lblTextHotkeyNotesToFront
            // 
            this.lblTextHotkeyNotesToFront.AutoSize = true;
            this.lblTextHotkeyNotesToFront.Location = new System.Drawing.Point(3, 63);
            this.lblTextHotkeyNotesToFront.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextHotkeyNotesToFront.Name = "lblTextHotkeyNotesToFront";
            this.lblTextHotkeyNotesToFront.Size = new System.Drawing.Size(132, 16);
            this.lblTextHotkeyNotesToFront.TabIndex = 13;
            this.lblTextHotkeyNotesToFront.Text = "Hotkey notes to front:";
            // 
            // shortcutTextBoxManageNotes
            // 
            this.shortcutTextBoxManageNotes.BackColor = System.Drawing.Color.White;
            this.shortcutTextBoxManageNotes.Location = new System.Drawing.Point(152, 32);
            this.shortcutTextBoxManageNotes.Name = "shortcutTextBoxManageNotes";
            this.shortcutTextBoxManageNotes.ShortcutKeyposition = 112;
            this.shortcutTextBoxManageNotes.Size = new System.Drawing.Size(202, 22);
            this.shortcutTextBoxManageNotes.TabIndex = 12;
            this.shortcutTextBoxManageNotes.Text = "CTRL + SHIFT + F1";
            this.shortcutTextBoxManageNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shortcutTextBoxManageNotes.UseAltInsteadofShift = false;
            this.shortcutTextBoxManageNotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ingore_hotkeys);
            this.shortcutTextBoxManageNotes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Allow_hotkeys);
            // 
            // lblTextHotkeyNewNote
            // 
            this.lblTextHotkeyNewNote.AutoSize = true;
            this.lblTextHotkeyNewNote.Location = new System.Drawing.Point(3, 5);
            this.lblTextHotkeyNewNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextHotkeyNewNote.Name = "lblTextHotkeyNewNote";
            this.lblTextHotkeyNewNote.Size = new System.Drawing.Size(110, 16);
            this.lblTextHotkeyNewNote.TabIndex = 9;
            this.lblTextHotkeyNewNote.Text = "Hotkey new note:";
            // 
            // lblTextHotkeyManageNotes
            // 
            this.lblTextHotkeyManageNotes.AutoSize = true;
            this.lblTextHotkeyManageNotes.Location = new System.Drawing.Point(3, 34);
            this.lblTextHotkeyManageNotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextHotkeyManageNotes.Name = "lblTextHotkeyManageNotes";
            this.lblTextHotkeyManageNotes.Size = new System.Drawing.Size(143, 16);
            this.lblTextHotkeyManageNotes.TabIndex = 10;
            this.lblTextHotkeyManageNotes.Text = "Hotkey manage notes:";
            // 
            // shortcutTextBoxNewNote
            // 
            this.shortcutTextBoxNewNote.BackColor = System.Drawing.Color.White;
            this.shortcutTextBoxNewNote.Location = new System.Drawing.Point(152, 3);
            this.shortcutTextBoxNewNote.Name = "shortcutTextBoxNewNote";
            this.shortcutTextBoxNewNote.ShortcutKeyposition = 112;
            this.shortcutTextBoxNewNote.Size = new System.Drawing.Size(202, 22);
            this.shortcutTextBoxNewNote.TabIndex = 11;
            this.shortcutTextBoxNewNote.Text = "CTRL + SHIFT + F1";
            this.shortcutTextBoxNewNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shortcutTextBoxNewNote.UseAltInsteadofShift = false;
            this.shortcutTextBoxNewNote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ingore_hotkeys);
            this.shortcutTextBoxNewNote.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Allow_hotkeys);
            // 
            // chxHotkeyNewNoteEnabled
            // 
            this.chxHotkeyNewNoteEnabled.AutoSize = true;
            this.chxHotkeyNewNoteEnabled.Checked = true;
            this.chxHotkeyNewNoteEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxHotkeyNewNoteEnabled.Location = new System.Drawing.Point(360, 3);
            this.chxHotkeyNewNoteEnabled.Name = "chxHotkeyNewNoteEnabled";
            this.chxHotkeyNewNoteEnabled.Size = new System.Drawing.Size(77, 20);
            this.chxHotkeyNewNoteEnabled.TabIndex = 15;
            this.chxHotkeyNewNoteEnabled.Text = "enabled";
            this.chxHotkeyNewNoteEnabled.UseVisualStyleBackColor = true;
            this.chxHotkeyNewNoteEnabled.CheckedChanged += new System.EventHandler(this.chxHotkeyNewNoteEnabled_CheckedChanged);
            // 
            // chxHotkeyManageNotesEnabled
            // 
            this.chxHotkeyManageNotesEnabled.AutoSize = true;
            this.chxHotkeyManageNotesEnabled.Checked = true;
            this.chxHotkeyManageNotesEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxHotkeyManageNotesEnabled.Location = new System.Drawing.Point(360, 32);
            this.chxHotkeyManageNotesEnabled.Name = "chxHotkeyManageNotesEnabled";
            this.chxHotkeyManageNotesEnabled.Size = new System.Drawing.Size(77, 20);
            this.chxHotkeyManageNotesEnabled.TabIndex = 16;
            this.chxHotkeyManageNotesEnabled.Text = "enabled";
            this.chxHotkeyManageNotesEnabled.UseVisualStyleBackColor = true;
            this.chxHotkeyManageNotesEnabled.CheckedChanged += new System.EventHandler(this.chxHotkeyManageNotesEnabled_CheckedChanged);
            // 
            // chxHotkeyNotesFrontEnabled
            // 
            this.chxHotkeyNotesFrontEnabled.AutoSize = true;
            this.chxHotkeyNotesFrontEnabled.Checked = true;
            this.chxHotkeyNotesFrontEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxHotkeyNotesFrontEnabled.Location = new System.Drawing.Point(360, 61);
            this.chxHotkeyNotesFrontEnabled.Name = "chxHotkeyNotesFrontEnabled";
            this.chxHotkeyNotesFrontEnabled.Size = new System.Drawing.Size(77, 20);
            this.chxHotkeyNotesFrontEnabled.TabIndex = 17;
            this.chxHotkeyNotesFrontEnabled.Text = "enabled";
            this.chxHotkeyNotesFrontEnabled.UseVisualStyleBackColor = true;
            this.chxHotkeyNotesFrontEnabled.CheckedChanged += new System.EventHandler(this.chxHotkeyNotesFrontEnabled_CheckedChanged);
            // 
            // tabAppearance
            // 
            this.tabAppearance.Controls.Add(this.tabctrlAppearance);
            this.tabAppearance.Location = new System.Drawing.Point(4, 25);
            this.tabAppearance.Name = "tabAppearance";
            this.tabAppearance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppearance.Size = new System.Drawing.Size(468, 337);
            this.tabAppearance.TabIndex = 0;
            this.tabAppearance.Text = "Appearance";
            this.tabAppearance.UseVisualStyleBackColor = true;
            // 
            // tabctrlAppearance
            // 
            this.tabctrlAppearance.Controls.Add(this.tabAppearanceOverall);
            this.tabctrlAppearance.Controls.Add(this.tabPageNewNote);
            this.tabctrlAppearance.Controls.Add(this.tabPageFonts);
            this.tabctrlAppearance.Controls.Add(this.tabPageTrayicon);
            this.tabctrlAppearance.Controls.Add(this.tabAppereanceManagenotes);
            this.tabctrlAppearance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlAppearance.ItemSize = new System.Drawing.Size(85, 21);
            this.tabctrlAppearance.Location = new System.Drawing.Point(3, 3);
            this.tabctrlAppearance.MinimumSize = new System.Drawing.Size(80, 21);
            this.tabctrlAppearance.Name = "tabctrlAppearance";
            this.tabctrlAppearance.SelectedIndex = 0;
            this.tabctrlAppearance.Size = new System.Drawing.Size(462, 331);
            this.tabctrlAppearance.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabctrlAppearance.TabIndex = 28;
            // 
            // tabAppearanceOverall
            // 
            this.tabAppearanceOverall.Controls.Add(this.tableLayoutPanel6);
            this.tabAppearanceOverall.Location = new System.Drawing.Point(4, 25);
            this.tabAppearanceOverall.Name = "tabAppearanceOverall";
            this.tabAppearanceOverall.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppearanceOverall.Size = new System.Drawing.Size(454, 302);
            this.tabAppearanceOverall.TabIndex = 0;
            this.tabAppearanceOverall.Text = "Overall";
            this.tabAppearanceOverall.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.chxTransparecy, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.chxShowTooltips, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.numProcTransparency, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.lblTextTransparentProcVisible, 2, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(13, 22);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(374, 62);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // chxTransparecy
            // 
            this.chxTransparecy.AutoSize = true;
            this.chxTransparecy.BackColor = System.Drawing.Color.Transparent;
            this.chxTransparecy.CausesValidation = false;
            this.chxTransparecy.Checked = true;
            this.chxTransparecy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxTransparecy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chxTransparecy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxTransparecy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxTransparecy.Location = new System.Drawing.Point(3, 3);
            this.chxTransparecy.Name = "chxTransparecy";
            this.chxTransparecy.Size = new System.Drawing.Size(160, 21);
            this.chxTransparecy.TabIndex = 8;
            this.chxTransparecy.Text = "Enable transparency:";
            this.chxTransparecy.UseCompatibleTextRendering = true;
            this.chxTransparecy.UseVisualStyleBackColor = false;
            this.chxTransparecy.CheckedChanged += new System.EventHandler(this.chxTransparecy_CheckedChanged);
            // 
            // chxShowTooltips
            // 
            this.chxShowTooltips.AutoSize = true;
            this.chxShowTooltips.Checked = true;
            this.chxShowTooltips.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel6.SetColumnSpan(this.chxShowTooltips, 3);
            this.chxShowTooltips.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxShowTooltips.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxShowTooltips.Location = new System.Drawing.Point(3, 34);
            this.chxShowTooltips.Name = "chxShowTooltips";
            this.chxShowTooltips.Size = new System.Drawing.Size(129, 21);
            this.chxShowTooltips.TabIndex = 13;
            this.chxShowTooltips.Text = "Show tooltip hints";
            this.chxShowTooltips.UseCompatibleTextRendering = true;
            this.chxShowTooltips.UseVisualStyleBackColor = true;
            this.chxShowTooltips.CheckStateChanged += new System.EventHandler(this.chxShowTooltips_CheckStateChanged);
            // 
            // numProcTransparency
            // 
            this.numProcTransparency.BackColor = System.Drawing.SystemColors.Window;
            this.numProcTransparency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numProcTransparency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numProcTransparency.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numProcTransparency.Location = new System.Drawing.Point(169, 3);
            this.numProcTransparency.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProcTransparency.Name = "numProcTransparency";
            this.numProcTransparency.Size = new System.Drawing.Size(46, 22);
            this.numProcTransparency.TabIndex = 11;
            this.numProcTransparency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numProcTransparency.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // lblTextTransparentProcVisible
            // 
            this.lblTextTransparentProcVisible.AutoSize = true;
            this.lblTextTransparentProcVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextTransparentProcVisible.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextTransparentProcVisible.Location = new System.Drawing.Point(221, 5);
            this.lblTextTransparentProcVisible.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextTransparentProcVisible.Name = "lblTextTransparentProcVisible";
            this.lblTextTransparentProcVisible.Size = new System.Drawing.Size(58, 20);
            this.lblTextTransparentProcVisible.TabIndex = 12;
            this.lblTextTransparentProcVisible.Text = "% visible";
            this.lblTextTransparentProcVisible.UseCompatibleTextRendering = true;
            // 
            // tabPageNewNote
            // 
            this.tabPageNewNote.Controls.Add(this.tableLayoutPanel4);
            this.tabPageNewNote.Controls.Add(this.tableLayoutPanelNewNote);
            this.tabPageNewNote.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewNote.Name = "tabPageNewNote";
            this.tabPageNewNote.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewNote.Size = new System.Drawing.Size(454, 302);
            this.tabPageNewNote.TabIndex = 3;
            this.tabPageNewNote.Text = "New note";
            this.tabPageNewNote.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.lblTextWidth, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTextHeight, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblTextDefaultsizenewnote, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.numNotesDefaultHeight, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.numNotesDefaultWidth, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 135);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.72727F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.27273F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(414, 79);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // lblTextWidth
            // 
            this.lblTextWidth.AutoSize = true;
            this.lblTextWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextWidth.Location = new System.Drawing.Point(3, 29);
            this.lblTextWidth.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextWidth.Name = "lblTextWidth";
            this.lblTextWidth.Size = new System.Drawing.Size(43, 20);
            this.lblTextWidth.TabIndex = 21;
            this.lblTextWidth.Text = "Width:";
            this.lblTextWidth.UseCompatibleTextRendering = true;
            // 
            // lblTextHeight
            // 
            this.lblTextHeight.AutoSize = true;
            this.lblTextHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextHeight.Location = new System.Drawing.Point(3, 56);
            this.lblTextHeight.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextHeight.Name = "lblTextHeight";
            this.lblTextHeight.Size = new System.Drawing.Size(47, 20);
            this.lblTextHeight.TabIndex = 22;
            this.lblTextHeight.Text = "Height:";
            this.lblTextHeight.UseCompatibleTextRendering = true;
            // 
            // lblTextDefaultsizenewnote
            // 
            this.lblTextDefaultsizenewnote.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.lblTextDefaultsizenewnote, 2);
            this.lblTextDefaultsizenewnote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextDefaultsizenewnote.Location = new System.Drawing.Point(3, 0);
            this.lblTextDefaultsizenewnote.Name = "lblTextDefaultsizenewnote";
            this.lblTextDefaultsizenewnote.Size = new System.Drawing.Size(136, 20);
            this.lblTextDefaultsizenewnote.TabIndex = 18;
            this.lblTextDefaultsizenewnote.Text = "Default size new note:";
            this.lblTextDefaultsizenewnote.UseCompatibleTextRendering = true;
            // 
            // numNotesDefaultHeight
            // 
            this.numNotesDefaultHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNotesDefaultHeight.Location = new System.Drawing.Point(56, 54);
            this.numNotesDefaultHeight.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.numNotesDefaultHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNotesDefaultHeight.Name = "numNotesDefaultHeight";
            this.numNotesDefaultHeight.Size = new System.Drawing.Size(55, 22);
            this.numNotesDefaultHeight.TabIndex = 20;
            this.numNotesDefaultHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNotesDefaultHeight.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // numNotesDefaultWidth
            // 
            this.numNotesDefaultWidth.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNotesDefaultWidth.Location = new System.Drawing.Point(56, 27);
            this.numNotesDefaultWidth.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numNotesDefaultWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numNotesDefaultWidth.Name = "numNotesDefaultWidth";
            this.numNotesDefaultWidth.Size = new System.Drawing.Size(55, 22);
            this.numNotesDefaultWidth.TabIndex = 19;
            this.numNotesDefaultWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNotesDefaultWidth.Value = new decimal(new int[] {
            420,
            0,
            0,
            0});
            // 
            // tableLayoutPanelNewNote
            // 
            this.tableLayoutPanelNewNote.ColumnCount = 3;
            this.tableLayoutPanelNewNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNewNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNewNote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNewNote.Controls.Add(this.chxUseRandomDefaultNote, 0, 0);
            this.tableLayoutPanelNewNote.Controls.Add(this.lblDefaultNewNoteColor, 0, 1);
            this.tableLayoutPanelNewNote.Controls.Add(this.cbxDefaultSkin, 2, 1);
            this.tableLayoutPanelNewNote.Controls.Add(this.chxUseDateAsDefaultTitle, 0, 2);
            this.tableLayoutPanelNewNote.Location = new System.Drawing.Point(13, 15);
            this.tableLayoutPanelNewNote.Name = "tableLayoutPanelNewNote";
            this.tableLayoutPanelNewNote.RowCount = 3;
            this.tableLayoutPanelNewNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.58823F));
            this.tableLayoutPanelNewNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.41177F));
            this.tableLayoutPanelNewNote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelNewNote.Size = new System.Drawing.Size(414, 84);
            this.tableLayoutPanelNewNote.TabIndex = 24;
            // 
            // chxUseRandomDefaultNote
            // 
            this.chxUseRandomDefaultNote.AutoSize = true;
            this.tableLayoutPanelNewNote.SetColumnSpan(this.chxUseRandomDefaultNote, 3);
            this.chxUseRandomDefaultNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxUseRandomDefaultNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxUseRandomDefaultNote.Location = new System.Drawing.Point(3, 3);
            this.chxUseRandomDefaultNote.Name = "chxUseRandomDefaultNote";
            this.chxUseRandomDefaultNote.Size = new System.Drawing.Size(228, 19);
            this.chxUseRandomDefaultNote.TabIndex = 17;
            this.chxUseRandomDefaultNote.Text = "Use a random skin as default skin.";
            this.chxUseRandomDefaultNote.UseCompatibleTextRendering = true;
            this.chxUseRandomDefaultNote.UseVisualStyleBackColor = true;
            this.chxUseRandomDefaultNote.CheckedChanged += new System.EventHandler(this.chxUseRandomDefaultNote_CheckedChanged);
            // 
            // lblDefaultNewNoteColor
            // 
            this.lblDefaultNewNoteColor.AutoSize = true;
            this.tableLayoutPanelNewNote.SetColumnSpan(this.lblDefaultNewNoteColor, 2);
            this.lblDefaultNewNoteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblDefaultNewNoteColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDefaultNewNoteColor.Location = new System.Drawing.Point(3, 30);
            this.lblDefaultNewNoteColor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblDefaultNewNoteColor.Name = "lblDefaultNewNoteColor";
            this.lblDefaultNewNoteColor.Size = new System.Drawing.Size(143, 20);
            this.lblDefaultNewNoteColor.TabIndex = 15;
            this.lblDefaultNewNoteColor.Text = "Default skin new notes:";
            this.lblDefaultNewNoteColor.UseCompatibleTextRendering = true;
            // 
            // cbxDefaultSkin
            // 
            this.cbxDefaultSkin.AccessibleDescription = "Defaul color for new note.";
            this.cbxDefaultSkin.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cbxDefaultSkin.BackColor = System.Drawing.Color.LightGray;
            this.cbxDefaultSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDefaultSkin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxDefaultSkin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbxDefaultSkin.FormattingEnabled = true;
            this.cbxDefaultSkin.Location = new System.Drawing.Point(152, 28);
            this.cbxDefaultSkin.MaxDropDownItems = 5;
            this.cbxDefaultSkin.Name = "cbxDefaultSkin";
            this.cbxDefaultSkin.Size = new System.Drawing.Size(158, 24);
            this.cbxDefaultSkin.TabIndex = 16;
            // 
            // chxUseDateAsDefaultTitle
            // 
            this.chxUseDateAsDefaultTitle.AutoSize = true;
            this.chxUseDateAsDefaultTitle.Checked = true;
            this.chxUseDateAsDefaultTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanelNewNote.SetColumnSpan(this.chxUseDateAsDefaultTitle, 3);
            this.chxUseDateAsDefaultTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxUseDateAsDefaultTitle.Location = new System.Drawing.Point(3, 59);
            this.chxUseDateAsDefaultTitle.Name = "chxUseDateAsDefaultTitle";
            this.chxUseDateAsDefaultTitle.Size = new System.Drawing.Size(297, 20);
            this.chxUseDateAsDefaultTitle.TabIndex = 23;
            this.chxUseDateAsDefaultTitle.Text = "Use current date as default title for a new note.";
            this.chxUseDateAsDefaultTitle.UseVisualStyleBackColor = true;
            // 
            // tabPageFonts
            // 
            this.tabPageFonts.Controls.Add(this.tableLayoutPanelNotes);
            this.tabPageFonts.Location = new System.Drawing.Point(4, 25);
            this.tabPageFonts.Name = "tabPageFonts";
            this.tabPageFonts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFonts.Size = new System.Drawing.Size(454, 302);
            this.tabPageFonts.TabIndex = 1;
            this.tabPageFonts.Text = "Notes";
            this.tabPageFonts.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelNotes
            // 
            this.tableLayoutPanelNotes.ColumnCount = 4;
            this.tableLayoutPanelNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextFontContentPoints, 2, 4);
            this.tableLayoutPanelNotes.Controls.Add(this.numFontSizeContent, 1, 4);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextFontContentSize, 0, 4);
            this.tableLayoutPanelNotes.Controls.Add(this.cbxFontNoteContent, 1, 3);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextNoteFont, 0, 3);
            this.tableLayoutPanelNotes.Controls.Add(this.cbxFontNoteTitleBold, 3, 1);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextFontTitlePoints, 2, 1);
            this.tableLayoutPanelNotes.Controls.Add(this.numFontSizeTitle, 1, 1);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextFontTitleSize, 0, 1);
            this.tableLayoutPanelNotes.Controls.Add(this.cbxFontNoteTitle, 1, 0);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextFontTitleFamily, 0, 0);
            this.tableLayoutPanelNotes.Controls.Add(this.lblTextDirection, 0, 6);
            this.tableLayoutPanelNotes.Controls.Add(this.cbxTextDirection, 1, 6);
            this.tableLayoutPanelNotes.Location = new System.Drawing.Point(13, 16);
            this.tableLayoutPanelNotes.Name = "tableLayoutPanelNotes";
            this.tableLayoutPanelNotes.RowCount = 7;
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanelNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanelNotes.Size = new System.Drawing.Size(411, 217);
            this.tableLayoutPanelNotes.TabIndex = 43;
            // 
            // lblTextFontContentPoints
            // 
            this.lblTextFontContentPoints.AccessibleDescription = "points";
            this.lblTextFontContentPoints.AutoSize = true;
            this.lblTextFontContentPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontContentPoints.Location = new System.Drawing.Point(193, 116);
            this.lblTextFontContentPoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontContentPoints.Name = "lblTextFontContentPoints";
            this.lblTextFontContentPoints.Size = new System.Drawing.Size(20, 20);
            this.lblTextFontContentPoints.TabIndex = 32;
            this.lblTextFontContentPoints.Text = "pt.";
            this.lblTextFontContentPoints.UseCompatibleTextRendering = true;
            // 
            // numFontSizeContent
            // 
            this.numFontSizeContent.AccessibleDescription = "fontsize note content";
            this.numFontSizeContent.Location = new System.Drawing.Point(149, 114);
            this.numFontSizeContent.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numFontSizeContent.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numFontSizeContent.Name = "numFontSizeContent";
            this.numFontSizeContent.Size = new System.Drawing.Size(38, 22);
            this.numFontSizeContent.TabIndex = 31;
            this.numFontSizeContent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSizeContent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblTextFontContentSize
            // 
            this.lblTextFontContentSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFontContentSize.AutoSize = true;
            this.lblTextFontContentSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontContentSize.Location = new System.Drawing.Point(3, 116);
            this.lblTextFontContentSize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontContentSize.Name = "lblTextFontContentSize";
            this.lblTextFontContentSize.Size = new System.Drawing.Size(140, 20);
            this.lblTextFontContentSize.TabIndex = 30;
            this.lblTextFontContentSize.Text = "Font size note content:";
            this.lblTextFontContentSize.UseCompatibleTextRendering = true;
            // 
            // cbxFontNoteContent
            // 
            this.cbxFontNoteContent.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.tableLayoutPanelNotes.SetColumnSpan(this.cbxFontNoteContent, 3);
            this.cbxFontNoteContent.DropDownHeight = 140;
            this.cbxFontNoteContent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontNoteContent.IntegralHeight = false;
            this.cbxFontNoteContent.Location = new System.Drawing.Point(149, 82);
            this.cbxFontNoteContent.Name = "cbxFontNoteContent";
            this.cbxFontNoteContent.Size = new System.Drawing.Size(223, 24);
            this.cbxFontNoteContent.TabIndex = 28;
            // 
            // lblTextNoteFont
            // 
            this.lblTextNoteFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextNoteFont.AutoSize = true;
            this.lblTextNoteFont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextNoteFont.Location = new System.Drawing.Point(31, 84);
            this.lblTextNoteFont.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextNoteFont.Name = "lblTextNoteFont";
            this.lblTextNoteFont.Size = new System.Drawing.Size(112, 20);
            this.lblTextNoteFont.TabIndex = 29;
            this.lblTextNoteFont.Text = "Font note content:";
            this.lblTextNoteFont.UseCompatibleTextRendering = true;
            // 
            // cbxFontNoteTitleBold
            // 
            this.cbxFontNoteTitleBold.AutoSize = true;
            this.cbxFontNoteTitleBold.Checked = true;
            this.cbxFontNoteTitleBold.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFontNoteTitleBold.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxFontNoteTitleBold.Location = new System.Drawing.Point(219, 36);
            this.cbxFontNoteTitleBold.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.cbxFontNoteTitleBold.Name = "cbxFontNoteTitleBold";
            this.cbxFontNoteTitleBold.Size = new System.Drawing.Size(49, 20);
            this.cbxFontNoteTitleBold.TabIndex = 40;
            this.cbxFontNoteTitleBold.Text = "bold";
            this.cbxFontNoteTitleBold.UseCompatibleTextRendering = true;
            this.cbxFontNoteTitleBold.UseVisualStyleBackColor = true;
            // 
            // lblTextFontTitlePoints
            // 
            this.lblTextFontTitlePoints.AccessibleDescription = "points";
            this.lblTextFontTitlePoints.AutoSize = true;
            this.lblTextFontTitlePoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontTitlePoints.Location = new System.Drawing.Point(193, 36);
            this.lblTextFontTitlePoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontTitlePoints.Name = "lblTextFontTitlePoints";
            this.lblTextFontTitlePoints.Size = new System.Drawing.Size(20, 20);
            this.lblTextFontTitlePoints.TabIndex = 39;
            this.lblTextFontTitlePoints.Text = "pt.";
            this.lblTextFontTitlePoints.UseCompatibleTextRendering = true;
            // 
            // numFontSizeTitle
            // 
            this.numFontSizeTitle.AccessibleDescription = "fontsize note title";
            this.numFontSizeTitle.Location = new System.Drawing.Point(149, 34);
            this.numFontSizeTitle.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numFontSizeTitle.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFontSizeTitle.Name = "numFontSizeTitle";
            this.numFontSizeTitle.Size = new System.Drawing.Size(38, 22);
            this.numFontSizeTitle.TabIndex = 38;
            this.numFontSizeTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFontSizeTitle.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // lblTextFontTitleSize
            // 
            this.lblTextFontTitleSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFontTitleSize.AutoSize = true;
            this.lblTextFontTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontTitleSize.Location = new System.Drawing.Point(26, 36);
            this.lblTextFontTitleSize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontTitleSize.Name = "lblTextFontTitleSize";
            this.lblTextFontTitleSize.Size = new System.Drawing.Size(117, 20);
            this.lblTextFontTitleSize.TabIndex = 37;
            this.lblTextFontTitleSize.Text = "Font size note title:";
            this.lblTextFontTitleSize.UseCompatibleTextRendering = true;
            // 
            // cbxFontNoteTitle
            // 
            this.cbxFontNoteTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.tableLayoutPanelNotes.SetColumnSpan(this.cbxFontNoteTitle, 3);
            this.cbxFontNoteTitle.DropDownHeight = 140;
            this.cbxFontNoteTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontNoteTitle.IntegralHeight = false;
            this.cbxFontNoteTitle.Location = new System.Drawing.Point(149, 3);
            this.cbxFontNoteTitle.Name = "cbxFontNoteTitle";
            this.cbxFontNoteTitle.Size = new System.Drawing.Size(223, 24);
            this.cbxFontNoteTitle.TabIndex = 36;
            // 
            // lblTextFontTitleFamily
            // 
            this.lblTextFontTitleFamily.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFontTitleFamily.AutoSize = true;
            this.lblTextFontTitleFamily.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontTitleFamily.Location = new System.Drawing.Point(53, 5);
            this.lblTextFontTitleFamily.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontTitleFamily.Name = "lblTextFontTitleFamily";
            this.lblTextFontTitleFamily.Size = new System.Drawing.Size(90, 20);
            this.lblTextFontTitleFamily.TabIndex = 35;
            this.lblTextFontTitleFamily.Text = "Font note title:";
            this.lblTextFontTitleFamily.UseCompatibleTextRendering = true;
            // 
            // lblTextDirection
            // 
            this.lblTextDirection.AccessibleDescription = "";
            this.lblTextDirection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextDirection.AutoSize = true;
            this.lblTextDirection.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextDirection.Location = new System.Drawing.Point(18, 187);
            this.lblTextDirection.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextDirection.Name = "lblTextDirection";
            this.lblTextDirection.Size = new System.Drawing.Size(125, 20);
            this.lblTextDirection.TabIndex = 34;
            this.lblTextDirection.Text = "Text direction notes:";
            this.lblTextDirection.UseCompatibleTextRendering = true;
            // 
            // cbxTextDirection
            // 
            this.cbxTextDirection.AccessibleDescription = "Text direction";
            this.cbxTextDirection.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.cbxTextDirection.CausesValidation = false;
            this.tableLayoutPanelNotes.SetColumnSpan(this.cbxTextDirection, 3);
            this.cbxTextDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTextDirection.FormattingEnabled = true;
            this.cbxTextDirection.Items.AddRange(new object[] {
            "Left to right",
            "Right to left"});
            this.cbxTextDirection.Location = new System.Drawing.Point(149, 185);
            this.cbxTextDirection.Name = "cbxTextDirection";
            this.cbxTextDirection.Size = new System.Drawing.Size(223, 24);
            this.cbxTextDirection.TabIndex = 33;
            // 
            // tabPageTrayicon
            // 
            this.tabPageTrayicon.Controls.Add(this.tableLayoutPanelTrayicon);
            this.tabPageTrayicon.Controls.Add(this.chxUseAlternativeTrayicon);
            this.tabPageTrayicon.Controls.Add(this.chxTrayiconBoldExit);
            this.tabPageTrayicon.Controls.Add(this.chxTrayiconBoldSettings);
            this.tabPageTrayicon.Controls.Add(this.chxTrayiconBoldManagenotes);
            this.tabPageTrayicon.Controls.Add(this.chxTrayiconBoldNewnote);
            this.tabPageTrayicon.Location = new System.Drawing.Point(4, 25);
            this.tabPageTrayicon.Name = "tabPageTrayicon";
            this.tabPageTrayicon.Size = new System.Drawing.Size(454, 302);
            this.tabPageTrayicon.TabIndex = 2;
            this.tabPageTrayicon.Text = "Trayicon";
            this.tabPageTrayicon.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelTrayicon
            // 
            this.tableLayoutPanelTrayicon.ColumnCount = 3;
            this.tableLayoutPanelTrayicon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTrayicon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTrayicon.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTrayicon.Controls.Add(this.lblTextTrayiconFont, 0, 1);
            this.tableLayoutPanelTrayicon.Controls.Add(this.lblTextFontsizeMenu, 0, 0);
            this.tableLayoutPanelTrayicon.Controls.Add(this.numTrayiconFontsize, 1, 0);
            this.tableLayoutPanelTrayicon.Controls.Add(this.lblFontsizePoints, 2, 0);
            this.tableLayoutPanelTrayicon.Controls.Add(this.cbxFontTrayicon, 1, 1);
            this.tableLayoutPanelTrayicon.Location = new System.Drawing.Point(13, 29);
            this.tableLayoutPanelTrayicon.Name = "tableLayoutPanelTrayicon";
            this.tableLayoutPanelTrayicon.RowCount = 2;
            this.tableLayoutPanelTrayicon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTrayicon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelTrayicon.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelTrayicon.Size = new System.Drawing.Size(403, 64);
            this.tableLayoutPanelTrayicon.TabIndex = 8;
            // 
            // lblTextTrayiconFont
            // 
            this.lblTextTrayiconFont.AutoSize = true;
            this.lblTextTrayiconFont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextTrayiconFont.Location = new System.Drawing.Point(3, 37);
            this.lblTextTrayiconFont.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextTrayiconFont.Name = "lblTextTrayiconFont";
            this.lblTextTrayiconFont.Size = new System.Drawing.Size(123, 20);
            this.lblTextTrayiconFont.TabIndex = 9;
            this.lblTextTrayiconFont.Text = "Trayicon menu font:";
            this.lblTextTrayiconFont.UseCompatibleTextRendering = true;
            // 
            // lblTextFontsizeMenu
            // 
            this.lblTextFontsizeMenu.AutoSize = true;
            this.lblTextFontsizeMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextFontsizeMenu.Location = new System.Drawing.Point(3, 5);
            this.lblTextFontsizeMenu.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextFontsizeMenu.Name = "lblTextFontsizeMenu";
            this.lblTextFontsizeMenu.Size = new System.Drawing.Size(150, 20);
            this.lblTextFontsizeMenu.TabIndex = 5;
            this.lblTextFontsizeMenu.Text = "Trayicon menu font size:";
            this.lblTextFontsizeMenu.UseCompatibleTextRendering = true;
            // 
            // numTrayiconFontsize
            // 
            this.numTrayiconFontsize.AccessibleDescription = "Fontsize trayicon";
            this.numTrayiconFontsize.Location = new System.Drawing.Point(159, 3);
            this.numTrayiconFontsize.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.numTrayiconFontsize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numTrayiconFontsize.Name = "numTrayiconFontsize";
            this.numTrayiconFontsize.Size = new System.Drawing.Size(45, 22);
            this.numTrayiconFontsize.TabIndex = 4;
            this.numTrayiconFontsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTrayiconFontsize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // lblFontsizePoints
            // 
            this.lblFontsizePoints.AutoSize = true;
            this.lblFontsizePoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFontsizePoints.Location = new System.Drawing.Point(210, 5);
            this.lblFontsizePoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblFontsizePoints.Name = "lblFontsizePoints";
            this.lblFontsizePoints.Size = new System.Drawing.Size(20, 20);
            this.lblFontsizePoints.TabIndex = 6;
            this.lblFontsizePoints.Text = "pt.";
            this.lblFontsizePoints.UseCompatibleTextRendering = true;
            // 
            // cbxFontTrayicon
            // 
            this.cbxFontTrayicon.AccessibleDescription = "trayicon font";
            this.cbxFontTrayicon.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.tableLayoutPanelTrayicon.SetColumnSpan(this.cbxFontTrayicon, 2);
            this.cbxFontTrayicon.DropDownHeight = 140;
            this.cbxFontTrayicon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontTrayicon.IntegralHeight = false;
            this.cbxFontTrayicon.Location = new System.Drawing.Point(159, 35);
            this.cbxFontTrayicon.Name = "cbxFontTrayicon";
            this.cbxFontTrayicon.Size = new System.Drawing.Size(181, 24);
            this.cbxFontTrayicon.TabIndex = 37;
            // 
            // chxUseAlternativeTrayicon
            // 
            this.chxUseAlternativeTrayicon.AutoSize = true;
            this.chxUseAlternativeTrayicon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxUseAlternativeTrayicon.Location = new System.Drawing.Point(17, 215);
            this.chxUseAlternativeTrayicon.Name = "chxUseAlternativeTrayicon";
            this.chxUseAlternativeTrayicon.Size = new System.Drawing.Size(202, 21);
            this.chxUseAlternativeTrayicon.TabIndex = 7;
            this.chxUseAlternativeTrayicon.Text = "Use alternative white trayicon.";
            this.chxUseAlternativeTrayicon.UseCompatibleTextRendering = true;
            this.chxUseAlternativeTrayicon.UseVisualStyleBackColor = true;
            // 
            // chxTrayiconBoldExit
            // 
            this.chxTrayiconBoldExit.AutoSize = true;
            this.chxTrayiconBoldExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxTrayiconBoldExit.Location = new System.Drawing.Point(17, 177);
            this.chxTrayiconBoldExit.Name = "chxTrayiconBoldExit";
            this.chxTrayiconBoldExit.Size = new System.Drawing.Size(150, 21);
            this.chxTrayiconBoldExit.TabIndex = 3;
            this.chxTrayiconBoldExit.Text = "Display \"Exit\" in bold.";
            this.chxTrayiconBoldExit.UseCompatibleTextRendering = true;
            this.chxTrayiconBoldExit.UseVisualStyleBackColor = true;
            // 
            // chxTrayiconBoldSettings
            // 
            this.chxTrayiconBoldSettings.AutoSize = true;
            this.chxTrayiconBoldSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxTrayiconBoldSettings.Location = new System.Drawing.Point(16, 154);
            this.chxTrayiconBoldSettings.Name = "chxTrayiconBoldSettings";
            this.chxTrayiconBoldSettings.Size = new System.Drawing.Size(176, 21);
            this.chxTrayiconBoldSettings.TabIndex = 2;
            this.chxTrayiconBoldSettings.Text = "Display \"Settings\" in bold.";
            this.chxTrayiconBoldSettings.UseCompatibleTextRendering = true;
            this.chxTrayiconBoldSettings.UseVisualStyleBackColor = true;
            // 
            // chxTrayiconBoldManagenotes
            // 
            this.chxTrayiconBoldManagenotes.AutoSize = true;
            this.chxTrayiconBoldManagenotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxTrayiconBoldManagenotes.Location = new System.Drawing.Point(16, 131);
            this.chxTrayiconBoldManagenotes.Name = "chxTrayiconBoldManagenotes";
            this.chxTrayiconBoldManagenotes.Size = new System.Drawing.Size(212, 21);
            this.chxTrayiconBoldManagenotes.TabIndex = 1;
            this.chxTrayiconBoldManagenotes.Text = "Display \"Manage notes\" in bold.";
            this.chxTrayiconBoldManagenotes.UseCompatibleTextRendering = true;
            this.chxTrayiconBoldManagenotes.UseVisualStyleBackColor = true;
            // 
            // chxTrayiconBoldNewnote
            // 
            this.chxTrayiconBoldNewnote.AutoSize = true;
            this.chxTrayiconBoldNewnote.Checked = true;
            this.chxTrayiconBoldNewnote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxTrayiconBoldNewnote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxTrayiconBoldNewnote.Location = new System.Drawing.Point(16, 108);
            this.chxTrayiconBoldNewnote.Name = "chxTrayiconBoldNewnote";
            this.chxTrayiconBoldNewnote.Size = new System.Drawing.Size(184, 21);
            this.chxTrayiconBoldNewnote.TabIndex = 0;
            this.chxTrayiconBoldNewnote.Text = "Display \"New note\" in bold.";
            this.chxTrayiconBoldNewnote.UseCompatibleTextRendering = true;
            this.chxTrayiconBoldNewnote.UseVisualStyleBackColor = true;
            // 
            // tabAppereanceManagenotes
            // 
            this.tabAppereanceManagenotes.Controls.Add(this.tableLayoutPanel3);
            this.tabAppereanceManagenotes.Controls.Add(this.chxCaseSentiveSearch);
            this.tabAppereanceManagenotes.Controls.Add(this.chxManagenotesTooltipContent);
            this.tabAppereanceManagenotes.Location = new System.Drawing.Point(4, 25);
            this.tabAppereanceManagenotes.Name = "tabAppereanceManagenotes";
            this.tabAppereanceManagenotes.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppereanceManagenotes.Size = new System.Drawing.Size(454, 302);
            this.tabAppereanceManagenotes.TabIndex = 4;
            this.tabAppereanceManagenotes.Text = "Manage notes";
            this.tabAppereanceManagenotes.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.lbTextManagesnotesFontSize, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTextSkinManagenotes, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbxManageNotesSkin, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.numManagenotesFont, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTextPoints, 2, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(19, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 64);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // lbTextManagesnotesFontSize
            // 
            this.lbTextManagesnotesFontSize.AutoSize = true;
            this.lbTextManagesnotesFontSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTextManagesnotesFontSize.Location = new System.Drawing.Point(3, 5);
            this.lbTextManagesnotesFontSize.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lbTextManagesnotesFontSize.Name = "lbTextManagesnotesFontSize";
            this.lbTextManagesnotesFontSize.Size = new System.Drawing.Size(148, 16);
            this.lbTextManagesnotesFontSize.TabIndex = 3;
            this.lbTextManagesnotesFontSize.Text = "Manage notes font size:";
            // 
            // lblTextSkinManagenotes
            // 
            this.lblTextSkinManagenotes.AutoSize = true;
            this.lblTextSkinManagenotes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextSkinManagenotes.Location = new System.Drawing.Point(3, 33);
            this.lblTextSkinManagenotes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextSkinManagenotes.Name = "lblTextSkinManagenotes";
            this.lblTextSkinManagenotes.Size = new System.Drawing.Size(121, 20);
            this.lblTextSkinManagenotes.TabIndex = 2;
            this.lblTextSkinManagenotes.Text = "Manage notes skin:";
            this.lblTextSkinManagenotes.UseCompatibleTextRendering = true;
            // 
            // cbxManageNotesSkin
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cbxManageNotesSkin, 2);
            this.cbxManageNotesSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxManageNotesSkin.FormattingEnabled = true;
            this.cbxManageNotesSkin.Location = new System.Drawing.Point(157, 31);
            this.cbxManageNotesSkin.Name = "cbxManageNotesSkin";
            this.cbxManageNotesSkin.Size = new System.Drawing.Size(172, 24);
            this.cbxManageNotesSkin.TabIndex = 1;
            // 
            // numManagenotesFont
            // 
            this.numManagenotesFont.Location = new System.Drawing.Point(157, 3);
            this.numManagenotesFont.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numManagenotesFont.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numManagenotesFont.Name = "numManagenotesFont";
            this.numManagenotesFont.Size = new System.Drawing.Size(45, 22);
            this.numManagenotesFont.TabIndex = 4;
            this.numManagenotesFont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numManagenotesFont.Value = new decimal(new int[] {
            1000,
            0,
            0,
            131072});
            // 
            // lblTextPoints
            // 
            this.lblTextPoints.AutoSize = true;
            this.lblTextPoints.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextPoints.Location = new System.Drawing.Point(208, 5);
            this.lblTextPoints.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextPoints.Name = "lblTextPoints";
            this.lblTextPoints.Size = new System.Drawing.Size(22, 16);
            this.lblTextPoints.TabIndex = 5;
            this.lblTextPoints.Text = "pt.";
            // 
            // chxCaseSentiveSearch
            // 
            this.chxCaseSentiveSearch.AutoSize = true;
            this.chxCaseSentiveSearch.Checked = true;
            this.chxCaseSentiveSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxCaseSentiveSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxCaseSentiveSearch.Location = new System.Drawing.Point(19, 170);
            this.chxCaseSentiveSearch.Name = "chxCaseSentiveSearch";
            this.chxCaseSentiveSearch.Size = new System.Drawing.Size(188, 20);
            this.chxCaseSentiveSearch.TabIndex = 6;
            this.chxCaseSentiveSearch.Text = "Use case sensitive search.";
            this.chxCaseSentiveSearch.UseVisualStyleBackColor = true;
            // 
            // chxManagenotesTooltipContent
            // 
            this.chxManagenotesTooltipContent.AutoSize = true;
            this.chxManagenotesTooltipContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxManagenotesTooltipContent.Location = new System.Drawing.Point(19, 143);
            this.chxManagenotesTooltipContent.Name = "chxManagenotesTooltipContent";
            this.chxManagenotesTooltipContent.Size = new System.Drawing.Size(303, 21);
            this.chxManagenotesTooltipContent.TabIndex = 0;
            this.chxManagenotesTooltipContent.Text = "Show a tooltip with preview of the note content.";
            this.chxManagenotesTooltipContent.UseCompatibleTextRendering = true;
            this.chxManagenotesTooltipContent.UseVisualStyleBackColor = true;
            // 
            // tabHighlight
            // 
            this.tabHighlight.Controls.Add(this.chxLexiconMemory);
            this.tabHighlight.Controls.Add(this.chxHighlightSQL);
            this.tabHighlight.Controls.Add(this.chxHighlightPHP);
            this.tabHighlight.Controls.Add(this.chxHighlightHyperlinks);
            this.tabHighlight.Controls.Add(this.chxConfirmLink);
            this.tabHighlight.Controls.Add(this.chxHighlightHTML);
            this.tabHighlight.Location = new System.Drawing.Point(4, 25);
            this.tabHighlight.Name = "tabHighlight";
            this.tabHighlight.Padding = new System.Windows.Forms.Padding(3);
            this.tabHighlight.Size = new System.Drawing.Size(468, 337);
            this.tabHighlight.TabIndex = 5;
            this.tabHighlight.Text = "Highlight";
            this.tabHighlight.UseVisualStyleBackColor = true;
            // 
            // chxLexiconMemory
            // 
            this.chxLexiconMemory.AutoSize = true;
            this.chxLexiconMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxLexiconMemory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxLexiconMemory.Location = new System.Drawing.Point(20, 219);
            this.chxLexiconMemory.Name = "chxLexiconMemory";
            this.chxLexiconMemory.Size = new System.Drawing.Size(379, 21);
            this.chxLexiconMemory.TabIndex = 19;
            this.chxLexiconMemory.Text = "Clear lexicon memory after highlighting. (not recommended)";
            this.chxLexiconMemory.UseCompatibleTextRendering = true;
            this.chxLexiconMemory.UseVisualStyleBackColor = true;
            // 
            // chxHighlightSQL
            // 
            this.chxHighlightSQL.AutoSize = true;
            this.chxHighlightSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxHighlightSQL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxHighlightSQL.Location = new System.Drawing.Point(20, 82);
            this.chxHighlightSQL.Name = "chxHighlightSQL";
            this.chxHighlightSQL.Size = new System.Drawing.Size(273, 21);
            this.chxHighlightSQL.TabIndex = 16;
            this.chxHighlightSQL.Text = "Highlight SQL text between quotes. (Beta)";
            this.chxHighlightSQL.UseCompatibleTextRendering = true;
            this.chxHighlightSQL.UseVisualStyleBackColor = true;
            // 
            // chxHighlightPHP
            // 
            this.chxHighlightPHP.AutoSize = true;
            this.chxHighlightPHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxHighlightPHP.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxHighlightPHP.Location = new System.Drawing.Point(20, 59);
            this.chxHighlightPHP.Name = "chxHighlightPHP";
            this.chxHighlightPHP.Size = new System.Drawing.Size(316, 21);
            this.chxHighlightPHP.TabIndex = 15;
            this.chxHighlightPHP.Text = "Highlight PHP text between <?php and ?>. (Beta)";
            this.chxHighlightPHP.UseCompatibleTextRendering = true;
            this.chxHighlightPHP.UseVisualStyleBackColor = true;
            // 
            // chxHighlightHyperlinks
            // 
            this.chxHighlightHyperlinks.AutoSize = true;
            this.chxHighlightHyperlinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxHighlightHyperlinks.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxHighlightHyperlinks.Location = new System.Drawing.Point(20, 143);
            this.chxHighlightHyperlinks.Name = "chxHighlightHyperlinks";
            this.chxHighlightHyperlinks.Size = new System.Drawing.Size(179, 21);
            this.chxHighlightHyperlinks.TabIndex = 14;
            this.chxHighlightHyperlinks.Text = "Make hyperlinks clickable.";
            this.chxHighlightHyperlinks.UseCompatibleTextRendering = true;
            this.chxHighlightHyperlinks.UseVisualStyleBackColor = true;
            // 
            // chxConfirmLink
            // 
            this.chxConfirmLink.AutoSize = true;
            this.chxConfirmLink.Checked = true;
            this.chxConfirmLink.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxConfirmLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxConfirmLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxConfirmLink.Location = new System.Drawing.Point(20, 170);
            this.chxConfirmLink.Name = "chxConfirmLink";
            this.chxConfirmLink.Size = new System.Drawing.Size(348, 21);
            this.chxConfirmLink.TabIndex = 18;
            this.chxConfirmLink.Text = "Ask to launch url on click on hyperlink (recommended).";
            this.chxConfirmLink.UseCompatibleTextRendering = true;
            this.chxConfirmLink.UseVisualStyleBackColor = true;
            // 
            // chxHighlightHTML
            // 
            this.chxHighlightHTML.AutoSize = true;
            this.chxHighlightHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxHighlightHTML.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxHighlightHTML.Location = new System.Drawing.Point(20, 36);
            this.chxHighlightHTML.Name = "chxHighlightHTML";
            this.chxHighlightHTML.Size = new System.Drawing.Size(365, 21);
            this.chxHighlightHTML.TabIndex = 13;
            this.chxHighlightHTML.Text = "Highlight HTML text between <html ..> and </html> (Beta)";
            this.chxHighlightHTML.UseCompatibleTextRendering = true;
            this.chxHighlightHTML.UseVisualStyleBackColor = true;
            // 
            // tabSharing
            // 
            this.tabSharing.Controls.Add(this.tabControlSharing);
            this.tabSharing.Location = new System.Drawing.Point(4, 25);
            this.tabSharing.Name = "tabSharing";
            this.tabSharing.Padding = new System.Windows.Forms.Padding(3);
            this.tabSharing.Size = new System.Drawing.Size(468, 337);
            this.tabSharing.TabIndex = 1;
            this.tabSharing.Text = "Actions";
            this.tabSharing.UseVisualStyleBackColor = true;
            // 
            // tabControlSharing
            // 
            this.tabControlSharing.Controls.Add(this.tabEmail);
            this.tabControlSharing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSharing.Location = new System.Drawing.Point(3, 3);
            this.tabControlSharing.Name = "tabControlSharing";
            this.tabControlSharing.SelectedIndex = 0;
            this.tabControlSharing.Size = new System.Drawing.Size(462, 331);
            this.tabControlSharing.TabIndex = 14;
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.tbDefaultEmail);
            this.tabEmail.Controls.Add(this.chxActionsEmailEnabled);
            this.tabEmail.Controls.Add(this.chxActionsEmailDefaultaddressSet);
            this.tabEmail.Location = new System.Drawing.Point(4, 25);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Size = new System.Drawing.Size(454, 302);
            this.tabEmail.TabIndex = 2;
            this.tabEmail.Text = "Email";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // tbDefaultEmail
            // 
            this.tbDefaultEmail.BackColor = System.Drawing.SystemColors.Window;
            this.tbDefaultEmail.Enabled = false;
            this.tbDefaultEmail.Location = new System.Drawing.Point(34, 96);
            this.tbDefaultEmail.Name = "tbDefaultEmail";
            this.tbDefaultEmail.Size = new System.Drawing.Size(342, 22);
            this.tbDefaultEmail.TabIndex = 26;
            // 
            // chxActionsEmailEnabled
            // 
            this.chxActionsEmailEnabled.AutoSize = true;
            this.chxActionsEmailEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxActionsEmailEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxActionsEmailEnabled.Location = new System.Drawing.Point(14, 27);
            this.chxActionsEmailEnabled.Name = "chxActionsEmailEnabled";
            this.chxActionsEmailEnabled.Size = new System.Drawing.Size(198, 21);
            this.chxActionsEmailEnabled.TabIndex = 25;
            this.chxActionsEmailEnabled.Text = "Enable E-mail in action menu";
            this.chxActionsEmailEnabled.UseCompatibleTextRendering = true;
            this.chxActionsEmailEnabled.UseVisualStyleBackColor = true;
            // 
            // chxActionsEmailDefaultaddressSet
            // 
            this.chxActionsEmailDefaultaddressSet.AutoSize = true;
            this.chxActionsEmailDefaultaddressSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxActionsEmailDefaultaddressSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxActionsEmailDefaultaddressSet.Location = new System.Drawing.Point(14, 69);
            this.chxActionsEmailDefaultaddressSet.Name = "chxActionsEmailDefaultaddressSet";
            this.chxActionsEmailDefaultaddressSet.Size = new System.Drawing.Size(255, 21);
            this.chxActionsEmailDefaultaddressSet.TabIndex = 24;
            this.chxActionsEmailDefaultaddressSet.Text = "Set a default email address to send to: ";
            this.chxActionsEmailDefaultaddressSet.UseCompatibleTextRendering = true;
            this.chxActionsEmailDefaultaddressSet.UseVisualStyleBackColor = true;
            this.chxActionsEmailDefaultaddressSet.CheckedChanged += new System.EventHandler(this.chxSocialEmailDefaultaddressBlank_CheckedChanged);
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.tabControlNetwork);
            this.tabNetwork.Controls.Add(this.lblTextNetworkMiliseconds);
            this.tabNetwork.Location = new System.Drawing.Point(4, 25);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetwork.Size = new System.Drawing.Size(468, 337);
            this.tabNetwork.TabIndex = 4;
            this.tabNetwork.Text = "Network";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // tabControlNetwork
            // 
            this.tabControlNetwork.Controls.Add(this.tabUpdates);
            this.tabControlNetwork.Controls.Add(this.tabProxy);
            this.tabControlNetwork.Controls.Add(this.tabPageGPG);
            this.tabControlNetwork.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNetwork.Location = new System.Drawing.Point(3, 3);
            this.tabControlNetwork.Name = "tabControlNetwork";
            this.tabControlNetwork.SelectedIndex = 0;
            this.tabControlNetwork.Size = new System.Drawing.Size(462, 331);
            this.tabControlNetwork.TabIndex = 33;
            // 
            // tabUpdates
            // 
            this.tabUpdates.Controls.Add(this.tableLayoutPanel8);
            this.tabUpdates.Controls.Add(this.tableLayoutPanel7);
            this.tabUpdates.Controls.Add(this.chxUpdateSilentInstall);
            this.tabUpdates.Controls.Add(this.btnCheckUpdates);
            this.tabUpdates.Location = new System.Drawing.Point(4, 25);
            this.tabUpdates.Name = "tabUpdates";
            this.tabUpdates.Padding = new System.Windows.Forms.Padding(3);
            this.tabUpdates.Size = new System.Drawing.Size(454, 302);
            this.tabUpdates.TabIndex = 0;
            this.tabUpdates.Text = "Updates";
            this.tabUpdates.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.lblTextDaysPlugins, 2, 2);
            this.tableLayoutPanel8.Controls.Add(this.numUpdateCheckPluginsDays, 1, 2);
            this.tableLayoutPanel8.Controls.Add(this.lblTextCheckpluginsupdatesevery, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.numUpdateCheckDays, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTextDayAtStartup, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblTextCheckforupdatesevery, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.chxCheckUpdates, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(11, 24);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.74627F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(402, 86);
            this.tableLayoutPanel8.TabIndex = 37;
            // 
            // lblTextDaysPlugins
            // 
            this.lblTextDaysPlugins.AutoSize = true;
            this.lblTextDaysPlugins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextDaysPlugins.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextDaysPlugins.Location = new System.Drawing.Point(278, 57);
            this.lblTextDaysPlugins.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextDaysPlugins.Name = "lblTextDaysPlugins";
            this.lblTextDaysPlugins.Size = new System.Drawing.Size(37, 20);
            this.lblTextDaysPlugins.TabIndex = 40;
            this.lblTextDaysPlugins.Text = "days.";
            this.lblTextDaysPlugins.UseCompatibleTextRendering = true;
            // 
            // numUpdateCheckPluginsDays
            // 
            this.numUpdateCheckPluginsDays.Enabled = false;
            this.numUpdateCheckPluginsDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numUpdateCheckPluginsDays.Location = new System.Drawing.Point(234, 55);
            this.numUpdateCheckPluginsDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numUpdateCheckPluginsDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateCheckPluginsDays.Name = "numUpdateCheckPluginsDays";
            this.numUpdateCheckPluginsDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numUpdateCheckPluginsDays.Size = new System.Drawing.Size(38, 22);
            this.numUpdateCheckPluginsDays.TabIndex = 39;
            this.numUpdateCheckPluginsDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpdateCheckPluginsDays.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lblTextCheckpluginsupdatesevery
            // 
            this.lblTextCheckpluginsupdatesevery.AutoSize = true;
            this.lblTextCheckpluginsupdatesevery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextCheckpluginsupdatesevery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextCheckpluginsupdatesevery.Location = new System.Drawing.Point(18, 57);
            this.lblTextCheckpluginsupdatesevery.Margin = new System.Windows.Forms.Padding(18, 5, 3, 0);
            this.lblTextCheckpluginsupdatesevery.Name = "lblTextCheckpluginsupdatesevery";
            this.lblTextCheckpluginsupdatesevery.Size = new System.Drawing.Size(184, 20);
            this.lblTextCheckpluginsupdatesevery.TabIndex = 38;
            this.lblTextCheckpluginsupdatesevery.Text = "Check plugins updates every: ";
            this.lblTextCheckpluginsupdatesevery.UseCompatibleTextRendering = true;
            // 
            // numUpdateCheckDays
            // 
            this.numUpdateCheckDays.Enabled = false;
            this.numUpdateCheckDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numUpdateCheckDays.Location = new System.Drawing.Point(234, 29);
            this.numUpdateCheckDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numUpdateCheckDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdateCheckDays.Name = "numUpdateCheckDays";
            this.numUpdateCheckDays.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numUpdateCheckDays.Size = new System.Drawing.Size(38, 22);
            this.numUpdateCheckDays.TabIndex = 28;
            this.numUpdateCheckDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpdateCheckDays.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // lblTextDayAtStartup
            // 
            this.lblTextDayAtStartup.AutoSize = true;
            this.lblTextDayAtStartup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextDayAtStartup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextDayAtStartup.Location = new System.Drawing.Point(278, 31);
            this.lblTextDayAtStartup.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextDayAtStartup.Name = "lblTextDayAtStartup";
            this.lblTextDayAtStartup.Size = new System.Drawing.Size(100, 20);
            this.lblTextDayAtStartup.TabIndex = 29;
            this.lblTextDayAtStartup.Text = "days, at startup.";
            this.lblTextDayAtStartup.UseCompatibleTextRendering = true;
            // 
            // lblTextCheckforupdatesevery
            // 
            this.lblTextCheckforupdatesevery.AutoSize = true;
            this.lblTextCheckforupdatesevery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextCheckforupdatesevery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextCheckforupdatesevery.Location = new System.Drawing.Point(18, 31);
            this.lblTextCheckforupdatesevery.Margin = new System.Windows.Forms.Padding(18, 5, 3, 0);
            this.lblTextCheckforupdatesevery.Name = "lblTextCheckforupdatesevery";
            this.lblTextCheckforupdatesevery.Size = new System.Drawing.Size(210, 20);
            this.lblTextCheckforupdatesevery.TabIndex = 27;
            this.lblTextCheckforupdatesevery.Text = "Check programme updates every: ";
            this.lblTextCheckforupdatesevery.UseCompatibleTextRendering = true;
            // 
            // chxCheckUpdates
            // 
            this.chxCheckUpdates.AutoSize = true;
            this.tableLayoutPanel8.SetColumnSpan(this.chxCheckUpdates, 3);
            this.chxCheckUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxCheckUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxCheckUpdates.Location = new System.Drawing.Point(3, 3);
            this.chxCheckUpdates.Name = "chxCheckUpdates";
            this.chxCheckUpdates.Size = new System.Drawing.Size(132, 20);
            this.chxCheckUpdates.TabIndex = 26;
            this.chxCheckUpdates.Text = "Check for updates";
            this.chxCheckUpdates.UseCompatibleTextRendering = true;
            this.chxCheckUpdates.UseVisualStyleBackColor = true;
            this.chxCheckUpdates.CheckedChanged += new System.EventHandler(this.cbxCheckUpdates_CheckedChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel7.Controls.Add(this.lblTextLatestUpdateCheck, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblLatestUpdateCheck, 1, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(13, 187);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(402, 23);
            this.tableLayoutPanel7.TabIndex = 36;
            // 
            // lblTextLatestUpdateCheck
            // 
            this.lblTextLatestUpdateCheck.AutoSize = true;
            this.lblTextLatestUpdateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextLatestUpdateCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextLatestUpdateCheck.Location = new System.Drawing.Point(3, 0);
            this.lblTextLatestUpdateCheck.Name = "lblTextLatestUpdateCheck";
            this.lblTextLatestUpdateCheck.Size = new System.Drawing.Size(213, 20);
            this.lblTextLatestUpdateCheck.TabIndex = 31;
            this.lblTextLatestUpdateCheck.Text = "Last update check is performed on:";
            this.lblTextLatestUpdateCheck.UseCompatibleTextRendering = true;
            // 
            // lblLatestUpdateCheck
            // 
            this.lblLatestUpdateCheck.AutoSize = true;
            this.lblLatestUpdateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblLatestUpdateCheck.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLatestUpdateCheck.Location = new System.Drawing.Point(222, 0);
            this.lblLatestUpdateCheck.Name = "lblLatestUpdateCheck";
            this.lblLatestUpdateCheck.Size = new System.Drawing.Size(60, 16);
            this.lblLatestUpdateCheck.TabIndex = 32;
            this.lblLatestUpdateCheck.Text = "unknown";
            // 
            // chxUpdateSilentInstall
            // 
            this.chxUpdateSilentInstall.AutoSize = true;
            this.chxUpdateSilentInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxUpdateSilentInstall.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxUpdateSilentInstall.Location = new System.Drawing.Point(14, 116);
            this.chxUpdateSilentInstall.Name = "chxUpdateSilentInstall";
            this.chxUpdateSilentInstall.Size = new System.Drawing.Size(260, 21);
            this.chxUpdateSilentInstall.TabIndex = 35;
            this.chxUpdateSilentInstall.Text = "Install programme update setup silently.";
            this.chxUpdateSilentInstall.UseCompatibleTextRendering = true;
            this.chxUpdateSilentInstall.UseVisualStyleBackColor = true;
            // 
            // btnCheckUpdates
            // 
            this.btnCheckUpdates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCheckUpdates.AutoSize = true;
            this.btnCheckUpdates.BackColor = System.Drawing.Color.LightGray;
            this.btnCheckUpdates.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckUpdates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCheckUpdates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCheckUpdates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCheckUpdates.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCheckUpdates.Location = new System.Drawing.Point(112, 216);
            this.btnCheckUpdates.Name = "btnCheckUpdates";
            this.btnCheckUpdates.Size = new System.Drawing.Size(227, 30);
            this.btnCheckUpdates.TabIndex = 30;
            this.btnCheckUpdates.Text = "Check updates now";
            this.btnCheckUpdates.UseCompatibleTextRendering = true;
            this.btnCheckUpdates.UseVisualStyleBackColor = false;
            this.btnCheckUpdates.Click += new System.EventHandler(this.btnCheckUpdates_Click);
            // 
            // tabProxy
            // 
            this.tabProxy.Controls.Add(this.tableLayoutPanel10);
            this.tabProxy.Controls.Add(this.tableLayoutPanel9);
            this.tabProxy.Location = new System.Drawing.Point(4, 25);
            this.tabProxy.Name = "tabProxy";
            this.tabProxy.Padding = new System.Windows.Forms.Padding(3);
            this.tabProxy.Size = new System.Drawing.Size(454, 302);
            this.tabProxy.TabIndex = 1;
            this.tabProxy.Text = "Proxy";
            this.tabProxy.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 4;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.52174F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.47826F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel10.Controls.Add(this.chxProxyEnabled, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.numProxyPort, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblTextAddress, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.iptbProxy, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblTextPort, 2, 1);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(12, 32);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(424, 61);
            this.tableLayoutPanel10.TabIndex = 32;
            // 
            // chxProxyEnabled
            // 
            this.chxProxyEnabled.AutoSize = true;
            this.tableLayoutPanel10.SetColumnSpan(this.chxProxyEnabled, 4);
            this.chxProxyEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxProxyEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxProxyEnabled.Location = new System.Drawing.Point(3, 3);
            this.chxProxyEnabled.Name = "chxProxyEnabled";
            this.chxProxyEnabled.Size = new System.Drawing.Size(122, 21);
            this.chxProxyEnabled.TabIndex = 1;
            this.chxProxyEnabled.Text = "Use HTTP proxy";
            this.chxProxyEnabled.UseCompatibleTextRendering = true;
            this.chxProxyEnabled.UseVisualStyleBackColor = true;
            this.chxProxyEnabled.CheckedChanged += new System.EventHandler(this.chxUseProxy_CheckedChanged);
            // 
            // numProxyPort
            // 
            this.numProxyPort.Enabled = false;
            this.numProxyPort.Location = new System.Drawing.Point(276, 33);
            this.numProxyPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numProxyPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProxyPort.Name = "numProxyPort";
            this.numProxyPort.Size = new System.Drawing.Size(60, 22);
            this.numProxyPort.TabIndex = 31;
            this.numProxyPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numProxyPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // lblTextAddress
            // 
            this.lblTextAddress.AutoSize = true;
            this.lblTextAddress.Location = new System.Drawing.Point(3, 35);
            this.lblTextAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextAddress.Name = "lblTextAddress";
            this.lblTextAddress.Size = new System.Drawing.Size(61, 16);
            this.lblTextAddress.TabIndex = 29;
            this.lblTextAddress.Text = "address:";
            // 
            // iptbProxy
            // 
            this.iptbProxy.Enabled = false;
            this.iptbProxy.Location = new System.Drawing.Point(76, 33);
            this.iptbProxy.Name = "iptbProxy";
            this.iptbProxy.Size = new System.Drawing.Size(152, 22);
            this.iptbProxy.TabIndex = 26;
            this.iptbProxy.UseIPv4addr = true;
            this.iptbProxy.UseIPv6addr = true;
            // 
            // lblTextPort
            // 
            this.lblTextPort.AutoSize = true;
            this.lblTextPort.Location = new System.Drawing.Point(234, 35);
            this.lblTextPort.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextPort.Name = "lblTextPort";
            this.lblTextPort.Size = new System.Drawing.Size(34, 16);
            this.lblTextPort.TabIndex = 30;
            this.lblTextPort.Text = "port:";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.lblTextNetworkTimeout, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.numTimeout, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblTextMiliseconds, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.lblTextPreferedIPversion, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.cbxNetworkIPversion, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(12, 113);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(424, 62);
            this.tableLayoutPanel9.TabIndex = 28;
            // 
            // lblTextNetworkTimeout
            // 
            this.lblTextNetworkTimeout.AutoSize = true;
            this.lblTextNetworkTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextNetworkTimeout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextNetworkTimeout.Location = new System.Drawing.Point(3, 5);
            this.lblTextNetworkTimeout.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextNetworkTimeout.Name = "lblTextNetworkTimeout";
            this.lblTextNetworkTimeout.Size = new System.Drawing.Size(150, 20);
            this.lblTextNetworkTimeout.TabIndex = 24;
            this.lblTextNetworkTimeout.Text = "connection timeout time:";
            this.lblTextNetworkTimeout.UseCompatibleTextRendering = true;
            // 
            // numTimeout
            // 
            this.numTimeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.numTimeout.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTimeout.Location = new System.Drawing.Point(159, 3);
            this.numTimeout.Maximum = new decimal(new int[] {
            30000,
            0,
            0,
            0});
            this.numTimeout.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numTimeout.Size = new System.Drawing.Size(58, 22);
            this.numTimeout.TabIndex = 23;
            this.numTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimeout.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // lblTextMiliseconds
            // 
            this.lblTextMiliseconds.AccessibleDescription = "Miliseconds";
            this.lblTextMiliseconds.AutoSize = true;
            this.lblTextMiliseconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextMiliseconds.Location = new System.Drawing.Point(223, 5);
            this.lblTextMiliseconds.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextMiliseconds.Name = "lblTextMiliseconds";
            this.lblTextMiliseconds.Size = new System.Drawing.Size(23, 20);
            this.lblTextMiliseconds.TabIndex = 25;
            this.lblTextMiliseconds.Text = "ms";
            this.lblTextMiliseconds.UseCompatibleTextRendering = true;
            // 
            // lblTextPreferedIPversion
            // 
            this.lblTextPreferedIPversion.AutoSize = true;
            this.lblTextPreferedIPversion.Location = new System.Drawing.Point(3, 35);
            this.lblTextPreferedIPversion.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextPreferedIPversion.Name = "lblTextPreferedIPversion";
            this.lblTextPreferedIPversion.Size = new System.Drawing.Size(98, 16);
            this.lblTextPreferedIPversion.TabIndex = 26;
            this.lblTextPreferedIPversion.Text = "Use IP version:";
            // 
            // cbxNetworkIPversion
            // 
            this.tableLayoutPanel9.SetColumnSpan(this.cbxNetworkIPversion, 2);
            this.cbxNetworkIPversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNetworkIPversion.FormattingEnabled = true;
            this.cbxNetworkIPversion.Location = new System.Drawing.Point(159, 33);
            this.cbxNetworkIPversion.Name = "cbxNetworkIPversion";
            this.cbxNetworkIPversion.Size = new System.Drawing.Size(130, 24);
            this.cbxNetworkIPversion.TabIndex = 32;
            this.cbxNetworkIPversion.SelectedIndexChanged += new System.EventHandler(this.cbxNetworkIPversion_SelectedIndexChanged);
            // 
            // tabPageGPG
            // 
            this.tabPageGPG.Controls.Add(this.tbGPGPath);
            this.tabPageGPG.Controls.Add(this.btnGPGPathBrowse);
            this.tabPageGPG.Controls.Add(this.lblTextGPGPath);
            this.tabPageGPG.Controls.Add(this.chxCheckUpdatesSignature);
            this.tabPageGPG.Location = new System.Drawing.Point(4, 25);
            this.tabPageGPG.Name = "tabPageGPG";
            this.tabPageGPG.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGPG.Size = new System.Drawing.Size(454, 302);
            this.tabPageGPG.TabIndex = 2;
            this.tabPageGPG.Text = "GnuPG";
            this.tabPageGPG.UseVisualStyleBackColor = true;
            // 
            // tbGPGPath
            // 
            this.tbGPGPath.Location = new System.Drawing.Point(123, 60);
            this.tbGPGPath.Name = "tbGPGPath";
            this.tbGPGPath.Size = new System.Drawing.Size(221, 22);
            this.tbGPGPath.TabIndex = 38;
            // 
            // btnGPGPathBrowse
            // 
            this.btnGPGPathBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnGPGPathBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnGPGPathBrowse.Location = new System.Drawing.Point(350, 59);
            this.btnGPGPathBrowse.Name = "btnGPGPathBrowse";
            this.btnGPGPathBrowse.Size = new System.Drawing.Size(64, 25);
            this.btnGPGPathBrowse.TabIndex = 36;
            this.btnGPGPathBrowse.Text = "browse";
            this.btnGPGPathBrowse.UseCompatibleTextRendering = true;
            this.btnGPGPathBrowse.UseVisualStyleBackColor = false;
            this.btnGPGPathBrowse.Click += new System.EventHandler(this.btnGPGPathBrowse_Click);
            // 
            // lblTextGPGPath
            // 
            this.lblTextGPGPath.AutoSize = true;
            this.lblTextGPGPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextGPGPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextGPGPath.Location = new System.Drawing.Point(7, 63);
            this.lblTextGPGPath.Name = "lblTextGPGPath";
            this.lblTextGPGPath.Size = new System.Drawing.Size(110, 20);
            this.lblTextGPGPath.TabIndex = 37;
            this.lblTextGPGPath.Text = "Location gpg.exe:";
            this.lblTextGPGPath.UseCompatibleTextRendering = true;
            // 
            // chxCheckUpdatesSignature
            // 
            this.chxCheckUpdatesSignature.AutoSize = true;
            this.chxCheckUpdatesSignature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxCheckUpdatesSignature.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxCheckUpdatesSignature.Location = new System.Drawing.Point(13, 34);
            this.chxCheckUpdatesSignature.Name = "chxCheckUpdatesSignature";
            this.chxCheckUpdatesSignature.Size = new System.Drawing.Size(284, 21);
            this.chxCheckUpdatesSignature.TabIndex = 35;
            this.chxCheckUpdatesSignature.Text = "Verify the signature of downloaded updates.";
            this.chxCheckUpdatesSignature.UseCompatibleTextRendering = true;
            this.chxCheckUpdatesSignature.UseVisualStyleBackColor = true;
            this.chxCheckUpdatesSignature.CheckStateChanged += new System.EventHandler(this.chxCheckUpdatesSignature_CheckedChanged);
            // 
            // lblTextNetworkMiliseconds
            // 
            this.lblTextNetworkMiliseconds.AutoSize = true;
            this.lblTextNetworkMiliseconds.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextNetworkMiliseconds.Location = new System.Drawing.Point(164, 141);
            this.lblTextNetworkMiliseconds.Name = "lblTextNetworkMiliseconds";
            this.lblTextNetworkMiliseconds.Size = new System.Drawing.Size(26, 16);
            this.lblTextNetworkMiliseconds.TabIndex = 25;
            this.lblTextNetworkMiliseconds.Text = "ms";
            // 
            // tabAdvance
            // 
            this.tabAdvance.Controls.Add(this.tableLayoutPanel11);
            this.tabAdvance.Controls.Add(this.btnBrowse);
            this.tabAdvance.Controls.Add(this.lblTextNoteLocation);
            this.tabAdvance.Controls.Add(this.tableLayoutPanel1);
            this.tabAdvance.Controls.Add(this.chxLogExceptions);
            this.tabAdvance.Controls.Add(this.lblTextLogging);
            this.tabAdvance.Controls.Add(this.chxLogDebug);
            this.tabAdvance.Controls.Add(this.chxLogErrors);
            this.tabAdvance.Controls.Add(this.tbNotesSavePath);
            this.tabAdvance.Location = new System.Drawing.Point(4, 25);
            this.tabAdvance.Name = "tabAdvance";
            this.tabAdvance.Size = new System.Drawing.Size(468, 337);
            this.tabAdvance.TabIndex = 2;
            this.tabAdvance.Text = "Advance";
            this.tabAdvance.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.93631F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0637F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel11.Controls.Add(this.btnResetSettings, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.btnOpenSettingsFolder, 1, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(23, 240);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(409, 72);
            this.tableLayoutPanel11.TabIndex = 41;
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.AutoSize = true;
            this.btnResetSettings.BackColor = System.Drawing.Color.LightGray;
            this.btnResetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnResetSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResetSettings.Location = new System.Drawing.Point(94, 39);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(207, 30);
            this.btnResetSettings.TabIndex = 21;
            this.btnResetSettings.Text = "&Reset all settings to default";
            this.btnResetSettings.UseCompatibleTextRendering = true;
            this.btnResetSettings.UseVisualStyleBackColor = false;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnOpenSettingsFolder
            // 
            this.btnOpenSettingsFolder.BackColor = System.Drawing.Color.LightGray;
            this.btnOpenSettingsFolder.Location = new System.Drawing.Point(94, 3);
            this.btnOpenSettingsFolder.Name = "btnOpenSettingsFolder";
            this.btnOpenSettingsFolder.Size = new System.Drawing.Size(207, 30);
            this.btnOpenSettingsFolder.TabIndex = 40;
            this.btnOpenSettingsFolder.Text = "open settings folder";
            this.btnOpenSettingsFolder.UseVisualStyleBackColor = false;
            this.btnOpenSettingsFolder.Click += new System.EventHandler(this.btnOpenSettingsFolder_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(345, 49);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(68, 25);
            this.btnBrowse.TabIndex = 37;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseCompatibleTextRendering = true;
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // lblTextNoteLocation
            // 
            this.lblTextNoteLocation.AutoSize = true;
            this.lblTextNoteLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextNoteLocation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextNoteLocation.Location = new System.Drawing.Point(20, 26);
            this.lblTextNoteLocation.Name = "lblTextNoteLocation";
            this.lblTextNoteLocation.Size = new System.Drawing.Size(89, 20);
            this.lblTextNoteLocation.TabIndex = 38;
            this.lblTextNoteLocation.Text = "Save notes in:";
            this.lblTextNoteLocation.UseCompatibleTextRendering = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.numWarnLimitVisible, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTextTotalNotesWarnLimit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTextVisibleNotesWarnLimit, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numWarnLimitTotal, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 80);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(412, 61);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // numWarnLimitVisible
            // 
            this.numWarnLimitVisible.Location = new System.Drawing.Point(172, 33);
            this.numWarnLimitVisible.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numWarnLimitVisible.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWarnLimitVisible.Name = "numWarnLimitVisible";
            this.numWarnLimitVisible.Size = new System.Drawing.Size(49, 22);
            this.numWarnLimitVisible.TabIndex = 28;
            this.numWarnLimitVisible.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblTextTotalNotesWarnLimit
            // 
            this.lblTextTotalNotesWarnLimit.AutoSize = true;
            this.lblTextTotalNotesWarnLimit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextTotalNotesWarnLimit.Location = new System.Drawing.Point(3, 5);
            this.lblTextTotalNotesWarnLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextTotalNotesWarnLimit.Name = "lblTextTotalNotesWarnLimit";
            this.lblTextTotalNotesWarnLimit.Size = new System.Drawing.Size(153, 20);
            this.lblTextTotalNotesWarnLimit.TabIndex = 26;
            this.lblTextTotalNotesWarnLimit.Text = "Total notes warning limit:";
            this.lblTextTotalNotesWarnLimit.UseCompatibleTextRendering = true;
            // 
            // lblTextVisibleNotesWarnLimit
            // 
            this.lblTextVisibleNotesWarnLimit.AutoSize = true;
            this.lblTextVisibleNotesWarnLimit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextVisibleNotesWarnLimit.Location = new System.Drawing.Point(3, 35);
            this.lblTextVisibleNotesWarnLimit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblTextVisibleNotesWarnLimit.Name = "lblTextVisibleNotesWarnLimit";
            this.lblTextVisibleNotesWarnLimit.Size = new System.Drawing.Size(163, 20);
            this.lblTextVisibleNotesWarnLimit.TabIndex = 27;
            this.lblTextVisibleNotesWarnLimit.Text = "Visible notes warning limit:";
            this.lblTextVisibleNotesWarnLimit.UseCompatibleTextRendering = true;
            // 
            // numWarnLimitTotal
            // 
            this.numWarnLimitTotal.Location = new System.Drawing.Point(172, 3);
            this.numWarnLimitTotal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numWarnLimitTotal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWarnLimitTotal.Name = "numWarnLimitTotal";
            this.numWarnLimitTotal.Size = new System.Drawing.Size(49, 22);
            this.numWarnLimitTotal.TabIndex = 25;
            this.numWarnLimitTotal.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // chxLogExceptions
            // 
            this.chxLogExceptions.AutoSize = true;
            this.chxLogExceptions.Checked = true;
            this.chxLogExceptions.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxLogExceptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxLogExceptions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxLogExceptions.Location = new System.Drawing.Point(22, 213);
            this.chxLogExceptions.Name = "chxLogExceptions";
            this.chxLogExceptions.Size = new System.Drawing.Size(216, 21);
            this.chxLogExceptions.TabIndex = 24;
            this.chxLogExceptions.Text = "Log exceptions (recommended).";
            this.chxLogExceptions.UseCompatibleTextRendering = true;
            this.chxLogExceptions.UseVisualStyleBackColor = true;
            // 
            // lblTextLogging
            // 
            this.lblTextLogging.AutoSize = true;
            this.lblTextLogging.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.lblTextLogging.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTextLogging.Location = new System.Drawing.Point(20, 144);
            this.lblTextLogging.Name = "lblTextLogging";
            this.lblTextLogging.Size = new System.Drawing.Size(56, 20);
            this.lblTextLogging.TabIndex = 23;
            this.lblTextLogging.Text = "Logging:";
            this.lblTextLogging.UseCompatibleTextRendering = true;
            // 
            // chxLogDebug
            // 
            this.chxLogDebug.AutoSize = true;
            this.chxLogDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxLogDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxLogDebug.Location = new System.Drawing.Point(22, 167);
            this.chxLogDebug.Name = "chxLogDebug";
            this.chxLogDebug.Size = new System.Drawing.Size(116, 21);
            this.chxLogDebug.TabIndex = 22;
            this.chxLogDebug.Text = "Log debug info.";
            this.chxLogDebug.UseCompatibleTextRendering = true;
            this.chxLogDebug.UseVisualStyleBackColor = true;
            // 
            // chxLogErrors
            // 
            this.chxLogErrors.AutoSize = true;
            this.chxLogErrors.Checked = true;
            this.chxLogErrors.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxLogErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxLogErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxLogErrors.Location = new System.Drawing.Point(22, 190);
            this.chxLogErrors.Name = "chxLogErrors";
            this.chxLogErrors.Size = new System.Drawing.Size(118, 21);
            this.chxLogErrors.TabIndex = 19;
            this.chxLogErrors.Text = "Log user errors.";
            this.chxLogErrors.UseCompatibleTextRendering = true;
            this.chxLogErrors.UseVisualStyleBackColor = true;
            // 
            // tbNotesSavePath
            // 
            this.tbNotesSavePath.Location = new System.Drawing.Point(22, 50);
            this.tbNotesSavePath.Name = "tbNotesSavePath";
            this.tbNotesSavePath.Size = new System.Drawing.Size(317, 22);
            this.tbNotesSavePath.TabIndex = 39;
            // 
            // chxSettingsExpertEnabled
            // 
            this.chxSettingsExpertEnabled.AccessibleDescription = "Show expert settings";
            this.chxSettingsExpertEnabled.AutoSize = true;
            this.chxSettingsExpertEnabled.Checked = true;
            this.chxSettingsExpertEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxSettingsExpertEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.chxSettingsExpertEnabled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chxSettingsExpertEnabled.Location = new System.Drawing.Point(12, 375);
            this.chxSettingsExpertEnabled.Name = "chxSettingsExpertEnabled";
            this.chxSettingsExpertEnabled.Size = new System.Drawing.Size(112, 21);
            this.chxSettingsExpertEnabled.TabIndex = 25;
            this.chxSettingsExpertEnabled.Text = "E&xpert settings";
            this.chxSettingsExpertEnabled.UseCompatibleTextRendering = true;
            this.chxSettingsExpertEnabled.UseVisualStyleBackColor = true;
            this.chxSettingsExpertEnabled.CheckedChanged += new System.EventHandler(this.chxShowExpertSettings_CheckedChanged);
            // 
            // folderBrowseDialogNotessavepath
            // 
            this.folderBrowseDialogNotessavepath.Description = "Select a folder to store the all the notes files in";
            this.folderBrowseDialogNotessavepath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // openFileDialogBrowseGPG
            // 
            this.openFileDialogBrowseGPG.AddExtension = false;
            this.openFileDialogBrowseGPG.DefaultExt = "exe";
            this.openFileDialogBrowseGPG.FileName = "gpg.exe";
            this.openFileDialogBrowseGPG.Title = "Select path to gpg.exe";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(476, 402);
            this.Controls.Add(this.chxSettingsExpertEnabled);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 240);
            this.Name = "FrmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.tabControlSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabHotkeys.ResumeLayout(false);
            this.tableLayoutPanelShortcuts.ResumeLayout(false);
            this.tableLayoutPanelShortcuts.PerformLayout();
            this.tabAppearance.ResumeLayout(false);
            this.tabctrlAppearance.ResumeLayout(false);
            this.tabAppearanceOverall.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProcTransparency)).EndInit();
            this.tabPageNewNote.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotesDefaultHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNotesDefaultWidth)).EndInit();
            this.tableLayoutPanelNewNote.ResumeLayout(false);
            this.tableLayoutPanelNewNote.PerformLayout();
            this.tabPageFonts.ResumeLayout(false);
            this.tableLayoutPanelNotes.ResumeLayout(false);
            this.tableLayoutPanelNotes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSizeContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFontSizeTitle)).EndInit();
            this.tabPageTrayicon.ResumeLayout(false);
            this.tabPageTrayicon.PerformLayout();
            this.tableLayoutPanelTrayicon.ResumeLayout(false);
            this.tableLayoutPanelTrayicon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTrayiconFontsize)).EndInit();
            this.tabAppereanceManagenotes.ResumeLayout(false);
            this.tabAppereanceManagenotes.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numManagenotesFont)).EndInit();
            this.tabHighlight.ResumeLayout(false);
            this.tabHighlight.PerformLayout();
            this.tabSharing.ResumeLayout(false);
            this.tabControlSharing.ResumeLayout(false);
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            this.tabControlNetwork.ResumeLayout(false);
            this.tabUpdates.ResumeLayout(false);
            this.tabUpdates.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCheckPluginsDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdateCheckDays)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tabProxy.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProxyPort)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.tabPageGPG.ResumeLayout(false);
            this.tabPageGPG.PerformLayout();
            this.tabAdvance.ResumeLayout(false);
            this.tabAdvance.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWarnLimitVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWarnLimitTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chxLexiconMemory;
        private System.Windows.Forms.Label lblTextDaysPlugins;
        private System.Windows.Forms.NumericUpDown numUpdateCheckPluginsDays;
        private System.Windows.Forms.Label lblTextCheckpluginsupdatesevery;
        private System.Windows.Forms.CheckBox chxLoadPlugins;
    }
}