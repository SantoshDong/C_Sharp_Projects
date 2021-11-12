using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg,*.png)|*.bmp;*.jpg;*.png";
            if (DialogResult.OK == ofile.ShowDialog())
            {
                this.picOriginal.Image = new Bitmap(ofile.FileName);

            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            ForProcessing.ConvertToGrey(copy);
            this.picModified.Image = copy;
        }

        private void btnMedian_Click(object sender, EventArgs e)
        {
            Bitmap copy = new Bitmap((Bitmap)this.picOriginal.Image);
            ForProcessing.MedianFiltering(copy);
            this.picModified.Image = copy;
        }
    }
}
