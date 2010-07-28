//-----------------------------------------------------------------------
// <copyright file="Settings.cs" company="GNU">
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
namespace NoteFly
{
    using System;

    /// <summary>
    /// The setting class.
    /// </summary>
    public static class Settings
    {
        public static bool NotesTransparencyEnabled { get; set; }

        public static  int NotesTransparencyLevel { get; set; }

        public static int NotesDefaultColor { get; set; }

        public static bool NotesClosebtnTooltipenabled { get; set; }

        public static bool NotesClosebtnHidenotepermanently { get; set; }

        public static string NotesSavepath { get; set; }

        public static int TrayiconLeftclickaction { get; set; }

        public static bool TrayiconCreatenotebold { get; set; }

        public static bool TrayiconManagenotesbold { get; set; }

        public static bool TrayiconSettingsbold { get; set; }

        public static bool TrayiconExitbold { get; set; }

        public static int FontTextdirection { get; set; }

        public static string FontTitleFamily { get; set; }

        public static int FontTitleSize { get; set; }

        public static bool FontTitleStylebold { get; set; }

        public static string FontContentFamily { get; set; }

        public static Decimal FontContentSize { get; set; }

        public static bool HighlightHTML { get; set; }

        public static bool HighlightHyperlinks { get; set; }

        public static bool HighlightPHP { get; set; }

        public static bool HighlightSQL { get; set; }

        public static bool ConfirmLinkclick { get; set; }

        public static bool ConfirmExit { get; set; }

        public static bool ConfirmDeletenote { get; set; }

        public static bool SocialEmailEnabled { get; set; }

        public static string SocialEmailDefaultadres { get; set; }

        public static bool SocialTwitterEnabled { get; set; }

        public static string SocialTwitterUsername { get; set; }

        public static string SocialTwitterpassword { get; set; }

        public static bool SocialTwitterUseSSL { get; set; } //default on and not changed throw gui.

        public static bool SocialFacebookEnabled { get; set; }

        public static bool SocialFacebookSavesession { get; set; }

        public static bool SocialFacebookUseSSL { get; set; }	

        public static int NetworkConnectionTimeout { get; set; }

        public static bool NetworkConnectionForceipv6 { get; set; } //e.g. set ipv6.facebook.com

        public static bool NetworkProxyEnabled { get; set; }

        public static string NetworkProxyAddress { get; set; }
		
		public static bool UpdatescheckEnabled { get; set; }
		
		public static int UpdatecheckEverydays { get; set; }
		
		public static bool UpdatecheckTodaydone { get; set; }
		
		public static int UpdatecheckDay { get; set; }
		
		public static int UpdateheckMonth { get; set; }
		
		public static int UpdatecheckYear { get; set; }

        public static bool ProgramFirstrun { get; set; }	

        public static bool ProgramLogError { get; set; }

        public static bool ProgramLogException { get; set; }

        public static bool ProgramLogInfo { get; set; }
    }
}
