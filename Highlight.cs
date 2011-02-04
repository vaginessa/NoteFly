﻿//-----------------------------------------------------------------------
// <copyright file="TextHighlight.cs" company="GNU">
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
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Xml;

    /// <summary>
    /// Highlight class, provides highlighting to richtext.
    /// </summary>
    public class Highlight
    {
        #region Fields (4)

        private static bool keywordsinit = false;
        private static string[] keywords_html;
        private static string[] keywords_php;
        private static string[] keywords_sql;
        private const string phpstartkeyword = "<?php";
        private const string phpendkeyword = "?>";
        private static string phplinecomment = "//";

        #endregion Fields

        public static bool KeywordsInitialized
        {
            get
            {
                return keywordsinit;
            }
        }

        #region Methods (3)

        // Public Methods (2) 

        /// <summary>
        /// Initializes TextHighlighter fill the keywords lists.
        /// </summary>
        /// <param name="rtb">The richedit note content</param>
        /// <param name="checkhtml">indicteds wheter html is gonna be checked</param>
        public static void InitHighlighter()
        {
            if (Settings.HighlightHTML)
            {
                keywords_html = xmlUtil.ParserLanguageLexical("langs.xml", "html");
            }

            if (Settings.HighlightPHP)
            {
                keywords_php = xmlUtil.ParserLanguageLexical("langs.xml", "php");
            }

            if (Settings.HighlightSQL)
            {
                keywords_sql = xmlUtil.ParserLanguageLexical("langs.xml", "sql");
            }

            keywordsinit = true;
        }

        /// <summary>
        /// Clear the keywords list.
        /// </summary>
        public static void DeinitHighlighter()
        {
            if (keywords_html != null)
            {
                keywords_html = null;
            }
            if (keywords_php != null)
            {
                keywords_php = null;
            }
            if (keywords_sql != null)
            {
                keywords_sql = null;
            }
            keywordsinit = false;
            GC.Collect();
        }

        /// <summary>
        /// Check the syntax of alle set languages on the RichTextbox RTF content.
        /// </summary>
        /// <param name="rtb"></param>
        /// <param name="skinnr"></param>
        /// <param name="notes"></param>
        public static void CheckSyntaxFull(RichTextBox rtb, int skinnr, Notes notes)
        {
            int cursorpos = rtb.SelectionStart;
            ResetHighlighting(rtb, skinnr, notes);
            if (Settings.HighlightHTML || Settings.HighlightPHP || Settings.HighlightSQL)
            {
                if (!keywordsinit)
                {
                    Log.Write(LogType.error, "Keywords not initialized as they should already have. Hotfixing this, watchout memory use.");
                    InitHighlighter();
                }

                bool ishtmlendtag = false;
                int posstarthtmltag = 0;
                int posstartphp = int.MaxValue;
                int posendphp = int.MaxValue;
                int posstartphplinecomment = 0;
                int lencommentline = 0;
                int poslastphpkeyword = 0;
                for (int i = 0; i < rtb.TextLength; i++)
                {
                    switch (rtb.Text[i])
                    {
                        case '<':
                            if (Settings.HighlightPHP)
                            {
                                if (i + 5 <= rtb.TextLength)
                                {
                                    if (rtb.Text.Substring(i, 5) == phpstartkeyword)
                                    {
                                        //start php part
                                        posstartphp = i; //+ phpstartkeyword.Length;
                                        ColorText(rtb, i, phpstartkeyword.Length, Color.Green);
                                        poslastphpkeyword = posstartphp + phpstartkeyword.Length;
                                    }
                                }
                            }
                            if (Settings.HighlightHTML)
                            {
                                if (i < posstartphp || i > posendphp)
                                {
                                    posstarthtmltag = i;
                                }
                            }
                            break;
                        case '>':
                            if (Settings.HighlightPHP)
                            {
                                if (i > 6)
                                {
                                    if (rtb.Text.Substring(i - 1, phpendkeyword.Length) == phpendkeyword)
                                    {
                                        //end php part
                                        posendphp = i + phpendkeyword.Length;
                                        ColorText(rtb, posendphp - phpendkeyword.Length - 1, phpendkeyword.Length, Color.Green);
                                    }
                                }
                            }
                            if (Settings.HighlightHTML)
                            {
                                if ((i < posstartphp || i > posendphp) && i > 0)
                                {
                                    int lenhtmltag = i - posstarthtmltag + 1;
                                    string ishtml = rtb.Text.Substring(posstarthtmltag, lenhtmltag);
                                    ValidatingHtmlTag(ishtml, rtb, posstarthtmltag, lenhtmltag);
                                }
                            }
                            break;
                        case '/':
                            if (Settings.HighlightPHP)
                            {
                                if (i < rtb.TextLength && i > posstartphp && i < posendphp)
                                {
                                    if (rtb.Text.Substring(i, phplinecomment.Length) == phplinecomment)
                                    {
                                        posstartphplinecomment = i;
                                    }
                                }
                            }
                            break;
                        case '\n':
                            if (Settings.HighlightPHP)
                            {
                                if (posstartphplinecomment != 0)
                                {
                                    lencommentline = i - posstartphplinecomment;
                                    ColorText(rtb, posstartphplinecomment, lencommentline, Color.Gray);
                                    posstartphplinecomment = 0;
                                }
                                poslastphpkeyword = i + 1; //+1 for '\n'
                            }
                            break;
                        case ' ':
                            if (Settings.HighlightPHP)
                            {
                                if (i > posstartphp && i < posendphp - phpendkeyword.Length)
                                {
                                    int lenphpkeyword = i - poslastphpkeyword;
                                    if (lenphpkeyword > 0)
                                    {
                                        string isphp = rtb.Text.Substring(poslastphpkeyword, lenphpkeyword);
                                        if (ValidatingPhp(isphp))
                                        {
                                            ColorText(rtb, poslastphpkeyword, lenphpkeyword, Color.DarkCyan);
                                        }
                                        else
                                        {
                                            ColorText(rtb, poslastphpkeyword, lenphpkeyword, Color.DarkRed);
                                        }
                                    }
                                    poslastphpkeyword = i + 1; //+1 for ' '
                                }
                            }
                            break;
                    }
                }
            }
            rtb.SelectionStart = cursorpos;
        }

        /// <summary>
        /// Color some part of the rich edit text.
        /// </summary>
        /// <param name="posstart">The start position</param>
        /// <param name="len">The lenght</param>
        /// <param name="color">The color the text should get.</param>
        private static void ColorText(RichTextBox rtb, int posstart, int len, Color color)
        {
            try
            {
                rtb.Select(posstart, len);
                rtb.SelectionColor = color;
            }
            catch (ArgumentOutOfRangeException arg)
            {
                throw new CustomException("TextHighlighter out of range: " + arg.Source);
            }
        }

        /// <summary>
        /// Make the whole text the default font color.
        /// </summary>
        /// <param name="rtb">The richedit control that hold the note content.</param>
        private static void ResetHighlighting(RichTextBox rtb, int skinnr, Notes notes)
        {
            rtb.ForeColor = notes.GetTextClr(skinnr);
            rtb.SelectAll();
            rtb.SelectionColor = notes.GetTextClr(skinnr);
            rtb.Select(0, 0);
        }

        /// <summary>
        /// Highlight known tag and tag attributes.
        /// </summary>
        /// <param name="ishtml">Is it html to check.</param>
        /// <returns>true if it is html</returns>
        private static void ValidatingHtmlTag(string ishtml, RichTextBox rtb, int posstarthtmltag, int lenhtmltag)
        {
            bool isquotestring = false;
            int posstartquotestring = int.MaxValue;
            bool endtag = false;
            int lenhighlight = 0;
            if (ishtml[1] == '/')
            {
                endtag = true;
                ishtml = ishtml.Remove(1, 1); //e.g. "</title>" becomes "<title>"
            }
            if (ishtml.Length > 2)
            {
                if (ishtml[ishtml.Length - 2] == '/') //finds <br />
                {
                    endtag = true;
                    if (ishtml[ishtml.Length - 3] == ' ') 
                    {
                        ishtml = ishtml.Remove(ishtml.Length - 2, 2); //e.g. <br /> becomes <br>
                    }
                    else
                    {
                        ishtml = ishtml.Remove(ishtml.Length - 2, 1); //e.g. <wrong/> becomes <wrong>
                    }
                }
            }
            ishtml = ishtml.ToLower(); //e.g. "<BR>" becomes "<br>"

            int lastpos = 1;
            int posendattributevalue = int.MaxValue;
            for (int pos = 1; pos < ishtml.Length; pos++)
            {
                if (ishtml[pos] == '"' || ishtml[pos] == '\'')
                {
                    if (isquotestring)
                    {
                        ColorText(rtb, posstarthtmltag+posstartquotestring, (pos - posstartquotestring+1), Color.Gray); //+1 for quote itself
                    }
                    else
                    {
                        posstartquotestring = pos;
                    }
                    isquotestring = !isquotestring;
                }
                else if ((ishtml[pos] == ' ') || (ishtml[pos] == '>') && (pos < posstartquotestring))
                {
                    string curattribute = ishtml.Substring(lastpos, pos - lastpos);
                    string[] curattributeparts = curattribute.Split('='); //split atribute name and valeau.
                    bool attributefound = false;
                    /*
                    if (endtag)
                    {
                        lenhighlight = pos - lastpos + 1;
                    }
                    else
                    {
                        lenhighlight = pos - lastpos;
                    }
                     */
                    string curattributename = curattributeparts[0];
                    if (endtag)
                    {
                        lenhighlight = curattributename.Length + 1;
                    }
                    else
                    {
                        lenhighlight = curattributename.Length;
                    }
                    for (int n = 0; n < keywords_html.Length; n++)
                    {
                        if (curattributename.Equals(keywords_html[n], StringComparison.InvariantCultureIgnoreCase))
                        {
                            attributefound = true;
                            ColorText(rtb, posstarthtmltag + lastpos, lenhighlight, Color.Blue); //known attribute
                            break;
                        }
                    }
                    if (!attributefound)
                    {
                        ColorText(rtb, posstarthtmltag + lastpos, lenhighlight, Color.Red);
                    }
                    lastpos = pos + 1;
                }
            }
        }

        /// <summary>
        /// Find out if it is a php keyword.
        /// </summary>
        /// <param name="isphp"></param>
        /// <returns></returns>
        private static bool ValidatingPhp(string isphp)
        {
            isphp.ToLower();
            for (int i = 0; i < keywords_php.Length; i++)
            {
                if (isphp == keywords_php[i])
                {
                    return true;
                }
            }
            return false;
        }

        #endregion Methods
    }

}
