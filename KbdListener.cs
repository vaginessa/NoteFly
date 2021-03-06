//-----------------------------------------------------------------------
// <copyright file="KbdListener.cs" author="Dominique Bijnens">
// Licenced: CPOL 
// http://www.codeproject.com/info/cpol10.aspx
// </copyright>
//-----------------------------------------------------------------------
namespace NoteFly
{
    using System;
    using System.ComponentModel;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// The KeyboardListener is a static class that allows registering a number
    /// of event handlers that you want to get called in case some keyboard key is pressed 
    /// or released. The nice thing is that this KeyboardListener is also active in case
    /// the parent application is running in the back.
    /// </summary>
    [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "SkipVerification")]
    public class KeyboardListener
    {
        #region Private declarations

        /// <summary>
        /// The Window that intercepts Keyboard messages
        /// </summary>
        private static ListeningWindow s_Listener;

        #endregion

        #region Public methods

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardListener" /> class.
        /// </summary>
        public KeyboardListener()
        {
            ListeningWindow.KeyDelegate aKeyDelegate = new ListeningWindow.KeyDelegate(this.KeyHandler);
            s_Listener = new ListeningWindow(aKeyDelegate);
        }

        #endregion

        /// <summary>
        /// For every application thread that is interested in keyboard events
        /// an EventHandler can be added to this variable
        /// </summary>
        public event EventHandler s_KeyEventHandler;

        #region Private methods
        /// <summary>
        /// The function that will handle all keyboard activity signaled by the ListeningWindow.
        /// In this context handling means calling all registered subscribers for every key pressed / released.
        /// </summary>
        /// <remarks>
        /// Inside this method the events could also be fired by calling
        /// s_KeyEventHandler(null,new KeyEventArgs(key,msg)) However, in case one of the registered
        /// subscribers throws an exception, execution of the non-executed subscribers is cancelled.
        /// </remarks>
        /// <param name="key">Key</param>
        /// <param name="msg">Msg</param>
        private void KeyHandler(ushort key, uint msg)
        {
            if (this.s_KeyEventHandler != null)
            {
                Delegate[] delegates = this.s_KeyEventHandler.GetInvocationList();
                foreach (Delegate del in delegates)
                {
                    EventHandler sink = (EventHandler)del;

                    try
                    {
                        // This is a static class, therefore null is passed as the object reference
                        sink(null, new UniversalKeyEventArgs(key, msg));
                    }
                    catch
                    {
                        Log.Write(LogType.exception, "KeyHandler unknown exception");
                    }
                }
            }
        }
        #endregion

        #region Public declarations

        /// <summary>
        /// An instance of this class is passed when Keyboard events are fired by the KeyboardListener.
        /// </summary>
        public class UniversalKeyEventArgs : KeyEventArgs
        {
            /// <summary>
            /// keymessage
            /// </summary>
            public readonly uint m_Msg;

            /// <summary>
            /// keycode
            /// </summary>
            public readonly ushort m_Key;

            /// <summary>
            /// New instance of an universal key event argument object
            /// </summary>
            /// <param name="aKey"></param>
            /// <param name="aMsg"></param>
            public UniversalKeyEventArgs(ushort aKey, uint aMsg) : base((Keys)aKey)
            {
                this.m_Msg = aMsg;
                this.m_Key = aKey;
            }
        }

        #endregion

        #region Definition ListeningWindow class
        /// <summary>
        /// A ListeningWindow object is a Window that intercepts Keyboard events.
        /// </summary>
        private class ListeningWindow : NativeWindow
        {
            /// <summary>
            /// 
            /// </summary>
            private const int WS_CLIPCHILDREN = 0x02000000;

            /// <summary>
            /// 
            /// </summary>
            private const int WM_INPUT = 0x00FF;

            /// <summary>
            /// 
            /// </summary>
            private const int RIDEV_INPUTSINK = 0x00000100;

            /// <summary>
            /// 
            /// </summary>
            private const int RID_INPUT = 0x10000003;

            /// <summary>
            /// 
            /// </summary>
            private const int RIM_TYPEKEYBOARD = 1;

            /// <summary>
            /// Previous key message.
            /// </summary>
            private uint m_PrevMessage = 0;

            /// <summary>
            /// Previous control key.
            /// </summary>
            private ushort m_PrevControlKey = 0;

            /// <summary>
            /// Key delegate
            /// </summary>
            private KeyDelegate m_KeyHandler = null;

            /// <summary>
            /// Key delegate
            /// </summary>
            /// <param name="key"></param>
            /// <param name="msg"></param>
            public delegate void KeyDelegate(ushort key, uint msg);
            #endregion

            #region Private external methods

            // In case you want to have a comprehensive overview of calling conventions follow the next link:
            // http://www.codeproject.com/cpp/calling_conventions_demystified.asp

            [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern unsafe bool RegisterRawInputDevices(RAWINPUTDEV* rawInputDevices, uint numDevices, uint size);

            [DllImport("User32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
            [return: MarshalAs(UnmanagedType.I4)]
            internal static extern unsafe int GetRawInputData(void* hRawInput, uint uiCommand, byte* pData, uint* pcbSize, uint cbSizeHeader);

            #endregion

            #region Unsafe types
            /// <summary>
            /// RAWINPUTDEV struct
            /// </summary>
            internal unsafe struct RAWINPUTDEV 
            {
                /// <summary>
                /// 
                /// </summary>
                public ushort usUsagePage;

                /// <summary>
                /// 
                /// </summary>
                public ushort usUsage;

                /// <summary>
                /// 
                /// </summary>
                public uint dwFlags;

                /// <summary>
                /// 
                /// </summary>
                public void* hwndTarget;
            }

            /// <summary>
            /// RAWINPUTHEADER struct
            /// </summary>
            internal unsafe struct RAWINPUTHEADER 
            {
                /// <summary>
                /// Input type
                /// </summary>
                public uint dwType;

                /// <summary>
                /// 
                /// </summary>
                public uint dwSize;

                /// <summary>
                /// input hardware device pointer
                /// </summary>
                public void* hDevice;

                /// <summary>
                /// parameter pointer
                /// </summary>
                public void* wParam;
            }

            /// <summary>
            /// 
            /// </summary>
            internal unsafe struct RAWINPUTHKEYBOARD 
            {
                /// <summary>
                /// 
                /// </summary>
                public RAWINPUTHEADER header;

                /// <summary>
                /// 
                /// </summary>
                public ushort MakeCode;

                /// <summary>
                /// 
                /// </summary>
                public ushort Flags;

                /// <summary>
                /// 
                /// </summary>
                public ushort Reserved;

                /// <summary>
                /// 
                /// </summary>
                public ushort VKey;

                /// <summary>
                /// 
                /// </summary>
                public uint Message;

                /// <summary>
                /// 
                /// </summary>
                public uint ExtraInformation;
            }
            #endregion

            /// <summary>
            /// Creating an new listening window instance.
            /// </summary>
            /// <param name="keyHandlerFunction"></param>
            public ListeningWindow(KeyDelegate keyHandlerFunction)
            {
                this.m_KeyHandler = keyHandlerFunction;

                CreateParams cp = new CreateParams();

                // Fill in the CreateParams details.
                cp.Caption = "Hidden window";
                cp.ClassName = null;
                cp.X = 0x7FFFFFFF;
                cp.Y = 0x7FFFFFFF;
                cp.Height = 0;
                cp.Width = 0;
                ////cp.Parent = parent.Handle;
                cp.Style = WS_CLIPCHILDREN;

                // Create the actual invisible window
                this.CreateHandle(cp);

                // Register for Keyboard notification
                unsafe
                {
                    try
                    {
                        RAWINPUTDEV myRawDevice = new RAWINPUTDEV();
                        myRawDevice.usUsagePage = 0x01;
                        myRawDevice.usUsage = 0x06;
                        myRawDevice.dwFlags = RIDEV_INPUTSINK;
                        myRawDevice.hwndTarget = this.Handle.ToPointer();

                        if (RegisterRawInputDevices(&myRawDevice, 1, (uint)sizeof(RAWINPUTDEV)) == false) 
                        {
                            int err = Marshal.GetLastWin32Error();
                            throw new Win32Exception(err, "ListeningWindow::RegisterRawInputDevices");
                        }
                    }
                    catch 
                    {
                        throw; 
                    }
                }
            }
    
            #region Private methods

            /// <summary>
            /// 
            /// </summary>
            /// <param name="m"></param>
            protected override void WndProc(ref Message m)
            {
                switch (m.Msg)
                {
                    case WM_INPUT:
                    {
                            unsafe
                            {
                                uint dwSize = 0;
                                uint receivedBytes;
                                uint sizeof_RAWINPUTHEADER = (uint)sizeof(RAWINPUTHEADER);

                                // Find out the size of the buffer we have to provide
                                int res = GetRawInputData(m.LParam.ToPointer(), RID_INPUT, null, &dwSize, sizeof_RAWINPUTHEADER);
                                if (res == 0)
                                {
                                    // Allocate a buffer
                                    byte* lpb = stackalloc byte[(int)dwSize];

                                    // Get the data
                                    receivedBytes = (uint)GetRawInputData((RAWINPUTHKEYBOARD*)m.LParam.ToPointer(), RID_INPUT, lpb, &dwSize, sizeof_RAWINPUTHEADER);
                                    if (receivedBytes == dwSize)
                                    {
                                        RAWINPUTHKEYBOARD* keybData = (RAWINPUTHKEYBOARD*)lpb;

                                        // Finally, analyze the data
                                        if (keybData->header.dwType == RIM_TYPEKEYBOARD)
                                        {
                                            if ((this.m_PrevControlKey != keybData->VKey) || (this.m_PrevMessage != keybData->Message))
                                            {
                                                this.m_PrevControlKey = keybData->VKey;
                                                this.m_PrevMessage = keybData->Message;

                                                // Call the delegate in case data satisfies
                                                this.m_KeyHandler(keybData->VKey, keybData->Message);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        string errMsg = string.Format("WndProc::GetRawInputData (2) received {0} bytes while expected {1} bytes", receivedBytes, dwSize);
                                        throw new Exception(errMsg);
                                    }
                                }
                                else
                                {
                                    string errMsg = string.Format("WndProc::GetRawInputData (1) returned non zero value ({0})", res);
                                    throw new Exception(errMsg);
                                }
                            }
                    }

                    break;
                }

                base.WndProc(ref m);
            }

            #endregion
        }
    }
}
