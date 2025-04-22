using System.Runtime.InteropServices;

namespace ClickTrhouthimage;
/// <summary>
/// 
/// </summary>
public partial class FrmPrincipal : Form 
    {
        // Singleton pattern for Form2
        private static FrmPrincipal _instance;
        /// <summary>
        /// 
        /// </summary>
        public static FrmPrincipal Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FrmPrincipal();
                return _instance;
            }
        }

        private DialogResult result;
        public bool movew;

        private const short WM_CAP = 0x400;

        private const int WM_CAP_DRIVER_CONNECT = WM_CAP + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_CAP + 11;
        private const int WM_CAP_EDIT_COPY = WM_CAP + 30;

        private const int WM_CAP_SET_PREVIEW = WM_CAP + 50;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP + 52;
        private const int WM_CAP_SET_SCALE = WM_CAP + 53;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const short SWP_NOMOVE = 0x2;
        private const short SWP_NOSIZE = 1;
        private const short SWP_NOZORDER = 0x4;
        private const short HWND_BOTTOM = 1;

        private int iDevice = 0; // Current device ID
        private int hHwnd; // Handle to preview window

        [DllImport("user32", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(
            int hwnd,
            int wMsg,
            int wParam,
            [MarshalAs(UnmanagedType.AsAny)] object lParam);

        [DllImport("user32", EntryPoint = "SetWindowPos")]
        private static extern int SetWindowPos(
            int hwnd,
            int hWndInsertAfter,
            int x,
            int y,
            int cx,
            int cy,
            int wFlags);

        [DllImport("user32")]
        private static extern bool DestroyWindow(int hndw);

        [DllImport("avicap32.dll", EntryPoint = "capCreateCaptureWindowA", CharSet = CharSet.Unicode)]
        private static extern int capCreateCaptureWindowA(
            string lpszWindowName,
            int dwStyle,
            int x,
            int y,
            int nWidth,
            short nHeight,
            int hWndParent,
            int nId);

        [DllImport("avicap32.dll", EntryPoint = "capGetDriverDescriptionA", CharSet = CharSet.Unicode)]
        private static extern bool capGetDriverDescriptionA(
            short wDriver,
            string lpszName,
            int cbName,
            string lpszVer,
            int cbVer);

        /// <summary>
        /// 
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void LoadDeviceList()
        {
            var strName = new string(' ', 100);
            var strVer = new string(' ', 100);
            bool bReturn;
            int x = 0;

            // Load name of all available devices into the lstDevices
            do
            {
                // Get Driver name and version
                bReturn = capGetDriverDescriptionA((short)x, strName, 100, strVer, 100);

                // If there was a device add device name to the list
                if (bReturn)
                    lstDevices.Items.Add(strName.Trim());
                x += 1;
            } while (bReturn != false);
        }

        private void OpenPreviewWindow()
        {
           // int iHeight = ActiveForm.Height;
            //int iWidth = ActiveForm.Width;

            // Open Preview window in picturebox
            hHwnd = capCreateCaptureWindowA(iDevice.ToString(), WS_VISIBLE | WS_CHILD, 0, 0, 640,
                480, ((FrmOverlay)FrmOverlay.ActiveForm).Handle.ToInt32(), 0);

            // Connect to device
            if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) != 0)
            {
                // Set the preview scale
                _ = SendMessage(hHwnd, WM_CAP_SET_SCALE, 1, 0);

                // Set the preview rate in milliseconds
                _ = SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0);

                // Start previewing the image from the camera
               _ = SendMessage(hHwnd, WM_CAP_SET_PREVIEW, 1, 0);

                // Resize window to fit in picturebox
                _ = SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, FrmOverlay.ActiveForm.Width, FrmOverlay.ActiveForm.Height,
                        SWP_NOMOVE | SWP_NOZORDER);
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                // Error connecting to device close window
                DestroyWindow(hHwnd);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            iDevice = lstDevices.SelectedIndex;
            OpenPreviewWindow();
        }

        private void ClosePreviewWindow()
        {
            // Disconnect from device
            _ =SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0);

            // close window
            DestroyWindow(hHwnd);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ClosePreviewWindow();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            result = OpenFileDialog1.ShowDialog();
            if (result != DialogResult.OK) return;
            var img = Image.FromFile(OpenFileDialog1.FileName);
            //if (ActiveForm == null) return;
            var form =   (FrmPrincipal)Application.OpenForms[0];
            //form.PictureBox1.Image = img;
            //form.Width = img.Width;
            //form.Height = img.Height;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnStop.Enabled)
            {
                ClosePreviewWindow();
            }
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            
            Application.OpenForms[0].Opacity = TrackBar1.Value / 100.0;
            
            // if (ActiveForm == null) return;
            //
            // ((FrmPrincipal)ActiveForm).Opacity = TrackBar1.Value / 100.0;
        }

        private void FrmOverlay_Load(object sender, EventArgs e)
        {
            LoadDeviceList();
            if (lstDevices.Items.Count > 0)
            {
                btnStart.Enabled = true;
                lstDevices.SelectedIndex = 0;
                btnStart.Enabled = true;
            }
            else
            {
                lstDevices.Items.Add("No Capture Device");
                btnStart.Enabled = false;
            }

            btnStop.Enabled = false;
           // ((Form1)Form1.ActiveForm).Opacity = TrackBar1.Value / 100.0;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine(ActiveForm.Text);

            if (ActiveForm == null) return;
            Size = ActiveForm.Size;
            while (CheckBox1.Checked == true)
            {
                ActiveForm.Location = Location;
                ActiveForm.Size = Size;
                Application.DoEvents();
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ActiveForm == null) return;
            ((FrmOverlay)ActiveForm).TextBox1.Visible = CheckBox2.Checked;
            ((FrmOverlay)ActiveForm).PictureBox1.Enabled = (!CheckBox2.Checked) && btnStart.Enabled;
        }
    }
