using System;
using System.Linq;

namespace TestColor.Model
{
    public class CMYK
    {
        public event EventHandler ColorIsChanced;
        public event EventHandler ColorMustUpdate;

        private double c = 0;
        private double m = 0;
        private double y = 0;
        private double k = 0;

        public double C
        {
            get { return c; }
            set
            {
                c = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }
        public double M
        {
            get { return m; }
            set
            {
                m = value;
               ColorIsChanced?.Invoke(null, null);
            }
        }
        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }
        public double K
        {
            get { return k; }
            set
            {
                k = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }


        public void FromRGB(RGB color)
        {
            if (color.R == 0 && color.G == 0 && color.B == 0) return;

            k = new double[] { 1 - color.R / 255d, 1 - color.G / 255d, 1 - color.B / 255d }.Min();
            c = (1 - color.R / 255d - K) / (1 - K);
            m = (1 - color.G / 255d - K) / (1 - K);
            y = (1 - color.B / 255d - K) / (1 - K);

            ColorMustUpdate?.Invoke(null, null);

        }
    }
}
