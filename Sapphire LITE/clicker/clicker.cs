using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Drawing.Text;

namespace Sapphire_Reborn.clicker {
    public class clicker {

        #region Misc

        const int DOWN = 0x0201, UP = 0x0202;
        const int RIGHT_DOWN = 0x0204, RIGHT_UP = 0x0205;

        public static Random r = new Random();
        private static Random rd = new Random();
        public static Timer goExhaust = new Timer(), notExhaust = new Timer(), exhaustRegen = new Timer(), exhaustLose = new Timer();
        public static int exhaustTime = 10000;
        
        #endregion

        #region Variables

        // conditions
        public static bool always_on = false, shift_disable = false, smart_mode = false;

        // other
        public static bool left_enabled = false, right_enabled = false, first_click = false;
        public static int left_min_cps = 12, left_max_cps = 16, right_min_cps = 20, right_max_cps = 28, randomization_distribution = 25;

        public static IntPtr minecraft_process = IntPtr.Zero;

        #endregion

        #region Clicker functionality

        public static void leftClickerThread()
        {
            goExhaust.Elapsed += new ElapsedEventHandler(setExhaust);
            goExhaust.Interval = 30000;
            while (true)
            {
                Thread.Sleep(1);

                minecraft_process = DLLImports.FindWindow("LWJGL", null);

                if (minecraft_process.ToString() != DLLImports.GetForegroundWindow().ToString()) continue;

                if (smart_mode & IsCursorVisisble() && !KeyListener.isKeyPressed(Keys.LShiftKey)) continue;

                if (shift_disable && KeyListener.isKeyPressed(Keys.LShiftKey)) continue;

                if (always_on)
                {
                    goExhaust.Start();
                    if (left_enabled) sendClick(left_min_cps, left_max_cps, DOWN, UP);
                }

                if (KeyListener.isKeyPressed(Keys.LButton) && left_enabled)
                {
                    goExhaust.Start();
                    sendClick(left_min_cps, left_max_cps, DOWN, UP);
                }
                if (!KeyListener.isKeyPressed(Keys.LButton) && left_enabled && !always_on)
                {
                    goExhaust.Stop();
                }
            }
        }

        public static void rightClickerThread() {
            while (true) {
                Thread.Sleep(1);

                minecraft_process = DLLImports.FindWindow("LWJGL", null);

                if (minecraft_process.ToString() != DLLImports.GetForegroundWindow().ToString()) continue;

                if (smart_mode & IsCursorVisisble() && !KeyListener.isKeyPressed(Keys.LShiftKey)) continue;

                if (shift_disable && KeyListener.isKeyPressed(Keys.LShiftKey)) continue;

                if (always_on) {
                    if (right_enabled) sendClick(right_min_cps, right_max_cps, RIGHT_DOWN, RIGHT_UP);
                }
                if (KeyListener.isKeyPressed(Keys.RButton) && right_enabled)
                {
                    sendClick(right_min_cps, right_max_cps, RIGHT_DOWN, RIGHT_UP);
                }
            }
        }

        public static void sendClick(int mincps,int maxcps,  uint type1, uint type2) {
            Random cps = new Random();
            Thread.Sleep(Rand(cps.Next(mincps, maxcps)));
            DLLImports.PostMessage(minecraft_process, type1, 0, 0);
            Thread.Sleep(Rand(cps.Next(mincps, maxcps)));
            DLLImports.PostMessage(minecraft_process, type2, 0, 0);
        }

        #endregion
         
        #region Randomization

        public static bool randomize = true, isExhausted = false;

        public static void loseExhaust(object source, ElapsedEventArgs e)
        {
            if (exhaustTime == 0) return;
            exhaustTime += -1;
        }

        public static void regenExhaust(object source, ElapsedEventArgs e)
        {
            if (exhaustTime == 10000) return;
            exhaustTime += 1;
        }

        public static void setExhaust(object source, ElapsedEventArgs e)
        {
            goExhaust.Stop();
            notExhaust.Elapsed += new ElapsedEventHandler(backToNormal);
            notExhaust.Interval = 5000;
            notExhaust.Start();
            void backToNormal(object src, ElapsedEventArgs eee)
            {
                notExhaust.Stop();
                goExhaust.Start();
            }
        }

        public static int Rand(int cps) {
            
            int exhaust = isExhausted ? 500 : 0;

            int numerator = randomize ? r.Next(475 - randomization_distribution, 475 + randomization_distribution) + exhaust : 520 + exhaust;

            int deviation = randomize ? deviation = rd.Next(0, 4) : deviation = 0;

            if (r.Next(100) < 5 && randomize) return r.Next(80, 150);

            return r.Next(100) < 5 ? (numerator / cps) : (numerator / r.Next(cps - deviation, cps + deviation));
        }

        #endregion

        #region Cursor visibility detection

        [DllImport("user32.dll")]
        private static extern bool GetCursorInfo(out CURSORINFO pci);

        [StructLayout(LayoutKind.Sequential)]
        struct POINT {
            public Int32 x;
            public Int32 y;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINT ptScreenPos;
        }

        static CURSORINFO GetCinfo() {
            CURSORINFO cinfo;
            cinfo.cbSize = Marshal.SizeOf(typeof(CURSORINFO));
            GetCursorInfo(out cinfo);
            return cinfo;
        }

        public static bool IsCursorVisisble() {
            CURSORINFO cinfo = GetCinfo();
            int cursorVal = Convert.ToInt32(cinfo.hCursor.ToInt64());

            if (Math.Abs(cursorVal) > 70000) return false;
            if (Math.Abs(cursorVal) < 70000) return true;
            return true;
        }

        #endregion
    }
}
