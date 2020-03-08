using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestColor.Model;

namespace TestColor
{
   public static class ColorConverter
    {

       public static CMYK ConvertRGBToCMYK(Color color)
        {
            CMYK cmyk = new CMYK();

            cmyk.K = new double[] { 1 - color.R / 255d, 1 - color.G / 255d, 1 - color.B / 255d }.Min();
            cmyk.C = (1 - color.R / 255d - cmyk.K) / (1 - cmyk.K);
            cmyk.M = (1 - color.G / 255d - cmyk.K) / (1 - cmyk.K);
            cmyk.Y = (1 - color.B / 255d - cmyk.K) / (1 - cmyk.K);

            return cmyk;
        }
    }
}
