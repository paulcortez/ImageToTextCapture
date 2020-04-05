using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ImageToTextCapture
{
    public partial class Home : Form
    {
        private Point clickPosition;
        private Point scrollPosition;
        private Size OriginalSize = new Size();
        private int cropX, cropY, cropW, cropH;
        private Pen cropPen;

        public Home()
        {
            InitializeComponent();
        }

        private string GetTextFromImage(Bitmap capturedImg)
        {
            Enabled = false;

            string text = "";

            var img = new Bitmap(capturedImg);
            var ocr = new TesseractEngine("./tessdata", "eng", EngineMode.TesseractAndCube);
            var page = ocr.Process(img);

            text = page.GetText();

            Enabled = true;

            return text;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tbImageZoom_Scroll(object sender, EventArgs e)
        {
            double scale = (double)tbImageZoom.Value / 10D;

            this.SuspendLayout();
            imgContainer.Size = new Size((int)(OriginalSize.Width * scale), (int)(OriginalSize.Height * scale));
            this.ResumeLayout();
        }

        private void imgContainer_MouseDown(object sender, MouseEventArgs e)
        {
            if (chkReadingTextOnOff.Checked)
            {
                cropX = e.X;
                cropY = e.Y;

                cropPen = new Pen(Color.Red, 1);
                cropPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            }
            else
                this.clickPosition = e.Location;
        }

        private void imgContainer_MouseMove(object sender, MouseEventArgs e)
        {
            this.SuspendLayout();

            if (e.Button == MouseButtons.Left && chkReadingTextOnOff.Checked)
            {
                imgContainer.Refresh();
                cropW = e.X - cropX;
                cropH = e.Y - cropY;

                imgContainer.CreateGraphics().DrawRectangle(cropPen, cropX, cropY, cropW, cropH);
            }
            else if (e.Button == MouseButtons.Left)
            {
                this.scrollPosition += (Size)clickPosition - (Size)e.Location;
                this.pnlImageContainer.AutoScrollPosition = scrollPosition;
            }

            this.ResumeLayout(false);
        }

        private void imgContainer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && chkReadingTextOnOff.Checked)
            {
                Rectangle rec = new Rectangle(cropX, cropY, cropW, cropH);
                Bitmap originalImage = new Bitmap(imgContainer.Image, imgContainer.Width, imgContainer.Height);
                Bitmap newImage = new Bitmap(cropW, cropH);
                Graphics g = Graphics.FromImage(newImage);

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                g.DrawImage(originalImage, 0, 0, rec, GraphicsUnit.Pixel);

                slicedImage.Image = newImage;

                txtExtractedFromImage.Text = GetTextFromImage(newImage);
            }
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            ofdBrowseFile.ShowDialog();
        }

        private void ofdBrowseFile_FileOk(object sender, CancelEventArgs e)
        {
            txtFilePath.Text = ofdBrowseFile.FileName;

            Image img = Bitmap.FromFile(txtFilePath.Text);

            imgContainer.Image = img;
            imgContainer.Size = new Size(img.Width, img.Height);
            OriginalSize = imgContainer.Size;

            tbImageZoom.Value = 10;
        }

        private void chkReadingTextOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if(chkReadingTextOnOff.Checked)
                chkReadingTextOnOff.Text = "Reading Text ON";
            else
                chkReadingTextOnOff.Text = "Reading Text OFF";
        }
    }
}
