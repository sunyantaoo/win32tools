﻿namespace Thriving.Win32Tools
{
    /// <summary>
    /// 模拟键盘输入事件类型
    /// </summary>
    public enum VirtualKeyEvent
    {
        KEYEVENTF_KEYDOWN = 0x0000,
        /// <summary>
        /// If specified, the scan code was preceded by a prefix byte that has the value 0xE0 (224).
        /// </summary>
        KEYEVENTF_EXTENDEDKEY = 0x0001,
        /// <summary>
        /// If specified, the key is being released. If not specified, the key is being pressed.
        /// </summary>
        KEYEVENTF_KEYUP = 0x0002,
        /// <summary>
        /// If specified, the system synthesizes a VK_PACKET keystroke. The wVk parameter must be zero. This flag can only be combined with the KEYEVENTF_KEYUP flag. For more information, see the Remarks section.
        /// </summary>
        KEYEVENTF_UNICODE = 0x0004,
        /// <summary>
        /// If specified, wScan identifies the key and wVk is ignored.
        /// </summary>
        KEYEVENTF_SCANCODE = 0x0008,
    }

    /// <summary>
    /// 模拟鼠标输入事件类型
    /// </summary>
    public enum VirtualMouseEvent
    {
        /// <summary>
        /// 	Movement occurred.
        /// </summary>
        MOUSEEVENTF_MOVE = 0x0001,
        /// <summary>
        /// 	The left button was pressed.
        /// </summary>
        MOUSEEVENTF_LEFTDOWN = 0x0002,
        /// <summary>
        /// 	The left button was released.
        /// </summary>
        MOUSEEVENTF_LEFTUP = 0x0004,
        /// <summary>
        ///   The right button was pressed.
        /// </summary>
        MOUSEEVENTF_RIGHTDOWN = 0x0008,
        /// <summary>
        /// The right button was released.
        /// </summary>
        MOUSEEVENTF_RIGHTUP = 0x0010,
        /// <summary>
        /// 	The middle button was pressed.
        /// </summary>
        MOUSEEVENTF_MIDDLEDOWN = 0x0020,
        /// <summary>
        /// 	The middle button was released.
        /// </summary>
        MOUSEEVENTF_MIDDLEUP = 0x0040,
        /// <summary>
        /// 	An X button was pressed.
        /// </summary>
        MOUSEEVENTF_XDOWN = 0x0080,
        /// <summary>
        /// 	An X button was released.
        /// </summary>
        MOUSEEVENTF_XUP = 0x0100,
        /// <summary>
        /// The wheel was moved, if the mouse has a wheel. The amount of movement is specified in mouseData.
        /// </summary>
        MOUSEEVENTF_WHEEL = 0x0800,
        /// <summary>
        /// 	The wheel was moved horizontally, if the mouse has a wheel. The amount of movement is specified in mouseData.
        /// 	Windows XP/2000: This value is not supported.
        /// </summary>
        MOUSEEVENTF_HWHEEL = 0x1000,
        /// <summary>
        /// The WM_MOUSEMOVE messages will not be coalesced. The default behavior is to coalesce WM_MOUSEMOVE messages.
        /// Windows XP/2000: This value is not supported.
        /// </summary>
        MOUSEEVENTF_MOVE_NOCOALESCE = 0x2000,
        /// <summary>
        /// 	Maps coordinates to the entire desktop. Must be used with MOUSEEVENTF_ABSOLUTE.
        /// </summary>
        MOUSEEVENTF_VIRTUALDESK = 0x4000,
        /// <summary>
        /// The dx and dy members contain normalized absolute coordinates. If the flag is not set, dxand dy contain relative data (the change in position since the last reported position). 
        /// This flag can be set, or not set, regardless of what kind of mouse or other pointing device, if any, is connected to the system. For further information about relative mouse motion, see the following Remarks section.
        /// </summary>
        MOUSEEVENTF_ABSOLUTE = 0x8000
    }

    /// <summary>
    /// 键盘虚拟按键编码，其中(0-9,A-Z)的值与ASCII码相同
    /// </summary>
    public enum VirtualKeyCode : short
    {
        VK_LBUTTON = 0x01,
        VK_RBUTTON = 0x02,
        VK_CANCEL = 0x03,
        VK_MBUTTON = 0x04,
        VK_XBUTTON1 = 0x05,
        VK_XBUTTON2 = 0x06,
        //-
        //=0x07,
        VK_BACK = 0x08,
        VK_TAB = 0x09,
        //-
        //=0x0A-0B,
        VK_CLEAR = 0x0C,
        VK_RETURN = 0x0D,
        //-
        //=0x0E-0F,
        VK_SHIFT = 0x10,
        VK_CONTROL = 0x11,
        VK_MENU = 0x12,
        VK_PAUSE = 0x13,
        VK_CAPITAL = 0x14,
        VK_KANA = 0x15,
        VK_HANGUEL = 0x15,
        VK_HANGUL = 0x15,
        VK_IME_ON = 0x16,
        VK_JUNJA = 0x17,
        VK_FINAL = 0x18,
        VK_HANJA = 0x19,
        VK_KANJI = 0x19,
        VK_IME_OFF = 0x1A,
        VK_ESCAPE = 0x1B,
        VK_CONVERT = 0x1C,
        VK_NONCONVERT = 0x1D,
        VK_ACCEPT = 0x1E,
        VK_MODECHANGE = 0x1F,
        VK_SPACE = 0x20,
        VK_PRIOR = 0x21,
        VK_NEXT = 0x22,
        VK_END = 0x23,
        VK_HOME = 0x24,
        VK_LEFT = 0x25,
        VK_UP = 0x26,
        VK_RIGHT = 0x27,
        VK_DOWN = 0x28,
        VK_SELECT = 0x29,
        VK_PRshort = 0x2A,
        VK_EXECUTE = 0x2B,
        VK_SNAPSHOT = 0x2C,
        VK_INSERT = 0x2D,
        VK_DELETE = 0x2E,
        VK_HELP = 0x2F,

        VK_0 = 0x30,
        VK_1 = 0x31,
        VK_2 = 0x32,
        VK_3 = 0x33,
        VK_4 = 0x34,
        VK_5 = 0x35,
        VK_6 = 0x36,
        VK_7 = 0x37,
        VK_8 = 0x38,
        VK_9 = 0x39,

        //-=0x3A-40
        VK_A = 0x41,
        VK_B = 0x42,
        VK_C = 0x43,
        VK_D = 0x44,
        VK_E = 0x45,
        VK_F = 0x46,
        VK_G = 0x47,
        VK_H = 0x48,
        VK_I = 0x49,
        VK_J = 0x4A,
        VK_K = 0x4B,
        VK_L = 0x4C,
        VK_M = 0x4D,
        VK_N = 0x4E,
        VK_O = 0x4F,
        VK_P = 0x50,
        VK_Q = 0x51,
        VK_R = 0x52,
        VK_S = 0x53,
        VK_T = 0x54,
        VK_U = 0x55,
        VK_V = 0x56,
        VK_W = 0x57,
        VK_X = 0x58,
        VK_Y = 0x59,
        VK_Z = 0x5A,

        VK_LWIN = 0x5B,
        VK_RWIN = 0x5C,
        VK_APPS = 0x5D,
        //-=0x5E
        VK_SLEEP = 0x5F,
        VK_NUMPAD0 = 0x60,
        VK_NUMPAD1 = 0x61,
        VK_NUMPAD2 = 0x62,
        VK_NUMPAD3 = 0x63,
        VK_NUMPAD4 = 0x64,
        VK_NUMPAD5 = 0x65,
        VK_NUMPAD6 = 0x66,
        VK_NUMPAD7 = 0x67,
        VK_NUMPAD8 = 0x68,
        VK_NUMPAD9 = 0x69,
        VK_MULTIPLY = 0x6A,
        VK_ADD = 0x6B,
        VK_SEPARATOR = 0x6C,
        VK_SUBTRACT = 0x6D,
        VK_DECIMAL = 0x6E,
        VK_DIVIDE = 0x6F,
        VK_F1 = 0x70,
        VK_F2 = 0x71,
        VK_F3 = 0x72,
        VK_F4 = 0x73,
        VK_F5 = 0x74,
        VK_F6 = 0x75,
        VK_F7 = 0x76,
        VK_F8 = 0x77,
        VK_F9 = 0x78,
        VK_F10 = 0x79,
        VK_F11 = 0x7A,
        VK_F12 = 0x7B,
        VK_F13 = 0x7C,
        VK_F14 = 0x7D,
        VK_F15 = 0x7E,
        VK_F16 = 0x7F,
        VK_F17 = 0x80,
        VK_F18 = 0x81,
        VK_F19 = 0x82,
        VK_F20 = 0x83,
        VK_F21 = 0x84,
        VK_F22 = 0x85,
        VK_F23 = 0x86,
        VK_F24 = 0x87,
        //-=0x88-8F
        VK_NUMLOCK = 0x90,
        VK_SCROLL = 0x91,
        //=0x92-96
        //-=0x97-9F
        VK_LSHIFT = 0xA0,
        VK_RSHIFT = 0xA1,
        VK_LCONTROL = 0xA2,
        VK_RCONTROL = 0xA3,
        VK_LMENU = 0xA4,
        VK_RMENU = 0xA5,
        VK_BROWSER_BACK = 0xA6,
        VK_BROWSER_FORWARD = 0xA7,
        VK_BROWSER_REFRESH = 0xA8,
        VK_BROWSER_STOP = 0xA9,
        VK_BROWSER_SEARCH = 0xAA,
        VK_BROWSER_FAVORITES = 0xAB,
        VK_BROWSER_HOME = 0xAC,
        VK_VOLUME_MUTE = 0xAD,
        VK_VOLUME_DOWN = 0xAE,
        VK_VOLUME_UP = 0xAF,
        VK_MEDIA_NEXT_TRACK = 0xB0,
        VK_MEDIA_PREV_TRACK = 0xB1,
        VK_MEDIA_STOP = 0xB2,
        VK_MEDIA_PLAY_PAUSE = 0xB3,
        VK_LAUNCH_MAIL = 0xB4,
        VK_LAUNCH_MEDIA_SELECT = 0xB5,
        VK_LAUNCH_APP1 = 0xB6,
        VK_LAUNCH_APP2 = 0xB7,
        //-=0xB8-B9
        VK_OEM_1 = 0xBA,
        VK_OEM_PLUS = 0xBB,
        VK_OEM_COMMA = 0xBC,
        VK_OEM_MINUS = 0xBD,
        VK_OEM_PERIOD = 0xBE,
        VK_OEM_2 = 0xBF,
        VK_OEM_3 = 0xC0,
        //-=0xC1-D7
        //-=0xD8-DA
        VK_OEM_4 = 0xDB,
        VK_OEM_5 = 0xDC,
        VK_OEM_6 = 0xDD,
        VK_OEM_7 = 0xDE,
        VK_OEM_8 = 0xDF,
        //-=0xE0=0xE1
        VK_OEM_102 = 0xE2,
        //=0xE3-E4
        VK_PROCESSKEY = 0xE5,
        //=0xE6
        VK_PACKET = 0xE7,
        //-=0xE8=0xE9-F5
        VK_ATTN = 0xF6,
        VK_CRSEL = 0xF7,
        VK_EXSEL = 0xF8,
        VK_EREOF = 0xF9,
        VK_PLAY = 0xFA,
        VK_ZOOM = 0xFB,
        VK_NONAME = 0xFC,
        VK_PA1 = 0xFD,
        VK_OEM_CLEAR = 0xFE,
    }

}
