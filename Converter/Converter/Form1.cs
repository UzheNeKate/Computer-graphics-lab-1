using System;
using System.Drawing;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public static bool NotifyChanges = true;
        public static (double x, double y, double z) White = (95.047, 100.0, 108.883);


        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, System.EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            BackColor = colorDialog.Color;

            NotifyChanges = false;

            var newCmyk = RGB_TO_CMYK(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            var newXyz = RGB_TO_LAB(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);
            var newHsl = RGB_TO_HSV(colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B);

            SetCMYK(newCmyk);
            SetLAB(newXyz);
            SetHSV(newHsl);
            
            NotifyChanges = true;
        }

        private void SetCMYK((double c, double m, double y, double k) color)
        {
            var (c, m, y, k) = color;
            if (c < 0 || c > (double)C_Input.Maximum 
            || m < 0 || m > (double)M_Input.Maximum
            || y < 0 || y > (double)Y_Input.Maximum
            || k < 0 || k > (double)K_Input.Maximum)
            {
                MessageBox.Show("This color cannot be shown in CMYK");
            }

            C_Input.Value = Math.Max(0, Math.Min(C_Input.Maximum, (decimal) c)); 
            M_Input.Value = Math.Max(0, Math.Min(M_Input.Maximum, (decimal) m)); 
            Y_Input.Value = Math.Max(0, Math.Min(Y_Input.Maximum, (decimal) y)); 
            K_Input.Value = Math.Max(0, Math.Min(K_Input.Maximum, (decimal) k));
        }

        private void SetLAB((double l, double a, double b) color)
        {
            var (l, a, b) = color;
            if (l < 0 || l > (double)L_Input.Maximum
                            || a < (double)A_Input.Minimum || a > (double)A_Input.Maximum
                            || b < (double)B_Input.Minimum || b > (double)B_Input.Maximum)
            {
                MessageBox.Show("This color cannot be shown in LAB");
            }

            L_Input.Value = (int)Math.Max((double)L_Input.Minimum, Math.Min((double)L_Input.Maximum, l));
            A_Input.Value = (int)Math.Max((double)A_Input.Minimum, Math.Min((double)A_Input.Maximum, a));
            B_Input.Value = (int)Math.Max((double)B_Input.Minimum, Math.Min((double)B_Input.Maximum, b));
        }

        private void SetHSV((double h, double s, double v) color)
        {
            var (h, s, v) = color;
            if (h < 0 || h > (double)H_Input.Maximum
                            || s < 0 || s > (double)S_Input.Maximum
                            || v < 0 || v > (double)V_Input.Maximum)
            {
                MessageBox.Show("This color cannot be shown in HSV");
            }

            H_Input.Value = Math.Max(0, Math.Min((int)H_Input.Maximum, (int)h));
            S_Input.Value = Math.Max(0, Math.Min((int)S_Input.Maximum, (int)(s)));
            V_Input.Value = Math.Max(0, Math.Min((int)V_Input.Maximum, (int)(v)));
        }

        private void CMYK_ValueChanged(object sender, EventArgs e)
        {
            if (!NotifyChanges) 
                return;

            NotifyChanges = false;

            var (r, g, b) = CMYK_TO_RGB(
                (double)C_Input.Value / 100.0,
                (double)M_Input.Value / 100.0,
                (double)Y_Input.Value / 100.0,
                (double)K_Input.Value / 100.0);

            try
            {
                BackColor = Color.FromArgb((int)r, (int)g, (int)b);
            }
            catch (Exception)
            {
                MessageBox.Show("This color cannot be shown");
            }

            SetLAB(RGB_TO_LAB(r, g, b));
            SetHSV(RGB_TO_HSV(r, g, b));

            NotifyChanges = true;
        }

        private void LAB_ValueChanged(object sender, EventArgs e)
        {
            if (!NotifyChanges) 
                return;

            NotifyChanges = false;

            var (r, g, b) = LAB_TO_RGB(
                (double)L_Input.Value,
                (double)A_Input.Value,
                (double)B_Input.Value);

            try
            {
                BackColor = Color.FromArgb((int) r, (int) g, (int) b);
            }
            catch (Exception)
            {
                MessageBox.Show("This color cannot be shown");
            }


            SetCMYK(RGB_TO_CMYK(r, g, b));
            SetHSV(RGB_TO_HSV(r, g, b));

            NotifyChanges = true;
        }

        private void HSV_ValueChanged(object sender, EventArgs e)
        {
            if (!NotifyChanges) 
                return;

            NotifyChanges = false;

            var (r, g, b) = HSV_TO_RGB(
                (double)H_Input.Value,
                (double)S_Input.Value,
                (double)V_Input.Value);

            try
            {
                BackColor = Color.FromArgb((int) r, (int) g, (int) b);
            }
            catch (Exception)
            {
                MessageBox.Show("This color cannot be shown");
            }

            SetCMYK(RGB_TO_CMYK(r, g, b));
            SetLAB(RGB_TO_LAB(r, g, b));

            NotifyChanges = true;
        }




        private static (double r, double g, double b) CMYK_TO_RGB(double c, double m, double y, double k)
        {
            var r = Math.Min(255, Math.Max(0, (255 * (1 - c) * (1 - k))));
            var g = Math.Min(255, Math.Max(0, (255 * (1 - m) * (1 - k))));
            var b = Math.Min(255, Math.Max(0, (255 * (1 - y) * (1 - k))));

            r = Math.Round(r);
            g = Math.Round(g);
            b = Math.Round(b);

            return (r, g, b);
        }

        private static (double c, double m, double y, double k) RGB_TO_CMYK(double r, double g, double b)
        {
            var k = Math.Min(Math.Min(1 - r / 255.0, 1 - g / 255.0), 1 - b / 255.0);

            if (k is 1)
            {
                return (0, 0, 0, 100);
            }

            var c = Math.Round((1 - (r / 255.0) - k) / (1 - k) * 100);
            var m = Math.Round((1 - (g / 255.0) - k) / (1 - k) * 100);
            var y = Math.Round((1 - (b / 255.0) - k) / (1 - k) * 100);
            k *= 100;

            return (c, m, y, k);
        }

        private static (double l, double a, double b) RGB_TO_LAB(double r, double g, double b)
        {
            var rn = F(r / 255.0);
            var gn = F(g / 255.0);
            var bn = F(b / 255.0);

            var x = 100 * (0.4125 * rn + 0.3576 * gn + 0.1804 * bn);
            var y = 100 * (0.2127 * rn + 0.7152 * gn + 0.0722 * bn);
            var z = 100 * (0.0193 * rn + 0.1192 * gn + 0.9502 * bn);

            return (
                Math.Round(116 * G(y / White.y) - 16),
                Math.Round(500 * (G(x / White.x) - G(y / White.y))),
                Math.Round(200 * (G(y / White.y) - G(z / White.z)))
            );

            double G(double x)
            {
                return (x >= 0.008856) ? Math.Pow(x, 1 / 3.0) : (7.787 * x + 16 / 116.0);
            }

            double F(double x)
            {
                return (x > 0.04045) ? (Math.Pow((x + 0.055 / 1.055), 2.4)) : (x / 12.92);
            }

        }

        private static (double r, double g, double b) LAB_TO_RGB(double l, double a, double b)
        {
           var (x,y,z) = (
                F(a / 500.0 + (l + 16) / 116.0) * White.x,
                F((l + 16) / 116.0) * White.y,
                F((l + 16) / 116.0 - b / 200.0) * White.z
            );

            var rn = 3.2406 * x / 100.0 - 1.5372 * y / 100.0 - 0.4986 * z / 100.0;
            var gn = -0.9689 * x / 100.0 + 1.8758 * y / 100.0 + 0.0415 * z / 100.0;
            var bn = 0.0557 * x / 100.0 - 0.2040 * y / 100.0 + 1.0570 * z / 100.0;

            var r = Math.Round(Math.Min(255, Math.Max(0, Math.Round(G(rn) * 255))));
            var g = Math.Round(Math.Min(255, Math.Max(0, Math.Round(G(gn) * 255))));
            var B = Math.Round(Math.Min(255, Math.Max(0, Math.Round(G(bn) * 255))));

            return (r, g, B);

            double F(double x)
            {
                return Math.Pow(x, 3) >= 0.008856 ? Math.Pow(x, 3.0) : (x - 16 / 116.0) / 7.787;
            }

            double G(double x)
            {
                return (x >= 0.0031308) ? (1.055 * Math.Pow(x, 1 / 2.4) - 0.055) : 12.92 * x;
            }
        }

        private static (double h, double s, double v) RGB_TO_HSV(double r, double g, double b)
        {
            r /= 255.0;
            g /= 255.0;
            b /= 255.0;

            var min = Math.Min(Math.Min(r, g), b);
            var max = Math.Max(Math.Max(r, g), b);
            var v = max;
            var delta = max - min;
            double s, h;
            if (max != 0)
                s = delta / max;
            else
            {
                s = 0;
                h = 0;
                return (h, s, v);
            }
            if (r == max)
                h = (g - b) / delta;
            else if (g == max)
                h = 2 + (b - r) / delta;
            else
                h = 4 + (r - g) / delta;
            h *= 60;

            if (h < 0)
                h += 360;

            h = Math.Round(h);
            s = Math.Round(s * 100);
            v = Math.Round(v * 100);

            return (h, s, v);
        }

        private static (double r, double g, double b) HSV_TO_RGB(double h, double s, double v)
        {
            int i;
            double f, m, n, k;
            double r, g, b;
            s /= 100.0;
            v /= 100.0;
            if (s == 0)
            {
                r = g = b = v;
            }
            else
            {
                h /= 60;
                i = (int)Math.Floor(h);
                f = h - i;
                m = v * (1 - s);
                n = v * (1 - s * f);
                k = v * (1 - s * (1 - f));

                switch (i)
                {
                    case 0: {
                        r = v; g = k; b = m;
                        break;
                    }
                    case 1: {
                        r = n; g = v; b = m;
                        break;
                    }
                    case 2: {
                        r = m; g = v; b = k;
                        break;
                    }
                    case 3: {
                        r = m; g = n; b = v;
                        break;
                    }
                    case 4: {
                        r = k; g = m; b = v;
                        break;
                    }
                    default: {
                        r = v; g = m; b = n;
                        break;
                    }
                }
            }

            r = Math.Round(r * 255);
            g = Math.Round(g * 255);
            b = Math.Round(b * 255);

            return (r, g, b);
        }
    }
}
