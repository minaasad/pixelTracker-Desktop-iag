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

        private void NewImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Browse for image file
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                // Allowed formats
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
            // Show picture in frame
            displayPicture();
            // Show some details
            displayRawFormat();

            // display size in pixels
            int Height = workingBitmap.Size.Height;
            int Width = workingBitmap.Size.Width;

            // display other basics
            lblHeightInPixels.Text = "H: " + Height;
            lblWidthInPixels.Text = "W: " + Width;
            lblPixelsAvailable.Text = Height * Width + " pixels/colors available";

            // set appropriate ranges for X and Y pixel selection coordinates
            numericUpDownXLimit.Maximum = Width;
            numericUpDownXStart.Maximum = Width - 1;
            numericUpDownYStart.Maximum = Height - 1;
            numericUpDownYLimit.Maximum = Height;
        }

        private void displayPixelGroups()
        {
            // Show progress to user. This also will prevent the program from going idle
            toolStripProgressBar1.Visible = true;

            // Calculate progress due/done
            int nPixelsEval = ((int)numericUpDownXLimit.Value - (int)numericUpDownXStart.Value)
                                   *
                              ((int)numericUpDownYLimit.Value - (int)numericUpDownYStart.Value);
           
            // Set maximum steps/counter possible based on pixels available
            toolStripProgressBar1.Maximum = nPixelsEval;
            progressBar1.Maximum = nPixelsEval;

            // Evaluate each pixel
            for (int x = (int)numericUpDownXStart.Value; x < numericUpDownXLimit.Value; x++)
            {
                for (int y = (int)numericUpDownYStart.Value; y < numericUpDownYLimit.Value; y++)
                {
                    // Step forward in progress bar(s)
                    toolStripProgressBar1.Increment(1);
                    progressBar1.Increment(1);

                    // Get bitmap pixel
                    Color pixelColor = workingBitmap.GetPixel(x, y);

                    // Create new ListViewItem object
                    // This will be added later to ListView object
                    // Subitems are not recorded so X and Y are concatenated in the name
                    // This will allow to extract the XYCoords later for quick index lookup
                    ListViewItem myListViewItem = new ListViewItem(x + ":" + y + ":" + pixelColor.Name);
                    myListViewItem.BackColor = pixelColor;
                    myListViewItem.SubItems.Add(x + ':' + y.ToString());

                    // Add pixel color to ListView object
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
            // Show the target image frame
            pictureBoxTarget.Image = target;
            
            // Display how many pixels were added
            toolStripStatusLabel1.Text = "Added " + nPixelsEval + " pixels.";

            // Hide progress bar when complete
            if (toolStripProgressBar1.Value == toolStripProgressBar1.Maximum)
            {
                toolStripProgressBar1.Visible = false;
                progressBar1.Value = 0;
            }

        }

        private void displayRawFormat()
        {
            // This will show the image format
            lblRawFormat.Text = getReadableRawFormat(workingBitmap.RawFormat);
        }

        // A method to help identify the image format type
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

        // Display picture in groupbox frame
        private void displayPicture()
        {
            pictureBox1.Image = workingBitmap ;
        }

        // Delegate to Evaluate button.
        // Start off by resetting values.
        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 0;
            progressBar1.Value = 0;

            toolStripStatusLabel1.Text = "";
            displayPixelGroups();
        }

        // Delegate to the 'OnItemSelectionChange' of the ListView object
        private void listColors_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Since the XYCoords can be extracted, extract them via String.Split and delimiter :
            // Then search for that specific pixel in the image and show its' properties
            if (listColors.SelectedItems.Count > 0)
            {
                string[] xy = listColors.SelectedItems[0].Text.Split(':');
                Color pixelColor = workingBitmap.GetPixel(int.Parse(xy[0]), int.Parse(xy[1]));
                lblR.Text = "A " + pixelColor.A.ToString();
                lblR.Text = "R " + pixelColor.R.ToString();
                lblG.Text = "G " + pixelColor.G.ToString();
                lblB.Text = "B " + pixelColor.B.ToString();
                lblSaturation.Text = "S " + pixelColor.GetSaturation();
                lblBrightness.Text = "B " + pixelColor.GetBrightness();
                lblHue.Text = "H " + pixelColor.GetHue();
                lblHashcode.Text = "Hashcode: " + pixelColor.GetHashCode();
                lblName.Text = "Name: " + pixelColor.Name;
            }
        }

        // Delegate to clear button
        // Reset values
        private void btnClear_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Pixel list cleared.";
            listColors.Clear();
        }

        // Close/Exit menu button
        // Exit application with no errors
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
