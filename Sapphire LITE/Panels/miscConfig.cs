using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Sapphire_Reborn
{
    public partial class miscConfig : UserControl
    {
        public miscConfig()
        {
            InitializeComponent();
            Task.Run(() => reloadThread());
        }

        public static int XMIN = 0, XMAX = 0, YMIN = 0, YMAX = 0, jitter_interval = 1;
        public static bool jitter_toggled_x = false, jitter_toggled_y = false;

        private static bool reloading = false;

        public void reloadThread()
        {
            while (true)
            {
                Thread.Sleep(1);

                if (!Form1.isLoadingConfig) continue;

                int xmin = Form1.cxmin, xmax = Form1.cxmax, ymin = Form1.cymin, ymax = Form1.cymax, interval = Form1.cinterval;
                JitterXMin.Value = xmin;
                JitterXMax.Value = xmax;
                JitterYMin.Value = ymin;
                JitterYMax.Value = ymax;
                jitter_interval = interval;
                jitterXMinText.Text = $"{xmin}px";
                jitterXMaxText.Text = $"{xmax}px";
                jitterYMinText.Text = $"{ymin}px";
                jitterYMaxText.Text = $"{ymax}px";
                jitterIntervalText.Text = $"{interval}ms";
                jitterXCheck.Checked = Form1.cjitter_toggled_x;
                jitterYCheck.Checked = Form1.cjitter_toggled_y;
                jitter_toggled_x = Form1.cjitter_toggled_x;
                jitter_toggled_y = Form1.cjitter_toggled_y;
                Console.WriteLine($"{xmin} {xmax} {ymin} {ymax} {interval}\n{Form1.cjitter_toggled_x} {jitterXCheck.Checked}\n{Form1.cjitter_toggled_y} {jitterYCheck.Checked}");
                if (Form1.cjitter_toggled_x)
                {
                    jitterXCheck.FillColor2 = Color.FromArgb(118, 126, 226);
                }
                else if (!Form1.cjitter_toggled_x)
                {
                    jitterXCheck.FillColor2 = Color.FromArgb(213, 215, 247);
                    jitterXCheck.Update();
                }

                if (Form1.cjitter_toggled_y)
                {
                    jitterYCheck.FillColor2 = Color.FromArgb(118, 126, 226);
                    jitterYCheck.Update();
                }
                else if (!Form1.cjitter_toggled_y)
                {
                    jitterYCheck.FillColor2 = Color.FromArgb(213, 215, 247);
                    jitterYCheck.Update();
                }
            }
        }

        private void JitterXMin_Scroll(object sender)
        {
            if (JitterXMax.Value < JitterXMin.Value)
            {
                JitterXMax.Value = JitterXMin.Value;
            }
            jitterXMinText.Text = $"{JitterXMin.Value}px";
            XMIN = JitterXMin.Value;
        }

        private void JitterXMax_Scroll(object sender)
        {
            if (JitterXMax.Value < JitterXMin.Value)
            {
                JitterXMin.Value = JitterXMax.Value;
            }
            jitterXMaxText.Text = $"{JitterXMax.Value}px";
            XMAX = JitterXMax.Value;
        }

        private void JitterYMin_Scroll(object sender)
        {
            if (JitterYMax.Value < JitterYMin.Value)
            {
                JitterYMax.Value = JitterYMin.Value;
            }
            jitterYMinText.Text = $"{JitterYMin.Value}px";
            YMIN = JitterYMin.Value;
        }

        private void JitterYMax_Scroll(object sender)
        {
            if (JitterYMax.Value < JitterYMin.Value)
            {
                JitterYMin.Value = JitterYMax.Value;
            }
            jitterYMaxText.Text = $"{JitterYMax.Value}px";
            YMAX = JitterYMax.Value;
        }

        private void jitterInterval_Scroll(object sender)
        {
            jitterIntervalText.Text = $"{jitterInterval.Value}ms";
            jitter_interval = jitterInterval.Value;
        }

        private void toggleJiterX(object sender, EventArgs e)
        {
            if (jitterXCheck.Checked)
            {
                jitter_toggled_x = false;
                jitterXCheck.FillColor2 = Color.FromArgb(213, 215, 247);
            } else
            {
                jitter_toggled_x = true;
                jitterXCheck.FillColor2 = Color.FromArgb(118, 126, 226);
            }
        }

        private void toggleJiterY(object sender, EventArgs e)
        {
            if (jitterYCheck.Checked)
            {
                jitter_toggled_y = false;
                jitterYCheck.FillColor2 = Color.FromArgb(213, 215, 247);
            }
            else
            {
                jitter_toggled_y = true;
                jitterYCheck.FillColor2 = Color.FromArgb(118, 126, 226);
            }
        }
    }
}
