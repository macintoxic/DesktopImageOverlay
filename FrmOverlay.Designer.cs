namespace ClickTrhouthimage;

 partial class FrmOverlay
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
            TextBox1 = new System.Windows.Forms.TextBox();
            PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).BeginInit();
            SuspendLayout();
            // 
            // TextBox1
            // 
            TextBox1.AcceptsReturn = true;
            TextBox1.AcceptsTab = true;
            TextBox1.BackColor = System.Drawing.Color.White;
            TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            TextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            TextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            TextBox1.Location = new System.Drawing.Point(0, 0);
            TextBox1.MaxLength = 65536;
            TextBox1.Multiline = true;
            TextBox1.Name = "TextBox1";
            TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            TextBox1.Size = new System.Drawing.Size(292, 266);
            TextBox1.TabIndex = 0;
            TextBox1.TabStop = false;
            TextBox1.Visible = false;
            TextBox1.WordWrap = false;
            // 
            // PictureBox1
            // 
            PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            PictureBox1.Location = new System.Drawing.Point(0, 0);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new System.Drawing.Size(292, 266);
            PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 1;
            PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(292, 266);
            Controls.Add(PictureBox1);
            Controls.Add(TextBox1);
            Cursor = System.Windows.Forms.Cursors.Default;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "FrmPrincipal";
            Text = "Form1";
            TopMost = true;
            Load += new System.EventHandler(FrmPrincipal_Load);
            GotFocus += new System.EventHandler(FrmPrincipal_GotFocus);
            ((System.ComponentModel.ISupportInitialize)(PictureBox1)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.PictureBox PictureBox1;
    }
