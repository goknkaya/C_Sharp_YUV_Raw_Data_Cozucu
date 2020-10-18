using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuvFileReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string filePath;
        int frameCount;
        int width;
        int height;
        int formula;
        int i;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (cmbArraySize.SelectedItem == null || txtWidth.Text == "" || txtHeight.Text == "")
            {
                MessageBox.Show("ATTENTION! Please enter to information of Reference Array, width and height.");
                txtHeight.Clear();
                txtWidth.Clear();
            }
            else
            {
                OpenFileDialog ofd = new OpenFileDialog();
                txtWidth.Text = width.ToString();
                txtHeight.Text = height.ToString();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath = ofd.FileName;

                    //If you choose the options in ComboBox, the formula will be calculated automatically with numbers on TextBoxes. Finally the function will be start.

                    if (cmbArraySize.SelectedItem.ToString() == "4:2:0 qcif")
                    {
                        formula = (width * height * 15) / 10; //for Formula of 4:2:0 format
                        readYUV(filePath, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), formula);
                    }
                    if (cmbArraySize.SelectedItem.ToString() == "4:2:0 cif")
                    {
                        formula = (width * height * 15) / 10; //for Formula of 4:2:0 format
                        readYUV(filePath, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), formula);
                    }
                    if (cmbArraySize.SelectedItem.ToString() == "4:2:2")
                    {
                        formula = width * height * 2; //for Formula of 4:2:2 format
                        readYUV(filePath, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), formula);
                    }
                    if (cmbArraySize.SelectedItem.ToString() == "4:4:4")
                    {
                        formula = width * height * 3; //for Formula of 4:4:4 format
                        readYUV(filePath, Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text), formula);
                    }
                    MessageBox.Show("SUCCESSFULLY! Pictures were readed and moved to the IMAGES folder.");
                }
                btnPlay.Enabled = true;
            }
        }

        public void readYUV(string filePath, int width, int height, int formula) //We created the function because we want to .yuv extension need to play. 
        {
            using (FileStream fileRead = new FileStream(filePath, FileMode.Open)) //for read the file.
            {
                using (BinaryReader binaryRead = new BinaryReader(fileRead))
                {
                    int fileSize = Convert.ToInt32(binaryRead.BaseStream.Length); //Length of file.
                    frameCount = fileSize / formula;

                    int count = 0;
                    byte[] bit = new byte[formula];
                    while (count < frameCount)
                    {
                        binaryRead.Read(bit, 0, formula);
                        Bitmap photo = new Bitmap(width, height);
                        int y = 0;
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < width; j++)
                            {
                                var color = Color.FromArgb(bit[y], bit[y], bit[y]); //Create the color and every color are like matrix.
                                photo.SetPixel(j, i, color);
                                y++;
                            }
                        }
                        y = 0;

                        photo.Save("IMAGES\\image_" + count + ".bmp");
                        count++;
                    }
                }
            }
        }

        //If you choose the options in ComboBox, automatically width value and height value will be on TextBoxes.

        private void cmbArraySize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbArraySize.Text == "4:2:0 qcif")
            {
                width = 176; txtWidth.Text = width.ToString();
                height = 144; txtHeight.Text = height.ToString();
            }

            if (cmbArraySize.Text == "4:2:0 cif")
            {
                width = 352; txtWidth.Text = width.ToString();
                height = 288; txtHeight.Text = height.ToString();
            }

            if (cmbArraySize.Text == "4:2:2")
            {
                width = 720; txtWidth.Text = width.ToString();
                height = 576; txtHeight.Text = height.ToString();
            }

            if (cmbArraySize.Text == "4:4:4")
            {
                width = 720; txtWidth.Text = width.ToString();
                height = 576; txtHeight.Text = height.ToString();
            }
        }

        private void timerScrool_Tick(object sender, EventArgs e)
        {
            if (i < frameCount)
            {
                pbYuv.Image = Image.FromFile(Application.StartupPath+"\\IMAGES\\image_" + i + ".bmp");
                playStickPlay(frameCount, i);
                i++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPlay.Enabled = false;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timerScrool.Start();
        }

        void playStickPlay(int frameCount, int i)
        {
            int count;
            for (count = 0; count < frameCount; count++)
            {
                //Null loop will run.
            }
            stickPlay.Maximum = count;
            stickPlay.Value = i;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pbYuv.Image = null;

            FileInfo fileInfo;
            string extension = ".bmp";

            foreach (string file in Directory.GetFiles(Application.StartupPath+ "\\IMAGES\\"))
            {
                fileInfo = new FileInfo(file);
                if (fileInfo.Extension == extension) //File extensions and our extension same?
                {
                    fileInfo.Delete();
                }
            }
            MessageBox.Show("PictureBox and IMAGES were deleted.");
        }
    }
}
