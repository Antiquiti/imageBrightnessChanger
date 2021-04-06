using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Drawing.Imaging;

namespace lab1Obrazki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmap;
        OpenFileDialog ofd;
        BackgroundWorker backgroundWorker = null;
        private void openImageBtn_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.ShowDialog();
            bitmap = new Bitmap(ofd.FileName);
            ImagePictureBox.Image = bitmap;
        }

        private void brightnessScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            brightnessTB.Text = brightnessScrollBar.Value.ToString();
        }

        private void brightnessTB_TextChanged(object sender, EventArgs e)
        {
            if(Int32.Parse(brightnessTB.Text) > 100)
            {
                brightnessTB.Text = "100";
            }
            brightnessScrollBar.Value = Int32.Parse(brightnessTB.Text);
        }

        private void changeBrightnessBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorker == null)
            {
                backgroundWorker = new BackgroundWorker();
                backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
                backgroundWorker.RunWorkerCompleted +=new RunWorkerCompletedEventHandler(backgroundWorker_RunWorkerCompleted);
                backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.WorkerSupportsCancellation = true;
            }
            backgroundWorker.RunWorkerAsync();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            String savePath = ofd.FileName;
            savePath = savePath.Replace(".jpeg", string.Empty);
            ImagePictureBox.Image.Save(savePath+"new.jpeg", ImageFormat.Jpeg);
        }

        private void cancelBrightnessBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            double brightness = Convert.ToDouble(brightnessTB.Text) * 2.55;
            Bitmap temp = (Bitmap)bitmap;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double cR = c.R + brightness;
                    double cG = c.G + brightness;
                    double cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    bmap.SetPixel(i, j, Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }

                if (backgroundWorker.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker.ReportProgress(0);
                    return;
                }
                int percentage = i*100/bmap.Width;
                backgroundWorker.ReportProgress(percentage);
            }
            Bitmap newBitmap = (Bitmap)bmap.Clone();
            ImagePictureBox.Image = newBitmap;
        }

        public void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        public void backgroundWorker_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
        }
    }
}
