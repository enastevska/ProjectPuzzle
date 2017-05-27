using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Form1 : Form
    {
        OpenFileDialog OpenFileDialog = null;
        Image Image;
        Image Image1;

        PictureBox PictureBoxSolvePuzzle = null;
        PictureBox PictureBoxPuzzle = null;
       

        PictureBox[] PuzzlePieces = null;
        Image[] Images = null;


        PictureBox SwapBox1 = null;
        PictureBox SwapBox2 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = true;
            btnLevel2.Enabled = true;
            btnLevel3.Enabled = true; 

            if (OpenFileDialog == null)
            {
                OpenFileDialog = new OpenFileDialog();
            }

            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image = BitmapImage(Image.FromFile(OpenFileDialog.FileName));

                if (PictureBoxSolvePuzzle == null)
                {
                    PictureBoxSolvePuzzle = new PictureBox();
                    PictureBoxSolvePuzzle.Height = gbSolvePuzzle.Height;
                    PictureBoxSolvePuzzle.Width = gbSolvePuzzle.Width;
                    gbSolvePuzzle.Controls.Add(PictureBoxSolvePuzzle);
                }

                PictureBoxSolvePuzzle.Image = Image;

                Image1 = BitmapImagePuzzle(Image.FromFile(OpenFileDialog.FileName));
                if (PictureBoxPuzzle == null)
                {
                    PictureBoxPuzzle = new PictureBox();
                    PictureBoxPuzzle.Height = gbPuzzle.Height;
                    PictureBoxPuzzle.Width = gbPuzzle.Width;
                    gbPuzzle.Controls.Add(PictureBoxPuzzle);
                }

                PictureBoxPuzzle.Image = Image1;
            }
        }

        private Bitmap BitmapImage(Image Image)
        {
            Bitmap bitmapImage = new Bitmap(gbSolvePuzzle.Width, gbSolvePuzzle.Height);
            Graphics graphics = Graphics.FromImage(bitmapImage);
            graphics.Clear(Color.White);
            graphics.DrawImage(Image, new Rectangle(0, 0, gbSolvePuzzle.Width, gbSolvePuzzle.Height));
            graphics.Flush();

            return bitmapImage;
        }

        private Bitmap BitmapImagePuzzle(Image Image)
        {
            Bitmap bitmapImage = new Bitmap(gbPuzzle.Width, gbPuzzle.Height);
            Graphics graphics = Graphics.FromImage(bitmapImage);
            graphics.Clear(Color.White);
            graphics.DrawImage(Image, new Rectangle(0, 0, gbPuzzle.Width, gbPuzzle.Height));
            graphics.Flush();

            return bitmapImage;
        }


        private void CutPicture(Image image, Image[] images, int index, int numberRows, int numberColumns, int pieceX, int pieceY)
        {
            images[index] = new Bitmap(pieceX, pieceY);
            Graphics graphics = Graphics.FromImage(images[index]);
            graphics.Clear(Color.White);
            graphics.DrawImage(image, new Rectangle(0,0,pieceX,pieceY), new Rectangle(pieceX * (index%numberColumns), pieceY * (index / numberColumns),pieceX,pieceY),GraphicsUnit.Pixel);
            graphics.Flush();
        }

        private void shuffle(ref int [] array)
        {
           Random rnd = new Random();
           int i=array.Length;
           while(i > 1)
           {
               int j = rnd.Next(i);  
               i--;
               int tmp = array[j];
               array[j] = array[i];
               array[i] = tmp;
           }
        }

        public void PuzzleClick(object sender, EventArgs e)
        {
            if (SwapBox1 == null)
            {
                SwapBox1 = (PictureBox)sender;
            }

            else if (SwapBox2 == null)
            {
                SwapBox2 = (PictureBox)sender;
                SwapImages(SwapBox1, SwapBox2);
            }
            else
            {
                SwapBox1 = SwapBox2;
                SwapBox2 = (PictureBox)sender;
                SwapImages(SwapBox1, SwapBox2);
            }
        }

        public void SwapLocations( Point p1,  Point p2)
        {
            Point temp = p1;
            p1 = p2;
            p2 = temp;
        }

        public void SwapImages(PictureBox picture1, PictureBox picture2)
        {
            SwapLocations(picture1.Location, picture2.Location);
        }
   

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnReset.Enabled = true;
            btnAddImage.Enabled = false;

            if (PictureBoxSolvePuzzle != null)
            {
                gbSolvePuzzle.Controls.Remove(PictureBoxSolvePuzzle);
                PictureBoxSolvePuzzle.Dispose();
                PictureBoxSolvePuzzle = null;
            }

            if (PictureBoxSolvePuzzle == null)
            {
                Images = new Image[4];
                PuzzlePieces = new PictureBox[4];
            } 

            int pieceX = gbSolvePuzzle.Width / 2;
            int pieceY = gbSolvePuzzle.Height / 2;
            int[] tmpArray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                tmpArray[i] = i;
                if (PuzzlePieces[i] == null)
                {
                    PuzzlePieces[i] = new PictureBox();
                    PuzzlePieces[i].Click +=new EventHandler(PuzzleClick);
                    PuzzlePieces[i].BorderStyle = BorderStyle.Fixed3D;
                }

                PuzzlePieces[i].Height = pieceY;
                PuzzlePieces[i].Width = pieceX;

                CutPicture(Image, Images, i, 2, 2, pieceX, pieceY);

                PuzzlePieces[i].Location = new Point(pieceX * (i % 2), pieceY * (i / 2));
                if (!gbSolvePuzzle.Controls.Contains(PuzzlePieces[i]))
                {
                    gbSolvePuzzle.Controls.Add(PuzzlePieces[i]);
                }
            }

            shuffle(ref tmpArray);
            for (int i = 0; i < 4; i++)
                PuzzlePieces[i].Image = Images[tmpArray[i]];
            
           
        }

        private void btnLevel2_Click(object sender, EventArgs e)
        {
            btnLevel1.Enabled = false;
            btnLevel3.Enabled = false;
            btnReset.Enabled = true;
            btnAddImage.Enabled = false;

            if (PictureBoxSolvePuzzle != null)
            {
                gbSolvePuzzle.Controls.Remove(PictureBoxSolvePuzzle);
                PictureBoxSolvePuzzle.Dispose();
                PictureBoxSolvePuzzle = null;
            }

            if (PictureBoxSolvePuzzle == null)
            {
                Images = new Image[16];
                PuzzlePieces = new PictureBox[16];
            }

            int pieceX = gbSolvePuzzle.Width / 4;
            int pieceY = gbSolvePuzzle.Height / 4;
            int[] tmpArray = new int[16];
            for (int i = 0; i < 16; i++)
            {
                tmpArray[i] = i;
                if (PuzzlePieces[i] == null)
                {
                    PuzzlePieces[i] = new PictureBox();
                    PuzzlePieces[i].Click += new EventHandler(PuzzleClick);
                    PuzzlePieces[i].BorderStyle = BorderStyle.Fixed3D;
                }

                PuzzlePieces[i].Height = pieceY;
                PuzzlePieces[i].Width = pieceX;

                CutPicture(Image, Images, i, 4, 4, pieceX, pieceY);

                PuzzlePieces[i].Location = new Point(pieceX * (i % 4), pieceY * (i / 4));
                if (!gbSolvePuzzle.Controls.Contains(PuzzlePieces[i]))
                {
                    gbSolvePuzzle.Controls.Add(PuzzlePieces[i]);
                }
            }

            shuffle(ref tmpArray);
            for (int i = 0; i < 16; i++)
                PuzzlePieces[i].Image = Images[tmpArray[i]];
           
        }

        private void btnLevel3_Click(object sender, EventArgs e)
        {
            btnLevel2.Enabled = false;
            btnLevel1.Enabled = false;
            btnReset.Enabled = true;
            btnAddImage.Enabled = false;

            if (PictureBoxSolvePuzzle != null)
            {
                gbSolvePuzzle.Controls.Remove(PictureBoxSolvePuzzle);
                PictureBoxSolvePuzzle.Dispose();
                PictureBoxSolvePuzzle = null;
            }
            
            if (PictureBoxSolvePuzzle == null)
            {
                Images = new Image[25];
                PuzzlePieces = new PictureBox[25];
            }

            int pieceX = gbSolvePuzzle.Width / 5;
            int pieceY = gbSolvePuzzle.Height / 5;
            int[] tmpArray = new int[25];
            for (int i = 0; i < 25; i++)
            {
                tmpArray[i] = i;
                if (PuzzlePieces[i] == null)
                {
                    PuzzlePieces[i] = new PictureBox();
                    PuzzlePieces[i].Click += new EventHandler(PuzzleClick);
                    PuzzlePieces[i].BorderStyle = BorderStyle.Fixed3D;
                }

                PuzzlePieces[i].Height = pieceY;
                PuzzlePieces[i].Width = pieceX;

                CutPicture(Image, Images, i, 5, 5, pieceX, pieceY);

                PuzzlePieces[i].Location = new Point(pieceX * (i % 5), pieceY * (i / 5));
                if (!gbSolvePuzzle.Controls.Contains(PuzzlePieces[i]))
                {
                    gbSolvePuzzle.Controls.Add(PuzzlePieces[i]);
                }
            }

            shuffle(ref tmpArray);
            for (int i = 0; i < 25; i++)
                PuzzlePieces[i].Image = Images[tmpArray[i]];
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnLevel2.Enabled = false;
            btnLevel3.Enabled = false;
            btnLevel1.Enabled = false;
            btnAddImage.Enabled = true;

            ResetForm rf = new ResetForm();
            if (rf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (PictureBoxPuzzle != null)
                {
                    gbPuzzle.Controls.Remove(PictureBoxPuzzle);
                    PictureBoxPuzzle.Dispose();
                    PictureBoxPuzzle = null;
                    for (int i = 0; i < PuzzlePieces.Length; i++)
                    {
                        gbSolvePuzzle.Controls.Remove(PuzzlePieces[i]);
                        PuzzlePieces[i] = null;
                    }
                }
            }
        }
    }
}
