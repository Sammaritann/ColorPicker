using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestColor.Model
{
    public class XYZ
    {
        public event EventHandler ColorIsChanced;
        public event EventHandler ColorMustUpdate;

        private double x;
        private double y;
        private double z;
        public double X
        {
            get { return x; }
            set {  x = value; ColorIsChanced?.Invoke(null, null); }
        }
        public double Y
        {
            get { return y; }
            set {  y = value; ColorIsChanced?.Invoke(null, null); }
        }
        public double Z
        {
            get { return z; }
            set {  z = value; ColorIsChanced?.Invoke(null, null); }
        }


        public void FromRGB(RGB color)
        {
            double rn = F(color.R / 255d) * 100;
            double gn = F(color.G / 255d) * 100;
            double bn = F(color.B / 255d) * 100;

            x = 0.412453 * rn + 0.357580 * gn + 0.180423 * bn;
            y = 0.212671 * rn + 0.715160 * gn + 0.072169 * bn;
            z = 0.019334 * rn + 0.119193 * gn + 0.950227 * bn;

            ColorMustUpdate?.Invoke(null, null);
        }


        private static double F(double x)
        {
            if(x>=0.04045)
            {
                return Math.Pow(((x+0.055)/1.055),2.4);
            }

            return x / 12.92;

        }
    }
}
