using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelTrack_Desktop
{
    public partial class Form1 : Form
    {
        private Bitmap workingBitmap { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void nEWIMAGEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    toolStripStatusLabel1.Text = "Image " + dlg.FileName + " loaded.";
                    workingBitmap = new Bitmap(dlg.FileName);
                    displayAll();
                }
            }
        }

        private void displayAll()
        {
            displayPicture();
            displayRawFormat();

            //display size in pixels
            int Height = workingBitmap.Size.Height;
            int Width = workingBitmap.Size.Width;

            lblHeightInPixels.Text = "H: " + Height;
            lblWidthInPixels.Text = "W: " + Width;
            lblPixelsAvailable.Text = Height * Width + " pixels/colors available";

            numericUpDownXLimit.Maximum = Width;
            numericUpDownXStart.Maximum = Width - 1;
            numericUpDownYStart.Maximum = Height - 1;
            numericUpDownYLimit.Maximum = Height;
        }

        private void displayPixelGroups()
        {
            toolStripProgressBar1.Visible = true;

            int nPixelsEval = ((int)numericUpDownXLimit.Value - (int)numericUpDownXStart.Value)
                                   *
                              ((int)numericUpDownYLimit.Value - (int)numericUpDownYStart.Value);
           
            toolStripProgressBar1.Maximum = nPixelsEval;
            progressBar1.Maximum = nPixelsEval;

            for (int x = (int)numericUpDownXStart.Value; x < numericUpDownXLimit.Value; x++)
            {
                for (int y = (int)numericUpDownYStart.Value; y < numericUpDownYLimit.Value; y++)
                {
                    toolStripProgressBar1.Increment(1);
                    progressBar1.Increment(1);

                    Color pixelColor = workingBitmap.GetPixel(x, y);

                    ListViewItem myListViewItem = new ListViewItem(x + ":" + y + ":" + pixelColor.Name);
                    myListViewItem.BackColor = pixelColor;
                    myListViewItem.SubItems.Add(x + ':' + y.ToString());

                    listColors.Items.Add(myListViewItem);
                }
            }


            //Draw on original image
            //Pen pen = new Pen(Color.Red);
            //////Graphics g = pictureBox1.CreateGraphics();
            //Graphics g6 = Graphics.FromImage(workingBitmap);
            //g6.DrawRectangle(pen, 
            //                (int)numericUpDownXStart.Value, (int)numericUpDownYStart.Value,
            //                (int)numericUpDownXLimit.Value - (int)numericUpDownXStart.Value,
            //                (int)numericUpDownYLimit.Value - (int)numericUpDownYStart.Value);
            
            //Crop target to "target groupbox"
            Rectangle cropRect = new Rectangle((int)numericUpDownXStart.Value, 
                                               (int)numericUpDownYStart.Value,
                                               (int)numericUpDownXLimit.Value - (int)numericUpDownXStart.Value,
                                               (int)numericUpDownYLimit.Value - (int)numericUpDownYStart.Value
                                               );
            
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using(Graphics g = Graphics.FromImage(target))
            {
               g.DrawImage(workingBitmap, new Rectangle(0, 0, target.Width, target.Height), 
                                cropRect,                        
                                GraphicsUnit.Pixel);
            }
            pictureBoxTarget.Image = target;
            

            toolStripStatusLabel1.Text = "Added " + nPixelsEval + " pixels.";

            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Visible = false;
                progressBar1.Value = 0;
            }

        }

        private void displayRawFormat()
        {
            lblRawFormat.Text = getReadableRawFormat(workingBitmap.RawFormat);
        }

        private string getReadableRawFormat(ImageFormat myFormat)
        {
            if (myFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg))
                return "Jpeg";
            if (myFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp))
                return "Bmp";
            if (myFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                return "Png";
            if (myFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif))
                return "Gif";
            else
                return "Unrecognised";
        }

        private void displayPicture()
        {
            pictureBox1.Image = workingBitmap ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            progressBar1.Value = 0;

            toolStripStatusLabel1.Text = "";
            displayPixelGroups();
        }

        private void listColors_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listColors.SelectedItems.Count > 0)
            {
                string[] xy = listColors.SelectedItems[0].Text.Split(':');
                Color pixelColor = workingBitmap.GetPixel(int.Parse(xy[0]), int.Parse(xy[1]));
                lblR.Text = "A " + pixelColor.A.ToString();
                lblR.Text = "R " + pixelColor.R.ToString();
                lblG.Text = "G " + pixelColor.G.ToString();
                lblB.Text = "B " + pixelColor.B.ToString();
                lblSaturation.Text = "Saturation " + pixelColor.GetSaturation();
                lblBrightness.Text = "Brightness " + pixelColor.GetBrightness();
                lblHue.Text = "Hue " + pixelColor.GetHue();
                lblHashcode.Text = "Hashcode " + pixelColor.GetHashCode();
                lblName.Text = "Name " + pixelColor.Name;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pixel list cleared.";
            listColors.Clear();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblReducePercentage.Text = trackBar1.Value + "%";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
