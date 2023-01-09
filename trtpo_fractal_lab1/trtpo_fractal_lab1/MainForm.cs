using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace trtpo_fractal_lab1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        int getMandelbrod(int x, int y)
        {
            Complex z = new Complex(0, 0);
            Complex c = new Complex(x * 4.0 / FractalPictureBox.Width - 2.0, y * 4.0 / FractalPictureBox.Height - 2.0);
            int i = 0;
            while (i < 255 && z.getAbs() < 4.0)
            {
                z = z * z + c;
                ++i;
            }
            return i;
        }

        void GenerateFractal()
        {
            Bitmap btmImage = new Bitmap(FractalPictureBox.Width, FractalPictureBox.Height);
            FractalPictureBox.BackgroundImage = btmImage;
            for (int y = 0; y < FractalPictureBox.Height; ++y)
                for (int x = 0; x < FractalPictureBox.Width; ++x)
                {

                    int i = getMandelbrod(x, y);

                    btmImage.SetPixel(x, y, Color.FromArgb(i * 2 % 256,
                       i % 256, i * 10 % 256));
                }
            FractalPictureBox.Refresh();
        }
        private void GenerateFractalButton_Click(object sender, EventArgs e) => GenerateFractal();
    }
}