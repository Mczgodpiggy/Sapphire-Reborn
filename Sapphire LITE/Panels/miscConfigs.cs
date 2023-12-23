using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapphire_Reborn.Panels
{
    public partial class miscConfigs : UserControl
    {
        public miscConfigs()
        {
            InitializeComponent();
            Task.Run(() => reachThread());
        }

        static IntPtr[] processes;

        public static bool reachToggled = false, bindInMenu = false;

        readonly Memory scan = new Memory();

        public void reachThread()
        {
            while (true)
            {
                if (clicker.clicker.minecraft_process == IntPtr.Zero) continue;
                if (!reachToggled) continue;
                Thread.Sleep(1);
                Console.WriteLine("Reach thread");
                string reach = BitConverter.ToString(BitConverter.GetBytes(Convert.ToDouble(3.3))).Replace("-", "");
                Console.WriteLine(reach);
                processes = scan.ScanArray(scan.GetPID("javaw"), "00 00 00 00 00 00 08 40 00 00 00 00 00");
                for (int i = 0; i < processes.Count<IntPtr>(); i++)
                {
                    scan.WriteArray(processes[i], reach);
                }
            }
        }

        private void ERefillCheck_CheckedChanged(object sender, EventArgs e)
        {
            clicker.clicker.easyRefill = ERefillCheck.Checked;
        }

        private void ReachCheck_CheckedChanged(object sender, EventArgs e)
        {
            reachToggled = ReachCheck.Checked;
        }

        private void inMenuBindCheck_CheckedChanged(object sender, EventArgs e)
        {
            bindInMenu = inMenuBindCheck.Checked;
        }
    }
}
