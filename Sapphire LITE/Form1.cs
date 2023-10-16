using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sapphire_LITE.clicker;
using Sapphire_LITE.theme;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Net;
using System.Management;
using System.Linq;
using static Sapphire_LITE.Login;
using Guna.UI2.AnimatorNS;
using System.Security.AccessControl;
using Timer = System.Timers.Timer;
using System.Timers;

namespace Sapphire_LITE {
    public partial class Form1 : Form {

        #region Initialization

        public Form1() {
            string[] whitelist = { "S-1-5-21-3418972225-2525873918-165025094-1001", "BFEBFBFF000806C1" };
            var mbs = new ManagementObjectSearcher("Select ProcessorId From Win32_processor");
            ManagementObjectCollection mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList.Cast<ManagementObject>())
            {
                id = mo["ProcessorId"].ToString();
                break;
            }
            string hwid = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
            InitializeComponent();

            Shadow.SetShadowForm(this);

            uint DesiredResolution = 5000;
            uint CurrentResolution;

            DLLImports.NtSetTimerResolution(DesiredResolution, true, out CurrentResolution);

            KeyListener.setupBindListener();

            Task.Run(() => clicker.clicker.clickerThread());

            Task.Run(() => clicker.KeyListener.ListenForKeyPress());
            presetSelector.AutoRoundedCorners = true;
            presetSelector.Animated = true;
            dlResources();
            if (hwid == whitelist[0])
            {
                ToolTip.SetToolTip(guna2ImageButton1, "Logged in as Mczgodpiggy");
            }
            if (hwid == whitelist[1])
            {
                ToolTip.SetToolTip(guna2ImageButton1, "Logged in as Zadge");
            }
            if (hwid != whitelist[0])
            {
                MessageBox.Show("If you have problems with the client please use the repair button before asking for support. Thanks!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!whitelist.Contains(hwid) && Whitelist.through != true)
            {
                System.Windows.Forms.Clipboard.SetText(hwid);
                MessageBox.Show("HWID not whitelisted your HWID has be copied to your clip board\nPlease contact the owner for support.\nThank you.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Run(new Login());
                Application.Exit();
                ToolTip.SetToolTip(guna2ImageButton1, $"Logged in {Whitelist.username}");
            }
            reloadConfigs();
            hold.Elapsed += new ElapsedEventHandler(holdDelete);
            hold.Interval = 1000;
        }

        private void reloadConfigs()
        {
            DirectoryInfo cdi = new DirectoryInfo("Configs");
            if (cdi.Exists == false)
                cdi.Create();
            string configDir = Path.Combine(cdi.FullName);
            string[] test = Directory.GetFiles(configDir);
            configList.Items.Clear();
            foreach (string file in test)
            {
                if (file.EndsWith(".sapphire"))
                configList.Items.Add(file.Replace(cdi.FullName + "\\", "").Replace(".sapphire", ""));
            }
        }

        private void FadeInTimer_Tick(object sender, EventArgs e) {
            if (this.Opacity == 1) FadeInTimer.Stop();
            else this.Opacity += 0.1;
        }

        public void dlResources()
        {
            DirectoryInfo di = new DirectoryInfo("Resources");
            if (di.Exists == false)
            {
                di.Create();
            }
            var wc = new WebClient();
            var wwc = new WebClient();
            wc.DownloadFileAsync(
                    new Uri("https://cdn.discordapp.com/attachments/848746306864152648/1116876542564372591/enable.wav"),
                    $@"{di.FullName}\\enable.wav"
                );
            wwc.DownloadFileAsync(
                new Uri("https://cdn.discordapp.com/attachments/848746306864152648/1116876563561058344/disable.wav"),
                $@"{di.FullName}\\disable.wav"
            );
        }

        #endregion

        #region Controls

        private delegate void SafeDelCFG(object source, ElapsedEventArgs e);

        private delegate void SafeDelStatus(bool yn);

        private static int deletePressed = 0;

        private readonly Timer hold = new Timer();

        Keys cfg_left_bind = Keys.None, cfg_right_bind = Keys.None;

        private void leftMinCpsSlider_Scroll(object sender) {
            if (leftMaxCpsSlider.Value < leftMinCpsSlider.Value)
            {
                leftMaxCpsSlider.Value = leftMinCpsSlider.Value;
            }
            leftMinCpsText.Text = $"{leftMinCpsSlider.Value / 10.0}";
            clicker.clicker.left_min_cps = (leftMinCpsSlider.Value / 10);
        }

        private void leftMaxCpsSlider_Scroll(object sender)
        {
            if (leftMaxCpsSlider.Value < leftMinCpsSlider.Value)
            {
                leftMinCpsSlider.Value = leftMaxCpsSlider.Value;
            }
            leftMaxCpsText.Text = $"{leftMaxCpsSlider.Value / 10.0}";
            clicker.clicker.left_max_cps = (leftMaxCpsSlider.Value / 10);
        }

        private void rightMinCpsSlider_Scroll(object sender) {
            if (rightMaxCpsSlider.Value < rightMinCpsSlider.Value)
            {
                rightMaxCpsSlider.Value = rightMinCpsSlider.Value;
            }
            rightMinCpsText.Text = $"{rightMinCpsSlider.Value / 10.0}";
            clicker.clicker.right_min_cps = (rightMinCpsSlider.Value / 10);
        }

        private void rightMaxCpsSlider_Scroll(object sender)
        {
            if (rightMaxCpsSlider.Value < rightMinCpsSlider.Value)
            {
                rightMinCpsSlider.Value = rightMaxCpsSlider.Value;
            }
            rightMaxCpsText.Text = $"{rightMaxCpsSlider.Value / 10.0}";
            clicker.clicker.right_max_cps = (rightMaxCpsSlider.Value / 10);
        }

        private void ToggleLAC(object sender, MouseEventArgs e)
        {
            toggleLeftClicker();
        }

        private void ToggleRAC(object sender, MouseEventArgs e)
        {
            toggleRightClicker();
        }

        private void AddConfig(object sender, MouseEventArgs e)
        {
            string CFGName = ConfigName.Text + ".sapphire";
            if (ConfigName.Text == "")
            {
                ConfigName.PlaceholderText = "Please enter a valid config name";
                Task.Delay(1080).ContinueWith((task) =>
                {
                    ConfigName.PlaceholderText = "Config Name";
                });
                return;
            }
            int clmin = leftMinCpsSlider.Value, clmax = leftMaxCpsSlider.Value, crmin = rightMinCpsSlider.Value, crmax = rightMaxCpsSlider.Value, rand = randomizationSlider.Value;
            DirectoryInfo di = new DirectoryInfo("Configs");
            if (di.Exists == false)
                di.Create();
            var dirr = Path.Combine(di.FullName, CFGName);
            File.WriteAllText(dirr, $"{LACCheck.Checked}\n{RACCheck.Checked}\n{clmin}\n{clmax}\n{crmin}\n{crmax}\n{rand}\n{toggleRandomization.Checked}\n{toggleAlwaysOn.Checked}\n{toggleShiftDisable.Checked}\n{toggleSmartMode.Checked}\n{cfg_left_bind}\n{cfg_right_bind}");
            ConfigName.PlaceholderText = $"Saved {ConfigName.Text} Successfully";
            LoadedConfigText.Text = $"Loaded Config: {ConfigName.Text}";
            ConfigName.Text = null;
            Task.Delay(1080).ContinueWith((task) =>
            {
                ConfigName.PlaceholderText = "Config Name";
            });
            reloadConfigs();
        }

        private void ImportConfig(object sender, MouseEventArgs e)
        {
            if (ConfigName.Text == "")
            {
                ConfigName.PlaceholderText = "Please enter a valid config name";
                Task.Delay(1080).ContinueWith((task) =>
                {
                    ConfigName.PlaceholderText = "Config Name";
                });
                return;
            }
            string CFGName = ConfigName.Text + ".sapphire";
            DirectoryInfo di = new DirectoryInfo("Configs");
            var dirr = Path.Combine(di.FullName, CFGName);
            if (dirr == null)
            {
                ConfigName.PlaceholderText = "Please enter a valid config name";
                Task.Delay(1080).ContinueWith((task) =>
                {
                    ConfigName.PlaceholderText = "Config Name";
                });
                return;
            }
            string[] cfg = File.ReadAllLines(dirr);
            int clmin = Int32.Parse(cfg[2]), clmax = Int32.Parse(cfg[3]), crmin = Int32.Parse(cfg[4]), crmax = Int32.Parse(cfg[5]), rand = Int32.Parse(cfg[6]);
            bool clenabled = Convert.ToBoolean(cfg[0]), crenabled = Convert.ToBoolean(cfg[1]), random = Convert.ToBoolean(cfg[7]), always_on = Convert.ToBoolean(cfg[8]), shift_disable = Convert.ToBoolean(cfg[9]), smart_mode = Convert.ToBoolean(cfg[10]);
            clicker.clicker.left_min_cps = clmin / 10;
            leftMinCpsText.Text = $"{clmin / 10.0}";
            leftMinCpsSlider.Value = clmin;
            clicker.clicker.left_max_cps = clmax / 10;
            leftMaxCpsText.Text = $"{clmax / 10.0}";
            leftMaxCpsSlider.Value = clmax;
            clicker.clicker.right_min_cps = crmin / 10;
            rightMinCpsText.Text = $"{crmin / 10}";
            rightMinCpsSlider.Value = crmin;
            clicker.clicker.right_max_cps = crmax / 10;
            rightMaxCpsText.Text = $"{crmax / 10.0}";
            rightMaxCpsSlider.Value = crmax;
            clicker.clicker.randomization_distribution = rand;
            randomizationText.Text = $"{rand}%";
            randomizationSlider.Value = rand;
            if (clenabled == true && clicker.clicker.left_enabled == false)
            {
                toggleLeftClicker();
                LACCheck.Checked = true;
            } else if (clenabled == false && clicker.clicker.left_enabled == true)
            {
                toggleLeftClicker();
                LACCheck.Checked = false;
            }
            if (crenabled == true && clicker.clicker.right_enabled == false)
            {
                toggleRightClicker();
                RACCheck.Checked = true;
            } else if (crenabled == false && clicker.clicker.right_enabled == true)
            {
                toggleRightClicker();
                RACCheck.Checked = false;
            }
            toggleRandomization.Checked = random;
            toggleAlwaysOn.Checked = always_on;
            toggleShiftDisable.Checked = shift_disable;
            toggleSmartMode.Checked = smart_mode;
            ConfigName.PlaceholderText = $"Loaded {ConfigName.Text} Successfully";
            LoadedConfigText.Text = $"Loaded Config: {ConfigName.Text}";
            presetSelector.SelectedIndex = 0;
            ConfigName.Text = null;
            Task.Delay(1080).ContinueWith((task) =>
            {
                ConfigName.PlaceholderText = "Config Name";
            });
            reloadConfigs();
        }

        private void OpenConfigWindow(object sender, MouseEventArgs e)
        {
            if (ConfigPanel.Visible == false)
            {
                PanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
                PanelTransition.ShowSync(ConfigPanel);
            }
            else if (ConfigPanel.Visible == true)
            {
                PanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
                PanelTransition.HideSync(ConfigPanel);
            }
            reloadConfigs();
        }

        private static string deletedConfig = "";

        private void holdDelete(object source, ElapsedEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("Configs");
            if (configList.InvokeRequired)
            {
                var d = new SafeDelCFG(holdDelete);
                configList.Invoke(d, new object[] { source, e });
            } else
            {
                if (configList.SelectedItem == null)
                {
                    return;
                }
                var dirr = Path.Combine(di.FullName, configList.SelectedItem.ToString() + ".sapphire");
                if (dirr == null)
                {
                    configStatus.Text = "Config doesn't exist";
                    configStatus.Visible = true;
                    Task.Delay(1080).ContinueWith((task) =>
                    {
                        configStatus.Visible = false;
                    });
                    return;
                }
                File.Delete(dirr);
                ConfigName.Text = "";
                deletedConfig = configList.SelectedItem.ToString();
                configStatus.Text = $"Successfully deleted ${deletedConfig}";
                    configStatus.Visible = true;
                isConfigDeleted(true);
                reloadConfigs();
            }
            hold.Stop();
        }

        private void isConfigDeleted(bool yn)
        {
            if (yn)
            {
                if (configStatus.InvokeRequired)
                {
                    var d = new SafeDelStatus(isConfigDeleted);
                    configStatus.Invoke(d, new object[] { yn });
                } else
                {
                    Thread.Sleep(1000);
                    configStatus.Visible = false;
                }
            }
        }

        private void holdDown(object sender, MouseEventArgs e)
        {
            hold.Start();
        }

        private void holdUp(object sender, MouseEventArgs e)
        {
            hold.Stop();
        }

        private void deleteConfig(object sender, MouseEventArgs e)
        {
            Task.Delay(3500).ContinueWith((task) =>
            {
                configStatus.Visible = false;
            });
            deletePressed += 1;
            if (deletePressed < 2)
            {
                configStatus.Text = "Press again to confirm";
                configStatus.Visible = true;
                Task.Delay(690).ContinueWith((task) =>
                {
                    configStatus.Visible = false;
                });
                return;
            }
            DirectoryInfo di = new DirectoryInfo("Configs");
            var dirr = Path.Combine(di.FullName, configList.SelectedItem.ToString() + ".sapphire");
            if (dirr == null)
            {
                configStatus.Text = "Config doesn't exist";
                configStatus.Visible = true;
                Task.Delay(1080).ContinueWith((task) =>
                {
                    configStatus.Visible = false;
                });
                return;
            }
            File.Delete(dirr);
            ConfigName.Text = "";
            configStatus.Text = $"Successfully deleted ${configList.SelectedItem}";
            configStatus.Visible = true;
            deletePressed = 0;
            Task.Delay(1080).ContinueWith((task) =>
            {
                configStatus.Visible = false;
            });
            reloadConfigs();
        }

        private void CloseConfigWindow(object sender, MouseEventArgs e)
        {
            PanelTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            PanelTransition.HideSync(ConfigPanel);
        }

        private void configListClick(object sender, EventArgs e)
        {
            configList.CustomizableEdges.BottomLeft ^= true;
            configList.CustomizableEdges.BottomRight ^= true;
        }

        private void presetSelectorClick(object sender, EventArgs e)
        {
            presetSelector.CustomizableEdges.BottomLeft ^= true;
            presetSelector.CustomizableEdges.BottomRight ^= true;
        }

        private void repair(object sender, MouseEventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("Resources");
            if (di.Exists == false)
            {
                di.Create();
            }
            Console.WriteLine(di.FullName);
            var wc = new WebClient();
            var wwc = new WebClient();
            wc.DownloadFileAsync(
                    new Uri("https://cdn.discordapp.com/attachments/848746306864152648/1116876542564372591/enable.wav"),
                    $@"{di.FullName}\\enable.wav"
                );
            wwc.DownloadFileAsync(
                new Uri("https://cdn.discordapp.com/attachments/848746306864152648/1116876563561058344/disable.wav"),
                $@"{di.FullName}\\disable.wav"
            );
        }

        private void jitterSlider_Scroll(object sender) {
            randomizationText.Text = $"{randomizationSlider.Value}%";
            clicker.clicker.randomization_distribution = randomizationSlider.Value;
        }

        private void presetSelector_SelectedIndexChanged(object sender, EventArgs e) {
            switch (presetSelector.SelectedIndex) {
            case 0:
                    leftMinCpsSlider.Value = 120;
                    leftMaxCpsSlider.Value = 160;
                    rightMinCpsSlider.Value = 200;
                    rightMaxCpsSlider.Value = 280;
                    break;

            case 1:
                    leftMinCpsSlider.Value = 100;
                    leftMaxCpsSlider.Value = 120;
                    rightMinCpsSlider.Value = 200;
                    rightMaxCpsSlider.Value = 280;
                    break;

            case 2:
                    leftMinCpsSlider.Value = 160;
                    leftMaxCpsSlider.Value = 240;
                    rightMinCpsSlider.Value = 200;
                    rightMaxCpsSlider.Value = 280;
                    break;
            }
        }

        private void configList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo("Configs");
            var dirr = Path.Combine(di.FullName, configList.SelectedItem.ToString() + ".sapphire");
            string[] cfg = File.ReadAllLines(dirr);
            int clmin = Int32.Parse(cfg[2]), clmax = Int32.Parse(cfg[3]), crmin = Int32.Parse(cfg[4]), crmax = Int32.Parse(cfg[5]), rand = Int32.Parse(cfg[6]);
            bool clenabled = Convert.ToBoolean(cfg[0]), crenabled = Convert.ToBoolean(cfg[1]), random = Convert.ToBoolean(cfg[7]), always_on = Convert.ToBoolean(cfg[8]), shift_disable = Convert.ToBoolean(cfg[9]), smart_mode = Convert.ToBoolean(cfg[10]);
            clicker.clicker.left_min_cps = clmin / 10;
            leftMinCpsText.Text = $"{clmin / 10.0}";
            leftMinCpsSlider.Value = clmin;
            clicker.clicker.left_max_cps = clmax / 10;
            leftMaxCpsText.Text = $"{clmax / 10.0}";
            leftMaxCpsSlider.Value = clmax;
            clicker.clicker.right_min_cps = crmin / 10;
            rightMinCpsText.Text = $"{crmin / 10}";
            rightMinCpsSlider.Value = crmin;
            clicker.clicker.right_max_cps = crmax / 10;
            rightMaxCpsText.Text = $"{crmax / 10.0}";
            rightMaxCpsSlider.Value = crmax;
            clicker.clicker.randomization_distribution = rand;
            randomizationText.Text = $"{rand}%";
            randomizationSlider.Value = rand;
            if (clenabled == true && clicker.clicker.left_enabled == false)
            {
                toggleLeftClicker();
                LACCheck.Checked = true;
            }
            else if (clenabled == false && clicker.clicker.left_enabled == true)
            {
                toggleLeftClicker();
                LACCheck.Checked = false;
            }
            if (crenabled == true && clicker.clicker.right_enabled == false)
            {
                toggleRightClicker();
                RACCheck.Checked = true;
            }
            else if (crenabled == false && clicker.clicker.right_enabled == true)
            {
                toggleRightClicker();
                RACCheck.Checked = false;
            }
            toggleRandomization.Checked = random;
            toggleAlwaysOn.Checked = always_on;
            toggleShiftDisable.Checked = shift_disable;
            toggleSmartMode.Checked = smart_mode;
            LoadedConfigText.Text = $"Loaded Config: {configList.SelectedItem}";
            ConfigName.Text = configList.SelectedItem.ToString();
        }

        #endregion

        #region Clicker & conditions
        private void toggleRandomization_CheckedChanged(object sender, EventArgs e) { clicker.clicker.randomize ^= true; }

        private void toggleShiftDisable_CheckedChanged(object sender, EventArgs e) { clicker.clicker.shift_disable ^= true; }

        private void toggleAlwaysOn_CheckedChanged(object sender, EventArgs e) { clicker.clicker.always_on ^= true; }

        private void toggleSmartMode_CheckedChanged(object sender, EventArgs e) {
            clicker.clicker.smart_mode ^= true;
        }

        #endregion

        #region Binds

        Keys left_bind = Keys.None, right_bind = Keys.None;

        private async void leftClickerBindButton_MouseDown(object sender, MouseEventArgs e) {
            if (MouseButtons != MouseButtons.Left) return;
            DirectoryInfo di = new DirectoryInfo("Resources");

            leftClickerBindButton.Text = "[press a key]";

            KeyListener.keysToCheck.Remove(left_bind);
            KeyListener.keybinds.Remove(left_bind);

            left_bind = await KeyListener.getBind();

            if (left_bind == Keys.Escape) left_bind = Keys.None;
            leftClickerBindButton.Text = $"[{left_bind.ToString().ToLower()}]";
            cfg_left_bind = left_bind;
            KeyListener.keysToCheck.Add(left_bind);
            KeyListener.keybinds[left_bind] = () =>
            {
                if (LACCheck.Checked == false)
                {
                    string[] file = Directory.GetFiles(di.FullName, "enable.wav");
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                    player.Play();
                    LACCheck.Checked = true;
                } else if (LACCheck.Checked == true)
                {
                    string[] file = Directory.GetFiles(di.FullName, "disable.wav");
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                    player.Play();
                    LACCheck.Checked = false;
                }
                toggleLeftClicker();
            };
        }

        private async void rightClickerBindButton_MouseDown(object sender, MouseEventArgs e) {
            if (MouseButtons != MouseButtons.Left) return;
            DirectoryInfo di = new DirectoryInfo("Resources");

            rightClickerBindButton.Text = "[press a key]";

            KeyListener.keysToCheck.Remove(right_bind);
            KeyListener.keybinds.Remove(right_bind);

            right_bind = await KeyListener.getBind();

            if (right_bind == Keys.Escape) right_bind = Keys.None;
            rightClickerBindButton.Text = $"[{right_bind.ToString().ToLower()}]";
            cfg_right_bind = right_bind;
            KeyListener.keysToCheck.Add(right_bind);
            KeyListener.keybinds[right_bind] = () =>
            {
                if (RACCheck.Checked == false)
                {
                    string[] file = Directory.GetFiles(di.FullName, "enable.wav");
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                    player.Play();
                    RACCheck.Checked = true;
                }
                else if (RACCheck.Checked == true)
                {
                    string[] file = Directory.GetFiles(di.FullName, "disable.wav");
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                    player.Play();
                    RACCheck.Checked = false;
                }
                toggleRightClicker();
            };
        }

        public async void toggleLeftClicker() {
            clicker.clicker.left_enabled ^= true;

            if (clicker.clicker.left_enabled) leftClickerBindButton.ForeColor = Color.Green;
            else leftClickerBindButton.ForeColor = Color.FromArgb(100, 100, 100);

            await Task.Delay(250);
        }

        public async void toggleRightClicker() {
            clicker.clicker.right_enabled ^= true;

            if (clicker.clicker.right_enabled) rightClickerBindButton.ForeColor = Color.Green;
            else rightClickerBindButton.ForeColor = Color.FromArgb(100, 100, 100);

            await Task.Delay(250);
        }


        #endregion
    }
}
