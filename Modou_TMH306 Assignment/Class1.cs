using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modou_TMH306_Assignment
{
    internal class Class1
    {
        public Class1()
        {

        }

        public static bool ConvertToGray(Bitmap b)
        {
            for (int i = 0; i < b.Height; i++)
                for (int j = 0; j < b.Width; j++)
                {
                    Color c1 = b.GetPixel(i, j);
                    int r1 = c1.R;
                    int g1 = c1.G;
                    int b1 = c1.B;
                    int gray = (r1 + g1 + b1) / 3;
                    r1 = gray;
                    g1 = gray;
                    b1 = gray;
                    b.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            return true;
        }
    }
}
