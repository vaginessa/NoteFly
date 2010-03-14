﻿/* Copyright (C) 2009-2010
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
using System;
using System.Windows.Forms;

namespace NoteFly
{
    /// <summary>
    /// A editbox made for typing in a IP address their IP version4 or IP version6 address.
    /// </summary>
    public partial class IPTextBox : UserControl
    {
        private IPaddrType addrtype;

        /// <summary>
        /// The types of address
        /// </summary>
        public enum IPaddrType
        {
            ipv4,
            ipv6
        }

        #region Constructors (1)

        public IPTextBox()
        {
            this.InitializeComponent();
        }

        #endregion Constructors

        #region Methods (2)

        // Public Methods (2) 

        public string GetIPAddress()
        {
            return this.tbIPaddress.Text;
        }

        public void SetIPAddress(string addr)
        {
            this.tbIPaddress.Text = addr;
        }
        
        /// <summary>
        /// Filter out illgale charcters
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbIPaddress_KeyDown(object sender, KeyEventArgs e)
        {
            int k = e.KeyValue;
            int numpoint = 0;
            int lastpoint = -10;
            for (int i = 0; i < this.tbIPaddress.Text.Length; i++)
            {
                if (this.tbIPaddress.Text[i] == '.')
                {
                    lastpoint = i;
                    numpoint++;
                }
            }

            // 'a'-'f'
            if (k >= 65 && k <= 70)
            {
                this.addrtype = IPaddrType.ipv6;
            }
            // ':'
            else if (k == 186 && e.Shift)
            {
                if (this.addrtype == IPaddrType.ipv4)
                {
                    MessageBox.Show("can't mix ipv4 and ipv6 seperators."); 
                }

                if (this.tbIPaddress.TextLength == 0)
                {
                    e.SuppressKeyPress = true;
                    //MessageBox.Show("IP v6 adress cannot start with a doublepoint.");
                }

                this.addrtype = IPaddrType.ipv6;
            }
            //'.'
            else if (k == 190 && !e.Shift)
            {
                if (numpoint >= 3)
                {
                    e.SuppressKeyPress = true;
                }
                else if (lastpoint == this.tbIPaddress.Text.Length - 1)
                {
                    e.SuppressKeyPress = true;
                }
                else if ((lastpoint < this.tbIPaddress.Text.Length - 4) && (lastpoint != -10))
                {
                    e.SuppressKeyPress = true;
                }
                else if ((this.tbIPaddress.Text.Length == 0) && (k == 190))
                {
                    e.SuppressKeyPress = true;
                }
                if (this.addrtype == IPaddrType.ipv6) 
                {
                    MessageBox.Show("can't mix ipv4 and ipv6 seperators. Don't use dots for ip v6."); 
                }
                this.addrtype = IPaddrType.ipv4;
            }
            //'0'-'9'
            else if (k >= 48 && k <= 57)
            {
                if ((lastpoint < this.tbIPaddress.Text.Length - 3) && (lastpoint != -10) && (this.addrtype == IPaddrType.ipv4))
                {
                    e.SuppressKeyPress = true;
                }
                else
                {
                    e.SuppressKeyPress = false;
                }
            }
            //shift, backspace, left. right, delete  key
            else if (k == 8 || k == 16 || k == 37 || k == 39 || k == 46)
            {
                e.SuppressKeyPress = false;
            }
            else
            {
                //MessageBox.Show("key="+k);
                e.SuppressKeyPress = true;
            }
        }

        #endregion Methods




    }
}
