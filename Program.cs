﻿//-----------------------------------------------------------------------
// <copyright file="TrayIcon.cs" company="GNU">
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
#define windows //platform can be: windows, linux, macos //platform can be: windows, linux, macos

using System;
[assembly: CLSCompliant(true)]
namespace NoteFly
{
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;

    public class Program
    {
		#region Fields (2) 

        private static Notes notes;
        private static TrayIcon trayicon;

		#endregion Fields 

		#region Properties (3) 

        /// <summary>
        /// Gets the application data folder.
        /// </summary>
        public static string AppDataFolder
        {
            get
            {
#if windows
                return System.Environment.GetEnvironmentVariable("APPDATA") + "\\.NoteFly2\\";
#elif linux
                return System.Environment.GetEnvironmentVariable("HOME") + "/.NoteFly2/";
#elif macos
                return "???";
#else
                return "COMPILE_ERROR";
#endif
            }
        }

        /// <summary>
        /// Gets the application title.
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (!String.IsNullOrEmpty(titleAttribute.Title))
                    {
                        return titleAttribute.Title;
                    }
                }

                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        /// Gets the application version number.
        /// </summary>
        /// <returns>a string containing the version number of this application in the form of major.minur.build number</returns>
        public static string AssemblyVersion
        {
            get
            {
                int majorver = Assembly.GetExecutingAssembly().GetName().Version.Major;
                int minorver = Assembly.GetExecutingAssembly().GetName().Version.Minor;
                int releasever = Assembly.GetExecutingAssembly().GetName().Version.Build;
                int buildnumber = Assembly.GetExecutingAssembly().GetName().Version.Revision;
                return majorver + "." + minorver + "." + releasever + "." + buildnumber;
            }
        }

		#endregion Properties 

		#region Methods (1) 

		// Public Methods (1) 

        /// <summary>
        /// Main entry point programme.
        /// load settings, parser parameters, create notes list and trayicon.
        /// </summary>
        /// <param name="args">parameters</param>
        [STAThread]
        public static void Main(string[] args)
        {
#if windows
            //a suggestion to "protect" against insecure Library Loading Vulnerabilities.
            //it does not fix it, it makes it harder to exploit if insecure dll loading exist.
            //NoteFly uses APPDATA and TEMP variables and systemroot is required for opening link.
            //This is OS specific 
            // /*
            Environment.SetEnvironmentVariable("PATH", String.Empty);
            Environment.SetEnvironmentVariable("windir", String.Empty);
            Environment.SetEnvironmentVariable("SystemDrive", String.Empty);
            Environment.SetEnvironmentVariable("ProgramFiles", String.Empty);
            Environment.SetEnvironmentVariable("CommonProgramFiles", String.Empty);
            Environment.SetEnvironmentVariable("TMP", String.Empty);
            // */
#endif
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(true);
            if (!xmlUtil.LoadSettings())
            {
                xmlUtil.WriteDefaultSettings();
                xmlUtil.LoadSettings();
            }
            
            //override settings with supported parameters
            if (System.Environment.GetCommandLineArgs().Length > 1)
            {
                foreach (string arg in args)
                {
                    switch (arg)
                    {
                        //Forces the programme to setup the first run notefly info again.
                        case "/forcefirstrun":
                            Settings.ProgramFirstrun = true;
                            break;
                        //disabletransparency parameter is for OS that don't support transparency, so they can still show notes.
                        //because transparency is on by default.
                        case "/disabletransparency":
                            Settings.NotesTransparencyEnabled = false;
                            break;
                        //Turn off all highlighting functions in case highlighting was turned on and it let NoteFly crash on startup.
                        case "/disablehighlighting":
                            Settings.HighlightHyperlinks = false;
                            Settings.HighlightHTML = false;
                            Settings.HighlightPHP = false;
                            Settings.HighlightSQL = false;
                            break;
                        //Turn off all social functions on startup.
                        case "/disablesocial":
                            Settings.SocialEmailEnabled = false;
                            Settings.SocialFacebookEnabled = false;
                            Settings.SocialTwitterEnabled = false;
                            break;
                        //Turn all logging features on at startup. 
                        //Handy in case NoteFly crashes at startup and logging was turned off.
                        case "/logall":
                            Settings.ProgramLogException = true;
                            Settings.ProgramLogError = true;
                            Settings.ProgramLogInfo = true;
                            break;
                    }
                }
            }
            notes = new Notes();
            trayicon = new TrayIcon(notes);
        }

		#endregion Methods 
    }
}
