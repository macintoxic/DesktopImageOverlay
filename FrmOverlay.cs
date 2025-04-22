using System;
using System.Windows.Forms;

namespace ClickTrhouthimage;

/// <summary>
/// 
/// </summary>
public partial class FrmOverlay : Form
    {
        private int _initialStyle;

        /// <summary>
        /// 
        /// </summary>
        public FrmOverlay()
        {
            InitializeComponent();
        }

        private void SetFormToTransparent()
        {
            // This creates a new Extended Style
            // for our window, which takes effect
            // immediately upon being set, that
            // combines the initial style of our window
            // (saved in Form.Load) and adds the ability
            // to be Transparent to the mouse.
            // Both Layered and Transparent must be
            // turned on for this to work AND have
            // the window render properly!
            Win32Api.SetWindowLong(Handle, Win32Api.GWL.ExStyle,
                (Win32Api.WS_EX)(_initialStyle | (int)Win32Api.WS_EX.Layered | (int)Win32Api.WS_EX.Transparent));

            // Don't forget to set the Alpha
            // for the window or else you won't be able
            // to see the window! Possible values
            // are 0 (visibly transparent)
            // to 255 (visibly opaque). I'll set
            // it to 70% visible here for show.
            // The second parameter is 0, because
            // we're not using a ColorKey!
            Win32Api.SetLayeredWindowAttributes(Handle, 0,
                255, Win32Api.LWA.Alpha);
        }

        private void SetFormToOpaque()
        {
            // Turn off the Transparent Extended Style.
            Win32Api.SetWindowLong(Handle, Win32Api.GWL.ExStyle,
                (Win32Api.WS_EX)(_initialStyle | (int)Win32Api.WS_EX.Layered));

            // Set the Alpha back to 100% opaque.
            Win32Api.SetLayeredWindowAttributes(Handle,
                0, 255, Win32Api.LWA.Alpha);
        }

        private void FrmPrincipal_GotFocus(object sender, EventArgs e)
        {
            TextBox1.Visible = FrmPrincipal.Instance.CheckBox2.Checked;
            if (FrmPrincipal.Instance.CheckBox2.Checked != true) return;
            TextBox1.BringToFront();
            TextBox1.Focus();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            FrmPrincipal.Instance.Show();
            // Grab the Extended Style information
            // for this window and store it.
            _initialStyle = Win32Api.GetWindowLong(Handle, Win32Api.GWL.ExStyle);

            // Set this window to Transparent
            // (to the mouse that is!)
            SetFormToTransparent();

            // Just for giggles, set this window
            // to stay on top of all others so we
            // can see what's happening.
            TopMost = true;
        }
    }
