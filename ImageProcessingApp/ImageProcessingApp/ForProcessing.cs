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
    }
}
