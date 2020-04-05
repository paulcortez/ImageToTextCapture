namespace ImageToTextCapture
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlImageContainer = new System.Windows.Forms.Panel();
            this.imgContainer = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbImageZoom = new System.Windows.Forms.TrackBar();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.ofdBrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.chkReadingTextOnOff = new System.Windows.Forms.CheckBox();
            this.slicedImage = new System.Windows.Forms.PictureBox();
            this.txtExtractedFromImage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlImageContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slicedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtExtractedFromImage);
            this.panel1.Controls.Add(this.slicedImage);
            this.panel1.Controls.Add(this.chkReadingTextOnOff);
            this.panel1.Controls.Add(this.btnBrowseFile);
            this.panel1.Controls.Add(this.txtFilePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(708, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 729);
            this.panel1.TabIndex = 0;
            // 
            // pnlImageContainer
            // 
            this.pnlImageContainer.AutoScroll = true;
            this.pnlImageContainer.BackColor = System.Drawing.Color.Black;
            this.pnlImageContainer.Controls.Add(this.imgContainer);
            this.pnlImageContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlImageContainer.Name = "pnlImageContainer";
            this.pnlImageContainer.Size = new System.Drawing.Size(708, 684);
            this.pnlImageContainer.TabIndex = 1;
            // 
            // imgContainer
            // 
            this.imgContainer.Location = new System.Drawing.Point(0, 0);
            this.imgContainer.Name = "imgContainer";
            this.imgContainer.Size = new System.Drawing.Size(100, 50);
            this.imgContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgContainer.TabIndex = 0;
            this.imgContainer.TabStop = false;
            this.imgContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgContainer_MouseDown);
            this.imgContainer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgContainer_MouseMove);
            this.imgContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgContainer_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbImageZoom);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 684);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 45);
            this.panel2.TabIndex = 2;
            // 
            // tbImageZoom
            // 
            this.tbImageZoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbImageZoom.Location = new System.Drawing.Point(0, 0);
            this.tbImageZoom.Maximum = 20;
            this.tbImageZoom.Name = "tbImageZoom";
            this.tbImageZoom.Size = new System.Drawing.Size(708, 45);
            this.tbImageZoom.TabIndex = 4;
            this.tbImageZoom.Value = 10;
            this.tbImageZoom.Scroll += new System.EventHandler(this.tbImageZoom_Scroll);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(6, 14);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(201, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(213, 12);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // ofdBrowseFile
            // 
            this.ofdBrowseFile.FileName = "openFileDialog1";
            this.ofdBrowseFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdBrowseFile_FileOk);
            // 
            // chkReadingTextOnOff
            // 
            this.chkReadingTextOnOff.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkReadingTextOnOff.Location = new System.Drawing.Point(6, 40);
            this.chkReadingTextOnOff.Name = "chkReadingTextOnOff";
            this.chkReadingTextOnOff.Size = new System.Drawing.Size(105, 24);
            this.chkReadingTextOnOff.TabIndex = 2;
            this.chkReadingTextOnOff.Text = "Reading Text OFF";
            this.chkReadingTextOnOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkReadingTextOnOff.UseVisualStyleBackColor = true;
            this.chkReadingTextOnOff.CheckedChanged += new System.EventHandler(this.chkReadingTextOnOff_CheckedChanged);
            // 
            // slicedImage
            // 
            this.slicedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slicedImage.Location = new System.Drawing.Point(6, 70);
            this.slicedImage.Name = "slicedImage";
            this.slicedImage.Size = new System.Drawing.Size(282, 282);
            this.slicedImage.TabIndex = 3;
            this.slicedImage.TabStop = false;
            // 
            // txtExtractedFromImage
            // 
            this.txtExtractedFromImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtExtractedFromImage.Location = new System.Drawing.Point(6, 358);
            this.txtExtractedFromImage.Multiline = true;
            this.txtExtractedFromImage.Name = "txtExtractedFromImage";
            this.txtExtractedFromImage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExtractedFromImage.Size = new System.Drawing.Size(282, 326);
            this.txtExtractedFromImage.TabIndex = 4;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlImageContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Welcome to Image To Text Capture";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlImageContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbImageZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slicedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlImageContainer;
        private System.Windows.Forms.PictureBox imgContainer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar tbImageZoom;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.OpenFileDialog ofdBrowseFile;
        private System.Windows.Forms.CheckBox chkReadingTextOnOff;
        private System.Windows.Forms.PictureBox slicedImage;
        private System.Windows.Forms.TextBox txtExtractedFromImage;
    }
}

