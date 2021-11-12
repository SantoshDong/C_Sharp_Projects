using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageProcessingApp
{
    internal class ForProcessing
    {
        public ForProcessing()
        {
             
        }

        public static bool ConvertToGrey(Bitmap size)
        {
            for(int i=0; i<size.Width; i++)
            {
                for(int j=0; j<size.Height; j++)
                {
                    Color color1 = size.GetPixel(i, j);
                    int red1 = color1.R;
                    int green1 = color1.G;
                    int blue1 = color1.B;
                    int grey = (byte)(.299 * red1 + .587 * green1 + .144 * blue1);
                    red1 = grey;
                    green1= grey;
                    blue1 = grey;
                    size.SetPixel(i, j, Color.FromArgb(red1,green1,blue1));
                }
            }
            return true;
        }
        public static void MedianFiltering(Bitmap bm)
        {
            List<byte> termsList = new List<byte>();

            byte[,] image = new byte[bm.Width,bm.Height];

            //Convert to Grayscale 
            for (int i = 0; i < bm.Width; i++)
            {
                for (int j = 0; j < bm.Height; j++)
                {
                    var c = bm.GetPixel(i, j);
                    byte gray = (byte)(.333 * c.R + .333 * c.G + .333 * c.B);
                    image[i, j] = gray;
                }
            }

            //applying Median Filtering 
            for (int i = 0; i <= bm.Width - 3; i++)
                for (int j = 0; j <= bm.Height - 3; j++)
                {
                    for (int x = i; x <= i + 2; x++)
                        for (int y = j; y <= j + 2; y++)
                        {
                            termsList.Add(image[x, y]);
                        }
                    byte[] terms = termsList.ToArray();
                    termsList.Clear();
                    Array.Sort<byte>(terms);
                    Array.Reverse(terms);
                    byte color = terms[4];
                    bm.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
                }
        }
    }
}
