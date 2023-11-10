using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapphire_Reborn
{
    public partial class miscConfig : UserControl
    {
        public miscConfig()
        {
            InitializeComponent();
        }

        public static int XMIN = 0, XMAX = 0, YMIN = 0, YMAX = 0, jitter_interval = 1;
        public static bool jitter_toggled_x = false, jitter_toggled_y = false;

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
            jitter_toggled_x ^= true;
        }

        private void toggleJiterY(object sender, EventArgs e)
        {
            jitter_toggled_y ^= true;
        }
    }
}
