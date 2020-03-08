using System;

namespace TestColor.Model
{
    public class RGB
    {
        public event EventHandler ColorIsChanced;
        public event EventHandler ColorMustUpdate;
        public event EventHandler ShowMessage;
        public event EventHandler DisableMessage;

        private int r = 0;
        private int g = 0;
        private int b = 0;


        private bool isOut = false;

        public int R
        {
            get { return r; }
            set
            {
                r = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }
        public int G
        {
            get { return g; }
            set
            {
                g = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                b = value;
                ColorIsChanced?.Invoke(null, null);
            }
        }


        public void FromCMYK(CMYK color)
        {
            r = (int)Math.Ceiling(255 * (1 - color.C) * (1 - color.K));
            g = (int)Math.Ceiling(255 * (1 - color.M) * (1 - color.K));
            b = (int)Math.Ceiling(255 * (1 - color.Y) * (1 - color.K));

            ColorMustUpdate?.Invoke(null,null);
        }

        public void FromXYZ(XYZ color)
        {
            isOut = false;

            double rn = 3.2406 * color.X + -1.5372 * color.Y + -0.4986 * color.Z;
            double gn = -0.9689 * color.X + 1.8758 * color.Y + 0.0415 * color.Z;
            double bn = 0.0557 * color.X + -0.2040 * color.Y + 1.0570 * color.Z;

            r =(int)Math.Ceiling(F(rn) * 255);
            g = (int)Math.Ceiling(F(gn) * 255);
            b = (int)Math.Ceiling(F(bn) * 255);

            if (r < 0)
            {
                r=0;
                isOut = true;
            }

            if (g < 0)
            {
                g = 0;
                isOut = true;
            }

            if (b < 0)
            {
                b = 0;
                isOut = true;
            }


            if (r > 255)
            {
                r = 255;
                isOut = true;
            }
            if (g > 255)
            {
                g = 255;
                isOut = true;
            }
            if (b > 255)
            {
                b = 255;
                isOut = true;
            }



            if (isOut)
            {
                ShowMessage?.Invoke(null,null);
            }
            else
            {
                DisableMessage?.Invoke(null, null);
            }

            ColorMustUpdate?.Invoke(null, null);
        }

        private static double F(double x)
        {
            if(x>=0.0031308)
            {
                return 1.055 * Math.Pow(x, 1 / 2.4) - 0.055;
            }

            return 12.92 * x;
        }
    }
}
