using Cyotek.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestColor.Model;

namespace TestColor
{
    public partial class Form1 : Form
    {

        Color currentColor = Color.Empty;
        RGB rgb = new RGB();
        CMYK cmyk = new CMYK();
        XYZ xyz = new XYZ();
        bool rgbIsUpdate = false;
        bool cmykIsUpdate = false;
        bool xyzIsUpdate = false;

        public Form1()
        {
            InitializeComponent();
            rgb.ShowMessage+=(x, y) => label4.Visible = true;
            rgb.DisableMessage+=(x, y) => label4.Visible = false;

            RGB1.ValueChanged += (x, y) => RGBBar1.Value = (int)RGB1.Value;
            RGB2.ValueChanged += (x, y) => RGBBar2.Value = (int)RGB2.Value;
            RGB3.ValueChanged += (x, y) => RGBBar3.Value = (int)RGB3.Value;
            RGBBar1.ValueChanged += (x, y) => RGB1.Value = RGBBar1.Value;
            RGBBar2.ValueChanged += (x, y) => RGB2.Value = RGBBar2.Value;
            RGBBar3.ValueChanged += (x, y) => RGB3.Value = RGBBar3.Value;

            XYZ1.ValueChanged += (x, y) => XYZBar1.Value = (int)(XYZ1.Value*10000);
            XYZ2.ValueChanged += (x, y) => XYZBar2.Value = (int)(XYZ2.Value*10000);
            XYZ3.ValueChanged += (x, y) => XYZBar3.Value = (int)(XYZ3.Value*10000);
            XYZBar1.ValueChanged += (x, y) => XYZ1.Value = (decimal)(XYZBar1.Value/10000d);
            XYZBar2.ValueChanged += (x, y) => XYZ2.Value = (decimal)(XYZBar2.Value/10000d);
            XYZBar3.ValueChanged += (x, y) => XYZ3.Value = (decimal)(XYZBar3.Value/10000d);

            CMYK1.ValueChanged += (x, y) => CMYKBar1.Value = (int)CMYK1.Value;
            CMYK2.ValueChanged += (x, y) => CMYKBar2.Value = (int)CMYK2.Value;
            CMYK3.ValueChanged += (x, y) => CMYKBar3.Value = (int)CMYK3.Value;
            CMYK4.ValueChanged += (x, y) => CMYKBar4.Value = (int)CMYK4.Value;
            CMYKBar1.ValueChanged += (x, y) => CMYK1.Value = CMYKBar1.Value;
            CMYKBar2.ValueChanged += (x, y) => CMYK2.Value = CMYKBar2.Value;
            CMYKBar3.ValueChanged += (x, y) => CMYK3.Value = CMYKBar3.Value;
            CMYKBar4.ValueChanged += (x, y) => CMYK4.Value = CMYKBar4.Value;

            RGB1.ValueChanged += (x, y) =>
            {
  
                rgb.R = (int)RGB1.Value;
                if (!rgbIsUpdate) cmyk.FromRGB(rgb);
                if(!rgbIsUpdate) xyz.FromRGB(rgb);

            };

            RGB2.ValueChanged += (x, y) =>
            {
                rgb.G = (int)RGB2.Value;
                if (!rgbIsUpdate) cmyk.FromRGB(rgb);
                if (!rgbIsUpdate) xyz.FromRGB(rgb);
            };

            RGB3.ValueChanged += (x, y) => 
            { 
                rgb.B = (int)RGB3.Value;
                if(!rgbIsUpdate) cmyk.FromRGB(rgb);
                if (!rgbIsUpdate) xyz.FromRGB(rgb);
            };

            rgb.ColorIsChanced += (x, y) => button1.BackColor = Color.FromArgb(rgb.R, rgb.G, rgb.B);


            rgb.ColorMustUpdate += (x, y) => button1.BackColor = Color.FromArgb(rgb.R, rgb.G, rgb.B);
            rgb.ColorMustUpdate += (x, y) => 
            {
                rgbIsUpdate = true;

                RGB1.Value = rgb.R; 
                RGB2.Value = rgb.G; 
                RGB3.Value = rgb.B;

                rgbIsUpdate = false;
            };


            CMYK1.ValueChanged += (x, y) =>
            {
                cmyk.C = (double)(CMYK1.Value / 100);
                if (!cmykIsUpdate)
                {
                    rgb.FromCMYK(cmyk);
                    xyz.FromRGB(rgb);
                }
            };

            CMYK2.ValueChanged += (x, y) =>
            {
                cmyk.M = (double)(CMYK2.Value / 100);
                if (!cmykIsUpdate)
                {
                    rgb.FromCMYK(cmyk);
                    xyz.FromRGB(rgb);
                }
            };

            CMYK3.ValueChanged += (x, y) =>
            {
                cmyk.Y = (double)(CMYK3.Value / 100);
                if (!cmykIsUpdate)
                {
                    rgb.FromCMYK(cmyk);
                    xyz.FromRGB(rgb);
                }
            };
            CMYK4.ValueChanged += (x, y) =>
            {
                cmyk.K = (double)(CMYK4.Value / 100);
                if (!cmykIsUpdate)
                {
                    rgb.FromCMYK(cmyk);
                    xyz.FromRGB(rgb);
                }
            };

            cmyk.ColorMustUpdate += (x, y) => 
            {
                cmykIsUpdate = true;
                CMYK1.Value = (decimal)Math.Ceiling(cmyk.C*100);
                CMYK2.Value = (decimal)Math.Ceiling(cmyk.M*100);
                CMYK3.Value = (decimal)Math.Ceiling(cmyk.Y*100);
                CMYK4.Value = (decimal)Math.Ceiling(cmyk.K*100);
                cmykIsUpdate = false;
            };


            XYZ1.ValueChanged += (x, y) =>
            {
                xyz.X = (double)XYZ1.Value;
                if (!xyzIsUpdate)
                {
                    rgb.FromXYZ(xyz);
                    cmyk.FromRGB(rgb);
                }

            };

            XYZ2.ValueChanged += (x, y) =>
            {
                xyz.Y = (double)XYZ2.Value;
                if (!xyzIsUpdate)
                {
                    rgb.FromXYZ(xyz);
                    cmyk.FromRGB(rgb);
                }
            };

            XYZ3.ValueChanged += (x, y) =>
            {
                xyz.Z = (double)XYZ3.Value;
                if (!xyzIsUpdate)
                {
                    rgb.FromXYZ(xyz);
                    cmyk.FromRGB(rgb);
                }
            };

            xyz.ColorMustUpdate += (x, y) =>
             {
                 xyzIsUpdate = true;
                 try
                 {
                     XYZ1.Value = (decimal)xyz.X / 100;
                     XYZ2.Value = (decimal)xyz.Y / 100;
                     XYZ3.Value = (decimal)xyz.Z / 100;
                 }
                 catch
                 {

                 }
                 xyzIsUpdate = false;
             };

            colorWheel1.ColorChanged += (x, y) =>
            {
                RGB1.Value = colorWheel1.Color.R;
                RGB2.Value = colorWheel1.Color.G;
                RGB3.Value = colorWheel1.Color.B;
            };

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
