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
                    workingBitmap = new Bitmap(dlg.FileName);
                    displayAll();
                }
            }
        }

        private void displayAll()
        {
            
            displayPicture();
            displayPhysicalDimensions();
            displayPixelGroups();
        }

        private void displayPhysicalDimensions()
        {
            float Height = workingBitmap.PhysicalDimension.Height;
            float Width = workingBitmap.PhysicalDimension.Width;

            lblHeightPhysicalDimension.Text = "H: " + Height;
            lblWidthPhysicalDimension.Text = "W: " + Width;
        }

        private void displayPixelGroups()
        {
            //display size in pixels
            int Height = workingBitmap.Size.Height;
            int Width = workingBitmap.Size.Width;

            lblHeightInPixels.Text = "H: " + Height;
            lblWidthInPixels.Text = "W: " + Width;

            toolStripProgressBar1.Maximum = Width * Height;

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    toolStripProgressBar1.Increment(1);

                    Color pixelColor = workingBitmap.GetPixel(x, y);

                    ListViewItem myListViewItem = new ListViewItem(pixelColor.Name);
                    myListViewItem.BackColor = pixelColor;
                    myListViewItem.SubItems.Add(x.ToString());
                    myListViewItem.SubItems.Add(y.ToString());
                    myListViewItem.SubItems.Add(pixelColor.GetHashCode().ToString());

                    listColors.Items.Add(myListViewItem);
                }
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

        private Hashtable d()
        {
            int x = 3, y = 5;
            Hashtable colorDetails = new Hashtable();
            Color pixelColor = workingBitmap.GetPixel(x, y);

            colorDetails.Add("Name", pixelColor.Name);
            colorDetails.Add("X", x);
            colorDetails.Add("Y", y);
            colorDetails.Add("AlphaComponentValue", pixelColor.A);
            colorDetails.Add("BlueComponentValue", pixelColor.B);
            colorDetails.Add("GreenComponentValue", pixelColor.G);
            colorDetails.Add("RedComponentValue", pixelColor.R);
            colorDetails.Add("IsKnownColor", pixelColor.IsKnownColor);
            colorDetails.Add("IsNamedColor", pixelColor.IsNamedColor);
            colorDetails.Add("IsSystemColor", pixelColor.IsSystemColor);
            colorDetails.Add("32bitArgbValue", pixelColor.ToArgb().ToString());
            colorDetails.Add("KnownColorValue", pixelColor.ToKnownColor().ToString());
            colorDetails.Add("IsEmpty", pixelColor.IsEmpty);
            colorDetails.Add("HueSaturationBrightness_SaturationValue", pixelColor.GetSaturation().ToString());
            colorDetails.Add("HueSaturationBrightness_HueValue", pixelColor.GetHue().ToString());
            colorDetails.Add("HueSaturationBrightness_BrightnessValue", pixelColor.GetBrightness().ToString());
            colorDetails.Add("HashCode", pixelColor.GetHashCode().ToString());

            return colorDetails;
        }

        private void displayPicture()
        {
            pictureBox1.Image = workingBitmap ;
        }
    }
}
