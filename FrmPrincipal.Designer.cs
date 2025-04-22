namespace ClickTrhouthimage;
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TrackBar1 = new TrackBar();
            btnOpen = new Button();
            OpenFileDialog1 = new OpenFileDialog();
            CheckBox1 = new CheckBox();
            CheckBox2 = new CheckBox();
            sfdImage = new SaveFileDialog();
            Panel1 = new Panel();
            GroupBox1 = new GroupBox();
            lstDevices = new ListBox();
            lblDevice = new Label();
            Panel2 = new Panel();
            btnStop = new Button();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)TrackBar1).BeginInit();
            Panel1.SuspendLayout();
            GroupBox1.SuspendLayout();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TrackBar1
            // 
            TrackBar1.Dock = DockStyle.Bottom;
            TrackBar1.Location = new Point(0, 479);
            TrackBar1.Margin = new Padding(5, 6, 5, 6);
            TrackBar1.Maximum = 90;
            TrackBar1.Minimum = 25;
            TrackBar1.Name = "TrackBar1";
            TrackBar1.Size = new Size(485, 69);
            TrackBar1.TabIndex = 0;
            TrackBar1.Value = 50;
            TrackBar1.ValueChanged += TrackBar1_ValueChanged;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(0, 6);
            btnOpen.Margin = new Padding(5, 6, 5, 6);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(125, 44);
            btnOpen.TabIndex = 1;
            btnOpen.Text = "open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += Button1_Click;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // CheckBox1
            // 
            CheckBox1.AutoSize = true;
            CheckBox1.Location = new Point(138, 13);
            CheckBox1.Margin = new Padding(5, 6, 5, 6);
            CheckBox1.Name = "CheckBox1";
            CheckBox1.Size = new Size(213, 29);
            CheckBox1.TabIndex = 2;
            CheckBox1.Text = "lock to move or resize";
            CheckBox1.UseVisualStyleBackColor = true;
            CheckBox1.CheckedChanged += CheckBox1_CheckedChanged;
            // 
            // CheckBox2
            // 
            CheckBox2.AutoSize = true;
            CheckBox2.Location = new Point(138, 58);
            CheckBox2.Margin = new Padding(5, 6, 5, 6);
            CheckBox2.Name = "CheckBox2";
            CheckBox2.Size = new Size(102, 29);
            CheckBox2.TabIndex = 3;
            CheckBox2.Text = "text box";
            CheckBox2.UseVisualStyleBackColor = true;
            CheckBox2.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // sfdImage
            // 
            sfdImage.FileName = "Webcam1";
            sfdImage.Filter = "Bitmap|*.bmp";
            // 
            // Panel1
            // 
            Panel1.Controls.Add(btnOpen);
            Panel1.Controls.Add(CheckBox2);
            Panel1.Controls.Add(CheckBox1);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Margin = new Padding(5, 6, 5, 6);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(485, 94);
            Panel1.TabIndex = 4;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(lstDevices);
            GroupBox1.Controls.Add(lblDevice);
            GroupBox1.Controls.Add(Panel2);
            GroupBox1.Dock = DockStyle.Fill;
            GroupBox1.Location = new Point(0, 94);
            GroupBox1.Margin = new Padding(5, 6, 5, 6);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Padding = new Padding(5, 6, 5, 6);
            GroupBox1.Size = new Size(485, 385);
            GroupBox1.TabIndex = 5;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "webcam stream";
            // 
            // lstDevices
            // 
            lstDevices.Dock = DockStyle.Fill;
            lstDevices.Location = new Point(5, 61);
            lstDevices.Margin = new Padding(5, 6, 5, 6);
            lstDevices.Name = "lstDevices";
            lstDevices.Size = new Size(475, 245);
            lstDevices.TabIndex = 4;
            // 
            // lblDevice
            // 
            lblDevice.Dock = DockStyle.Top;
            lblDevice.Location = new Point(5, 30);
            lblDevice.Margin = new Padding(5, 0, 5, 0);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(475, 31);
            lblDevice.TabIndex = 3;
            lblDevice.Text = "Available Devices";
            lblDevice.TextAlign = ContentAlignment.TopCenter;
            // 
            // Panel2
            // 
            Panel2.Controls.Add(btnStop);
            Panel2.Controls.Add(btnStart);
            Panel2.Dock = DockStyle.Bottom;
            Panel2.Location = new Point(5, 306);
            Panel2.Margin = new Padding(5, 6, 5, 6);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(475, 73);
            Panel2.TabIndex = 0;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(202, 6);
            btnStop.Margin = new Padding(5, 6, 5, 6);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(187, 62);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop Preview";
            btnStop.Click += btnStop_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(5, 6);
            btnStart.Margin = new Padding(5, 6, 5, 6);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(187, 62);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start Preview";
            btnStart.Click += btnStart_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 548);
            Controls.Add(GroupBox1);
            Controls.Add(Panel1);
            Controls.Add(TrackBar1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FrmPrincipal";
            Text = "Form2";
            TopMost = true;
            FormClosing += Form2_FormClosing;
            Load += FrmOverlay_Load;
            ((System.ComponentModel.ISupportInitialize)TrackBar1).EndInit();
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            GroupBox1.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TrackBar TrackBar1;
        internal System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.OpenFileDialog OpenFileDialog1;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.CheckBox CheckBox2;
        internal System.Windows.Forms.SaveFileDialog sfdImage;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListBox lstDevices;
        internal System.Windows.Forms.Label lblDevice;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnStart;
    }
