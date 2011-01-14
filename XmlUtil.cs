//-----------------------------------------------------------------------
// <copyright file="XmlUtil.cs" company="GNU">
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
#define windows //platform can be: windows, linux, macos

namespace NoteFly
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Globalization;
    using System.Reflection;
    using System.Collections.Generic;

    public static class xmlUtil
    {
        #region Fields (4)

        private const string SETTINGSFILE = "settings.xml";
        private const string SKINFILE = "skins.xml";
        private const string NOTEVERSION = "2";
        private static XmlTextReader xmlread = null;
        private static XmlTextWriter xmlwrite = null;

        #endregion Fields

        #region Methods (11)

        // Public Methods (8) 

        /*
        /// <summary>
        /// get xml node boolean valaue
        /// </summary>
        /// <param name="nodename"></param>
        /// <returns></returns>
        private static bool GetContentBool(string filename, string nodename)
        {
            xmlread = new XmlTextReader(filename);
            try
            {
                while (xmlread.Read())
                {
                    if (xmlread.Name == nodename)
                    {
                        try
                        {
                            bool nodecontent = xmlread.ReadElementContentAsBoolean();
                            xmlread.Close();
                            return nodecontent;
                        }
                        catch (InvalidCastException invalidcastexc)
                        {
                            throw new CustomException(invalidcastexc.Message);
                        }
                        finally
                        {
                            xmlread.Close();
                        }
                    }
                }
            }
            finally
            {
                xmlread.Close();
            }
            //error not found.
            return false;
        }

        /// <summary>
        /// Get a xml node
        /// </summary>
        /// <param name="nodename"></param>
        /// <returns>return node as integer, -1 if error</returns>
        private static int GetContentInt(string filename, string nodename)
        {
            xmlread = new XmlTextReader(filename);
            try
            {
                while (xmlread.Read())
                {
                    if (xmlread.Name == nodename)
                    {
                        try
                        {
                            int nodecontentinteger = xmlread.ReadElementContentAsInt();
                            xmlread.Close();
                            return nodecontentinteger;
                        }
                        catch (InvalidCastException invalidcastexc)
                        {
                            throw new CustomException(invalidcastexc.Message);
                        }
                        finally
                        {
                            xmlread.Close();
                        }
                    }
                }
            }
            finally
            {
                xmlread.Close();
            }
            //error not found
            return -1;
        }
        */

        /// <summary>
        /// Get a xml node and return the value as string.
        /// </summary>
        /// <param name="nodename"></param>
        /// <returns>return node content as string, empty if not found</returns>
        public static string GetContentString(string filename, string nodename, uint linenumoffsetcontent)
        {
#if DEBUG
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
#endif
            try
            {
                xmlread = new XmlTextReader(filename);
            }
            catch (FileLoadException fileloadexc)
            {
                throw new CustomException(fileloadexc.Message);
            }
            catch (FileNotFoundException filenotfoundexc)
            {
                throw new CustomException(filenotfoundexc.Message);
            }
            if (xmlread == null)
            {
                throw new CustomException("XmlTextReader object is null.");
            }
            const bool disablelineopt = false;
            while (xmlread.Read())
            {
                if (xmlread.LineNumber == linenumoffsetcontent || disablelineopt) //faster than comparing xmlread.name
                {
                    if (xmlread.Name == nodename)
                    {
                        string xmlnodecontent = String.Empty;
                        try
                        {
                            xmlnodecontent = xmlread.ReadElementContentAsString();
                        }
                        finally
                        {
                            xmlread.Close();
                        }
#if DEBUG
                        stopwatch.Stop();
                        Log.Write(LogType.info, "Read content time:  " + stopwatch.ElapsedTicks + " ticks"); //blocking display time ~200ms/7
#endif
                        return xmlnodecontent;
                    }
                }
            }
            //error node not found.
            #if DEBUG
            stopwatch.Stop();
            #endif
            return String.Empty;
        }

        /// <summary>
        /// Loads the settings file and set the settings in the
        /// static Settings class in memory.
        /// </summary>
        /// <returns>true if file settings exists.</returns>
        public static bool LoadSettings()
        {
            string settingsfilepath = Path.Combine(Program.AppDataFolder, SETTINGSFILE);
            if (!File.Exists(settingsfilepath))
            {
                return false;
            }
            try
            {
                xmlread = new XmlTextReader(settingsfilepath);
                xmlread.EntityHandling = EntityHandling.ExpandCharEntities;
                xmlread.ProhibitDtd = true; //gives decreated warning in vs2010.
                while (xmlread.Read())
                {
                    switch (xmlread.Name)
                    {
                        //booleans
                        case "ConfirmDeletenote":
                            Settings.ConfirmDeletenote = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ConfirmExit":
                            Settings.ConfirmExit = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ConfirmLinkclick":
                            Settings.ConfirmLinkclick = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "FontTitleStylebold":
                            Settings.FontTitleStylebold = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "HighlightHTML":
                            Settings.HighlightHTML = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "HighlightHyperlinks":
                            Settings.HighlightHyperlinks = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "HighlightPHP":
                            Settings.HighlightPHP = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "HighlightSQL":
                            Settings.HighlightSQL = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "NetworkConnectionForceipv6":
                            Settings.NetworkConnectionForceipv6 = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "NetworkProxyEnabled":
                            Settings.NetworkProxyEnabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "NotesClosebtnHidenotepermanently":
                            Settings.NotesClosebtnHidenotepermanently = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "NotesClosebtnTooltipenabled":
                            Settings.NotesClosebtnTooltipenabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "NotesTransparencyEnabled":
                            Settings.NotesTransparencyEnabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ProgramFirstrun":
                            Settings.ProgramFirstrun = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ProgramLogError":
                            Settings.ProgramLogError = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ProgramLogException":
                            Settings.ProgramLogException = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "ProgramLogInfo":
                            Settings.ProgramLogInfo = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "SocialEmailEnabled":
                            Settings.SocialEmailEnabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "SocialFacebookEnabled":
                            Settings.SocialFacebookEnabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        //case "SocialFacebookSavesession":
                        //    Settings.SocialFacebookSavesession = xmlread.ReadElementContentAsBoolean();
                        //    break;
                        case "SocialFacebookUseSSL":
                            Settings.SocialFacebookUseSSL = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "SocialTwitterEnabled":
                            Settings.SocialTwitterEnabled = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "SocialTwitterUseSSL":
                            Settings.SocialTwitterUseSSL = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "TrayiconCreatenotebold":
                            Settings.TrayiconCreatenotebold = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "TrayiconExitbold":
                            Settings.TrayiconExitbold = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "TrayiconManagenotesbold":
                            Settings.TrayiconManagenotesbold = xmlread.ReadElementContentAsBoolean();
                            break;
                        case "TrayiconSettingsbold":
                            Settings.TrayiconSettingsbold = xmlread.ReadElementContentAsBoolean();
                            break;
                        //ints
                        case "FontContentSize":
                            Settings.FontContentSize = xmlread.ReadElementContentAsInt();
                            break;
                        case "FontTextdirection":
                            Settings.FontTextdirection = xmlread.ReadElementContentAsInt();
                            break;
                        case "FontTitleSize":
                            Settings.FontTitleSize = xmlread.ReadElementContentAsInt();
                            break;
                        case "NetworkConnectionTimeout":
                            Settings.NetworkConnectionTimeout = xmlread.ReadElementContentAsInt();
                            break;
                        case "NotesDefaultColor":
                            Settings.NotesDefaultSkinnr = xmlread.ReadElementContentAsInt();
                            break;
                        case "NotesWarnLimit":
                            Settings.NotesWarnLimit = xmlread.ReadElementContentAsInt();
                            break;
                        case "NotesTransparencyLevel":
                            Settings.NotesTransparencyLevel = xmlread.ReadElementContentAsDouble();
                            break;
                        case "TrayiconLeftclickaction":
                            Settings.TrayiconLeftclickaction = xmlread.ReadElementContentAsInt();
                            break;
                        case "UpdatecheckEverydays":
                            Settings.UpdatecheckEverydays = xmlread.ReadElementContentAsInt();
                            break;
                        //strings (put at bottom in the settings file for more performance because then there are less characters to compare&skip)
                        case "FontContentFamily":
                            Settings.FontContentFamily = xmlread.ReadElementContentAsString();
                            break;
                        case "FontTitleFamily":
                            Settings.FontTitleFamily = xmlread.ReadElementContentAsString();
                            break;
                        case "NetworkProxyAddress":
                            Settings.NetworkProxyAddress = xmlread.ReadElementContentAsString();
                            break;
                        case "NotesSavepath":
                            Settings.NotesSavepath = xmlread.ReadElementContentAsString();
                            break;
                        case "SocialEmailDefaultadres":
                            Settings.SocialEmailDefaultadres = xmlread.ReadElementContentAsString();
                            break;
                        case "SocialTwitterUsername":
                            Settings.SocialTwitterUsername = xmlread.ReadElementContentAsString();
                            break;
                        case "UpdatecheckLastDate":
                            Settings.UpdatecheckLastDate = xmlread.ReadElementContentAsString();
                            break;
                    }
                    if (xmlread.Depth > 8)
                    {
                        break;
                    }
                }
            }
            finally
            {
                xmlread.Close();
            }
            return true;
        }

        /// <summary>
        /// Gets all skins from skin file.
        /// create Application data folder if does not exist.
        /// Create default SKINFILE if not exist.
        /// </summary>
        /// <returns></returns>
        public static List<Skin> LoadSkins()
        {
            if (!Directory.Exists(Program.AppDataFolder))
            {
                Directory.CreateDirectory(Program.AppDataFolder);
            }
            string skinfilepath = Path.Combine(Program.AppDataFolder, SKINFILE);
            if (!File.Exists(skinfilepath))
            {
                WriteDefaultSkins(skinfilepath);
            }
            List<Skin> skins = new List<Skin>();
            xmlread = new XmlTextReader(skinfilepath);
            xmlread.ProhibitDtd = true;
            Skin curskin = null;
            int numskins = 0;
            bool endtag = false;
            while (xmlread.Read())
            {
                switch (xmlread.Name)
                {
                    case "skins":
                        if (xmlread.HasAttributes)
                        {
                            skins.Capacity = Convert.ToInt32(xmlread.GetAttribute("count"));
                        }
                        break;
                    case "skin":
                        if (endtag)
                        {
                            if (curskin != null && numskins < 255)
                            {
                                skins.Add(curskin);
                            }
                        }
                        else if (!endtag)
                        {
                            numskins++;
                            curskin = new Skin();
                        }
                        endtag = !endtag;
                        break;
                    case "Name":
                        curskin.Name = xmlread.ReadElementContentAsString();
                        break;
                    case "ForegroundColor":
                        curskin.ForegroundClr = ConvToClr(xmlread.ReadElementContentAsString());
                        break;
                    case "BackgroundColor":
                        curskin.BackgroundClr = ConvToClr(xmlread.ReadElementContentAsString());
                        break;
                    case "HighlightColor":
                        curskin.HighlightClr = ConvToClr(xmlread.ReadElementContentAsString());
                        break;
                }
                if (xmlread.Depth > 3)
                {
                    throw new CustomException("Skin file corrupted: "+SKINFILE);
                }
            }
            return skins;
        }

        /// <summary>
        /// Load a note file.
        /// </summary>
        /// <param name="n">pointer to notes</param>
        /// <param name="notefilepath"></param>
        /// <returns>An note object</returns>
        public static Note LoadNote(Notes n, string notefilename)
        {
            Note note = new Note(n, notefilename);
            xmlread = new XmlTextReader(Path.Combine(Settings.NotesSavepath, notefilename));
            xmlread.ProhibitDtd = true;
            bool isset_linenumoffsetcontent = false;
            try
            {
                while (xmlread.Read())
                {
                    if (xmlread.Name != String.Empty)
                    {
                        switch (xmlread.Name)
                        {
                            case "visible":
                                note.Visible = xmlread.ReadElementContentAsBoolean();
                                break;
                            case "ontop":
                                note.Ontop = xmlread.ReadElementContentAsBoolean();
                                break;
                            case "locked":
                                note.Locked = xmlread.ReadElementContentAsBoolean();
                                break;
                            case "width":
                                note.Width = xmlread.ReadElementContentAsInt();
                                break;
                            case "heigth":
                                note.Height = xmlread.ReadElementContentAsInt();
                                break;
                            case "x":
                                note.X = xmlread.ReadElementContentAsInt();
                                break;
                            case "y":
                                note.Y = xmlread.ReadElementContentAsInt();
                                break;
                            case "skin":
                                int skinnr = n.GetSkinNr(xmlread.ReadElementContentAsString());
                                if (skinnr >= 0)
                                {
                                    note.SkinNr = skinnr;
                                }
                                break;
                            case "title":
                                note.Title = xmlread.ReadElementContentAsString();
                                break;
                            case "content":
                                if (!isset_linenumoffsetcontent)
                                {
                                    note.linenumoffsetcontent = Convert.ToUInt32(xmlread.LineNumber);
                                    isset_linenumoffsetcontent = true;
                                }
                                break;
                        }
                        if (xmlread.Depth > 5)
                        {
                            throw new CustomException("note file corrupted: " + notefilename);
                        }
                    }
                }
            }
            finally
            {
                xmlread.Close();
            }
            return note;
        }

        /// <summary>
        /// Write the default settings.
        /// Used for if SETTINGSFILE is not created yet.
        /// </summary>
        /// <returns></returns>
        public static bool WriteDefaultSettings()
        {
            Settings.ConfirmDeletenote = true;
            Settings.ConfirmExit = false;
            Settings.ConfirmLinkclick = true;
            Settings.FontContentFamily = "Arial";
            Settings.FontContentSize = 11;
            Settings.FontTextdirection = 1;
            Settings.FontTitleFamily = "Arial";
            Settings.FontTitleSize = 14;
            Settings.FontTitleStylebold = true;
            Settings.HighlightHTML = false;
            Settings.HighlightHyperlinks = true;
            Settings.HighlightPHP = false;
            Settings.HighlightSQL = false;
            Settings.NetworkConnectionForceipv6 = false;
            Settings.NetworkConnectionTimeout = 8000;
            Settings.NetworkProxyAddress = String.Empty;
            Settings.NetworkProxyEnabled = false;
            Settings.NotesClosebtnHidenotepermanently = true;
            Settings.NotesClosebtnTooltipenabled = false;
            Settings.NotesDefaultSkinnr = 1;
            Settings.NotesSavepath = Program.AppDataFolder;
            Settings.NotesTransparencyEnabled = true;
            Settings.NotesTransparencyLevel = 0.9;
            Settings.NotesWarnLimit = 200;
            Settings.ProgramFirstrun = true;
            Settings.ProgramLogError = true;
            Settings.ProgramLogException = true;
            Settings.ProgramLogInfo = false;
            Settings.SocialEmailDefaultadres = String.Empty;
            Settings.SocialEmailEnabled = true;
            Settings.SocialFacebookEnabled = true;
            Settings.SocialFacebookUseSSL = true;
            Settings.SocialTwitterEnabled = true;
            Settings.SocialTwitterUsername = String.Empty;
            Settings.SocialTwitterUseSSL = true;
            Settings.TrayiconLeftclickaction = 1;
            Settings.TrayiconCreatenotebold = true;
            Settings.TrayiconExitbold = false;
            Settings.TrayiconManagenotesbold = false;
            Settings.TrayiconSettingsbold = false;
            Settings.UpdatecheckEverydays = 0; //0 is disabled.
            Settings.UpdatecheckLastDate = DateTime.Now.ToString();
            try
            {
                WriteSettings();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Write a note xml file.
        /// </summary>
        /// <param name="notefilename">the filename not path</param>
        /// <param name="note">The note object</param>
        /// <param name="content">The note content</param>
        /// <returns>true on succeeded</returns>
        public static bool WriteNote(string notefilename, Note note, string content)
        {
            bool succeeded = false;
            xmlwrite = new XmlTextWriter(Path.Combine(Settings.NotesSavepath, notefilename), System.Text.Encoding.UTF8);
            xmlwrite.Formatting = Formatting.Indented;
            try
            {
                xmlwrite.WriteStartDocument();
                xmlwrite.WriteStartElement("note");
                xmlwrite.WriteAttributeString("version", NOTEVERSION);
                WriteXMLBool("visible", note.Visible);
                WriteXMLBool("ontop", note.Ontop);
                WriteXMLBool("locked", note.Locked);
                xmlwrite.WriteStartElement("location");
                xmlwrite.WriteElementString("x", note.X.ToString());
                xmlwrite.WriteElementString("y", note.Y.ToString());
                xmlwrite.WriteEndElement();
                xmlwrite.WriteStartElement("size");
                xmlwrite.WriteElementString("width", Convert.ToString(note.Width));
                xmlwrite.WriteElementString("heigth", Convert.ToString(note.Height));
                xmlwrite.WriteEndElement();
                xmlwrite.WriteElementString("skin", note.GetSkinName());
                xmlwrite.WriteElementString("title", note.Title);
                xmlwrite.WriteElementString("content", content);
                xmlwrite.WriteEndElement();
                xmlwrite.WriteEndDocument();
                succeeded = true;
            }
            catch
            {
                succeeded = false;
            }
            finally
            {
                xmlwrite.Flush();
                xmlwrite.Close();
            }
            //CheckFile();
            return succeeded;
        }

        /// <summary>
        /// Write settings file.
        /// </summary>
        /// <returns>true if succeed.</returns>
        public static bool WriteSettings()
        {
            NumberFormatInfo numfmtinfo = CultureInfo.InvariantCulture.NumberFormat;
            try
            {
                xmlwrite = new XmlTextWriter(Path.Combine(Program.AppDataFolder, SETTINGSFILE), System.Text.Encoding.UTF8);
                xmlwrite.Formatting = Formatting.Indented;
                xmlwrite.WriteStartDocument();
                xmlwrite.WriteStartElement("settings");
                //bools
                WriteXMLBool("ConfirmDeleteNote", Settings.ConfirmDeletenote);
                WriteXMLBool("ConfirmExit", Settings.ConfirmExit);
                WriteXMLBool("ConfirmLinkclick", Settings.ConfirmLinkclick);
                WriteXMLBool("FontTitleStylebold", Settings.FontTitleStylebold);
                WriteXMLBool("HighlightHTML", Settings.HighlightHTML);
                WriteXMLBool("HighlightHyperlinks", Settings.HighlightHyperlinks);
                WriteXMLBool("HighlightPHP", Settings.HighlightPHP);
                WriteXMLBool("HighlightSQL", Settings.HighlightSQL);
                WriteXMLBool("NetworkConnectionForceipv6", Settings.NetworkConnectionForceipv6);
                WriteXMLBool("NetworkProxyEnabled", Settings.NetworkProxyEnabled);
                WriteXMLBool("NotesClosebtnHidenotepermanently", Settings.NotesClosebtnHidenotepermanently);
                WriteXMLBool("NotesClosebtnTooltipenabled", Settings.NotesClosebtnTooltipenabled);
                WriteXMLBool("NotesTransparencyEnabled", Settings.NotesTransparencyEnabled);
                WriteXMLBool("ProgramFirstrun",Settings.ProgramFirstrun);
                WriteXMLBool("ProgramLogError", Settings.ProgramLogError);
                WriteXMLBool("ProgramLogException", Settings.ProgramLogException);
                WriteXMLBool("ProgramLogInfo", Settings.ProgramLogInfo);
                WriteXMLBool("SocialEmailEnabled", Settings.SocialEmailEnabled);
                WriteXMLBool("SocialFacebookEnabled", Settings.SocialFacebookEnabled);
                WriteXMLBool("SocialFacebookSavesession", Settings.SocialFacebookSavesession);
                WriteXMLBool("SocialFacebookUseSSL", Settings.SocialFacebookUseSSL);
                WriteXMLBool("SocialTwitterEnabled", Settings.SocialTwitterEnabled);
                WriteXMLBool("SocialTwitterUseSSL", Settings.SocialTwitterUseSSL);
                WriteXMLBool("TrayiconCreatenotebold", Settings.TrayiconCreatenotebold);
                WriteXMLBool("TrayiconExitbold", Settings.TrayiconExitbold);
                WriteXMLBool("TrayiconManagenotesbold", Settings.TrayiconManagenotesbold);
                WriteXMLBool("TrayiconSettingsbold", Settings.TrayiconSettingsbold);
                //ints
                xmlwrite.WriteElementString("FontContentSize", Settings.FontContentSize.ToString(numfmtinfo));
                xmlwrite.WriteElementString("FontTextdirection", Settings.FontTextdirection.ToString(numfmtinfo));
                xmlwrite.WriteElementString("FontTitleSize", Settings.FontTitleSize.ToString(numfmtinfo));
                xmlwrite.WriteElementString("NetworkConnectionTimeout", Settings.NetworkConnectionTimeout.ToString(numfmtinfo));
                xmlwrite.WriteElementString("NotesDefaultSkinnr", Settings.NotesDefaultSkinnr.ToString(numfmtinfo));
                xmlwrite.WriteElementString("NotesTransparencyLevel", Settings.NotesTransparencyLevel.ToString(numfmtinfo));
                xmlwrite.WriteElementString("NotesWarnLimit", Settings.NotesWarnLimit.ToString(numfmtinfo));
                xmlwrite.WriteElementString("TrayiconLeftclickaction", Settings.TrayiconLeftclickaction.ToString(numfmtinfo));
                xmlwrite.WriteElementString("UpdatecheckEverydays", Settings.UpdatecheckEverydays.ToString(numfmtinfo));
                //strings
                xmlwrite.WriteElementString("UpdatecheckLastDate", Settings.UpdatecheckLastDate.ToString());
                xmlwrite.WriteElementString("FontContentFamily", Settings.FontContentFamily);
                xmlwrite.WriteElementString("FontTitleFamily", Settings.FontTitleFamily);
                xmlwrite.WriteElementString("NetworkProxyAddress", Settings.NetworkProxyAddress);
                xmlwrite.WriteElementString("NotesSavepath", Settings.NotesSavepath);
                xmlwrite.WriteElementString("SocialEmailDefaultadres", Settings.SocialEmailDefaultadres);
                xmlwrite.WriteElementString("SocialTwitterUsername", Settings.SocialTwitterUsername);
                xmlwrite.WriteEndElement();
                xmlwrite.WriteEndDocument();
            } finally
            {
                xmlwrite.Close();
            }
            //CheckFile();
            return true;
        }

        public static bool WriteNotesBackupFile(string filenamepath, Notes notes)
        {
            bool succeeded = false;
            try {
                xmlwrite = new XmlTextWriter(filenamepath, System.Text.Encoding.UTF8);
                xmlwrite.Formatting = Formatting.Indented;
                xmlwrite.WriteStartDocument();
                xmlwrite.WriteStartElement("backupnotes");
                xmlwrite.WriteAttributeString("number", notes.CountNotes.ToString());
                for (int i = 0; i < notes.CountNotes; i++)
                {
                    xmlwrite.WriteStartElement("note");
                    xmlwrite.WriteAttributeString("version", NOTEVERSION);
                    WriteXMLBool("visible", notes.GetNote(i).Visible);
                    WriteXMLBool("ontop", notes.GetNote(i).Ontop);
                    WriteXMLBool("locked", notes.GetNote(i).Locked);
                    xmlwrite.WriteStartElement("location");
                    xmlwrite.WriteElementString("x", notes.GetNote(i).X.ToString());
                    xmlwrite.WriteElementString("y", notes.GetNote(i).Y.ToString());
                    xmlwrite.WriteEndElement();
                    xmlwrite.WriteStartElement("size");
                    xmlwrite.WriteElementString("width", notes.GetNote(i).Width.ToString() );
                    xmlwrite.WriteElementString("heigth", notes.GetNote(i).Height.ToString() );
                    xmlwrite.WriteEndElement();
                    xmlwrite.WriteElementString("skin", notes.GetNote(i).GetSkinName());
                    xmlwrite.WriteElementString("title", notes.GetNote(i).Title);
                    xmlwrite.WriteElementString("content", notes.GetNote(i).GetContent());
                    xmlwrite.WriteEndElement();
                }

                xmlwrite.WriteEndElement();
                xmlwrite.WriteEndDocument();
                succeeded =true;
            }
            finally
            {
                xmlwrite.Close();
            }
            return succeeded;
        }

        // Private Methods (3) 

        private static System.Drawing.Color ConvToClr(string colorstring)
        {
            //HEX color
            return System.Drawing.ColorTranslator.FromHtml(colorstring);

            //DECIMAL color, commented out in favor of HEX notation for speed.
            //string[] parts = new string[3];
            //parts = colorstring.Split(',');
            //try
            //{
            //    UInt16 redchannel = Convert.ToUInt16(parts[0].Trim());
            //    UInt16 greenchannel = Convert.ToUInt16(parts[1].Trim());
            //    UInt16 bluechannel = Convert.ToUInt16(parts[2].Trim());
            //    return System.Drawing.Color.FromArgb(redchannel, greenchannel, bluechannel);
            //}
            //catch
            //{
            //    if (colorstring.Length < 100)
            //    {
            //        throw new CustomException("Cannot parser: " + colorstring);
            //    }
            //    else
            //    {
            //        throw new CustomException("Cannot parser: " + colorstring.Substring(0, 100)+" ..");
            //    }
            //}
        }

        /// <summary>
        /// Writes the default skins to the SKINFILE.
        /// Used for if SKINFILE is not created yet.
        /// </summary>
        /// <param name="filename"></param>
        private static void WriteDefaultSkins(string filename)
        {
            try
            {
                xmlwrite = new XmlTextWriter(filename, System.Text.Encoding.UTF8);
                xmlwrite.Formatting = Formatting.Indented;
                xmlwrite.WriteStartDocument();
                xmlwrite.WriteStartElement("skins");
                xmlwrite.WriteAttributeString("count", "7"); //for performance predefine list Capacity, not required.
                
                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "yellow");
                xmlwrite.WriteElementString("ForegroundColor", "#FFD800");
                xmlwrite.WriteElementString("BackgroundColor", "#E5B61B");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "orange");
                xmlwrite.WriteElementString("ForegroundColor", "#FF6A00");
                xmlwrite.WriteElementString("BackgroundColor", "#EF6F1F");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "white");
                xmlwrite.WriteElementString("ForegroundColor", "#FFFFFF");
                xmlwrite.WriteElementString("BackgroundColor", "#26262C");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "green");
                xmlwrite.WriteElementString("ForegroundColor", "#6FE200");
                xmlwrite.WriteElementString("BackgroundColor", "#008000");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "blue");
                xmlwrite.WriteElementString("ForegroundColor", "#5A86D5");
                xmlwrite.WriteElementString("BackgroundColor", "#1A1AFF");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "purple");
                xmlwrite.WriteElementString("ForegroundColor", "#FF1AFF");
                xmlwrite.WriteElementString("BackgroundColor", "#8B1A8B");
                xmlwrite.WriteElementString("HighlightColor", "#FF0000");
                xmlwrite.WriteEndElement();

                xmlwrite.WriteStartElement("skin");
                xmlwrite.WriteElementString("Name", "red");
                xmlwrite.WriteElementString("ForegroundColor", "#FF1A1A");
                xmlwrite.WriteElementString("BackgroundColor", "#7A1515");
                xmlwrite.WriteElementString("HighlightColor", "#FFA500");
                xmlwrite.WriteEndElement();

                
                xmlwrite.WriteEndElement();
                xmlwrite.WriteEndDocument();
            }
            finally
            {
                xmlwrite.Close();
            }
        }

        /// <summary>
        /// Write 1 value for true and 0 for false.
        /// </summary>
        /// <param name="checknode"></param>
        private static void WriteXMLBool(String element, bool checknode)
        {
            xmlwrite.WriteStartElement(element);
            if (checknode)
            {
                xmlwrite.WriteString("1");
            }
            else
            {
                xmlwrite.WriteString("0");
            }
            xmlwrite.WriteEndElement();
        }

        #endregion Methods
    }
}