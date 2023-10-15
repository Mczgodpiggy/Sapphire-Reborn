using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using System.Drawing.Text;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Sapphire_LITE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region misc
        

        string[] usernames = { "Mczgodpiggy", "Snow", "Zadge" };
        string[] pass = { "gliddri@6969", "SNOWYT@6969", "ZADGEOP@6969" };
        string[] keys = { "(RrB>$)gnD.sO*_HUD!k" };
        string[] dbusernames = { };
        string[] dbpass = { };
        string[] dbkeys = { };
        public static class Whitelist
        {
            public static bool through = false;
            public static string username = "";
        }
        #endregion

        #region controls
        private void LoginButton_MouseClick(object sender, MouseEventArgs e)
        {

            int index = -1;
            bool Namewrong = true;
            if (Username.Visible == true && Username.Text == "" || Password.Visible == true && Password.Text == "" || Key.Visible == true && Key.Text == "")
            {
                WrongPass.Visible = true;
                Task.Delay(1500).ContinueWith((task) =>
                {
                    WrongPass.Visible = false;
                });
                return;
            }
            if (keys.Contains(Key.Text))
            {
                Whitelist.through = true;
                Whitelist.username = "using key";
                WrongPass.Text = $"Successfully logged in using a key";
                WrongPass.ForeColor = Color.Green;
                WrongPass.Visible = true;
                Task.Delay(1500).ContinueWith((task) =>
                {
                    this.Close();
                });
                return;
            }
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == Username.Text)
                {
                    index = i;
                    Namewrong = false;
                    break;
                } 
            }
            if (Namewrong)
            {
                WrongPass.Visible = true;
                Task.Delay(1500).ContinueWith((task) =>
                {
                    WrongPass.Visible = false;
                    return;
                });
            }
            if (pass[index] == Password.Text)
            {
                Whitelist.through = true;
                WrongPass.Text = $"Successfully logged in as {Username.Text}";
                WrongPass.ForeColor = Color.Green;
                WrongPass.Visible = true;
                Whitelist.username = "as " + Username.Text;
                Task.Delay(1500).ContinueWith((task) =>
                {
                    this.Close();
                });
            } else if (pass[index] != Password.Text)
            {
                WrongPass.Visible = true;
                Task.Delay(1500).ContinueWith((task) =>
                {
                    WrongPass.Visible = false;
                });
                return;
            }
        }

        private void SwitchLoginType(object sender, MouseEventArgs e)
        {
            if (Username.Visible == true)
            {
                Username.Visible = false;
                Password.Visible = false;
                Key.Visible = true;
            } else
            {
                Username.Visible = true;
                Password.Visible = true;
                Key.Visible = false;
            }
        }

        private void Exit(object sender, MouseEventArgs e)
        {
            if (Whitelist.through == false)
            {
                Application.Exit();
            }
            throw new NotImplementedException();
        }

        private void exit(Process process)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}