using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Ducking_Wookie
{
    public partial class Form1 : Form
    {
        Detect detector = new Detect();

        public Form1()
        {
            Image<Bgr, byte> img = new Image<Bgr, byte>("C:\\B3IT\\KimJong.jpg");
            Image<Gray, byte> img2 = detector.detectSkinBlobs(img);

            PictureBox pb = new PictureBox();
            pb.Image = img2.ToBitmap();
            pb.Height = img.Height;
            pb.Width = img.Width;
            pb.Show();

            InitializeComponent();
        }
    }
}
