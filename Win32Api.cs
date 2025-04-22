using System.Runtime.InteropServices;

namespace ClickTrhouthimage;

    public abstract class Win32Api
    {
        public enum GWL
        {
            ExStyle = -20
        }

        public enum WS_EX
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum LWA
        {
            ColorKey = 0x1,
            Alpha = 0x2
        }

        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        public static extern int GetWindowLong(
            IntPtr hWnd,
            GWL nIndex
        );

        [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
        public static extern int SetWindowLong(
            IntPtr hWnd,
            GWL nIndex,
            WS_EX dwNewLong
        );

        [DllImport("user32.dll", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(
            IntPtr hWnd,
            int crKey,
            byte alpha,
            LWA dwFlags
        );
    }
