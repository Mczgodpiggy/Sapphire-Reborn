using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sapphire_LITE.clicker;
using Sapphire_LITE.theme;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net;
using System.Management;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Auth
{
    public class Auth
    {
        string[] whitelists = { "BFEBFBFF000506E3" };
        public bool checkWhitelist(string HWID)
        {
            if (whitelists.Contains(HWID))
            {
                return true;
            } else { return false; }
        }
    }
}