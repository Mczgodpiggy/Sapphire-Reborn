using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Sapphire_Reborn.clicker;
using Sapphire_Reborn.theme;
using System.Drawing.Drawing2D;
using System.Threading;
using System.IO;
using System.Net;
using System.Management;
using System.Linq;
using Guna.UI2.AnimatorNS;
using System.Security.AccessControl;
using Timer = System.Timers.Timer;
using System.Timers;
using System.ComponentModel;
using static System.Windows.Forms.LinkLabel;
using System.Reflection;
using WinFormAnimation;

namespace Sapphire_Reborn {
    public partial class Form1 : Form {

        #region Initialization

        public Form1() {
            InitializeComponent();
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            string hwid = dsk["VolumeSerialNumber"].ToString();
            Console.WriteLine($"{hwid}");

            Shadow.SetShadowForm(this);

            uint DesiredResolution = 1000;
            uint CurrentResolution;

            DLLImports.NtSetTimerResolution(DesiredResolution, true, out CurrentResolution);

            KeyListener.setupBindListener();
            Task.Run(() => bindThread());
            Task.Run(() => clicker.clicker.leftClickerThread());
            Task.Run(() => clicker.clicker.rightClickerThread());
            Task.Run(() => clicker.KeyListener.ListenForKeyPress());
            dlResources();
            reloadConfigs();
            hold.Elapsed += new ElapsedEventHandler(holdDelete);
            hold.Interval = 1000;
            hold.Stop();
            holdPlus.Elapsed += new ElapsedEventHandler(holdPPlus);
            holdPlus.Interval = 10;
            holdPlus.Stop();
            holdNeg.Elapsed += new ElapsedEventHandler(holdPNeg);
            holdNeg.Interval = 1;
            holdNeg.Stop();
        }


        private void reloadConfigs()
        {
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo cdir = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Configs"));
            if (cdir.Exists == false)
                cdir.Create();
            string configDir = System.IO.Path.Combine(cdir.FullName);
            string[] configs = Directory.GetFiles(configDir);
            foreach (string file in configs)
            {
                if (file.EndsWith(".sapphire"))
                    if (!configList.Items.Contains(file.Replace(cdir.FullName + "\\", "").Replace(".sapphire", "")))
                        configList.Items.Add(file.Replace(cdir.FullName + "\\", "").Replace(".sapphire", ""));
            }
        }

        private void FadeInTimer_Tick(object sender, EventArgs e) {
            if (this.Opacity == 1) FadeInTimer.Stop();
            else this.Opacity += 0.069;
        }

        public void dlResources()
        {
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Resources"));
            if (di.Exists == false)
            {
                di.Create();
            }
            var wc = new WebClient();
            var wwc = new WebClient();
            wc.DownloadFileAsync(
                    new Uri("https://github.com/Mczgodpiggy/Sapphire-Reborn/raw/main/Sapphire%20LITE/Resources/enable.wav"),
                    $@"{di.FullName}\\enable.wav"
                );
            wwc.DownloadFileAsync(
                new Uri("https://github.com/Mczgodpiggy/Sapphire-Reborn/raw/main/Sapphire%20LITE/Resources/disable.wav"),
                $@"{di.FullName}\\disable.wav"
            );
        }

        #endregion

        #region Controls

        private delegate void SafeDelCFG(object source, ElapsedEventArgs e);

        private readonly Timer hold = new Timer(), holdPlus = new Timer(), holdNeg = new Timer();

        Keys cfg_left_bind = Keys.None, cfg_right_bind = Keys.None;

        public bool bindInMenu = true;

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
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Configs"));
            if (di.Exists == false)
                di.Create();
            var dirr = System.IO.Path.Combine(di.FullName, CFGName);
            File.WriteAllText(dirr, $"{LACCheck.Checked}\n{RACCheck.Checked}\n{clmin}\n{clmax}\n{crmin}\n{crmax}\n{rand}\n{toggleRandomization.Checked}\n{toggleAlwaysOn.Checked}\n{toggleShiftDisable.Checked}\n{toggleSmartMode.Checked}\n{cfg_left_bind}\n{cfg_right_bind}\n{clicker.clicker.easyRefill}\n{bindInMenu}\n{clicker.clicker.shouldExhaust}\n{clicker.clicker.minExhaustTime}\n{clicker.clicker.maxExhaustTime}\n{clicker.clicker.minExhaustEndTime}\n{clicker.clicker.maxExhaustEndTime}");
            configStatus.ForeColor = Color.Green;
            configStatus.Text = $"Saved {ConfigName.Text} Successfully";
            configStatus.Visible = true;
            LoadedConfigText.Text = $"Loaded Config: {ConfigName.Text}";
            Task.Delay(1080).ContinueWith((task) =>
            {
                configStatus.Visible = false;
            });
            if (!configList.Items.Contains(ConfigName.Text))
            {
                configList.Items.Add(ConfigName.Text);
            }
            configList.Text = $"{LoadedConfigText.Text}";
        }

        public static bool isLoadingConfig = false, cjitter_toggled_x = false, cjitter_toggled_y = false;
        public static int cxmin = 0, cxmax = 0, cymin = 0, cymax = 0, cinterval = 0;

        private void ImportConfig(object sender, MouseEventArgs e)
        {
            if (ConfigName.Text == "")
            {
                configStatus.ForeColor = Color.Red;
                configStatus.Text = "Please enter a valid config name";
                configStatus.Visible = true;
                Task.Delay(1080).ContinueWith((task) =>
                {
                    configStatus.Visible = false;
                });
                return;
            }
            string CFGName = ConfigName.Text + ".sapphire";
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Configs"));
            var dirr = System.IO.Path.Combine(di.FullName, CFGName);
            if (!File.Exists(dirr))
            {
                configStatus.ForeColor = Color.Red;
                configStatus.Text = "Please enter a valid config name";
                configStatus.Visible = true;
                Task.Delay(1080).ContinueWith((task) =>
                {
                    configStatus.Visible = false;
                });
                return;
            }
            string[] cfg = File.ReadAllLines(dirr);
            Console.WriteLine(cfg.Length);
            if (cfg.Length < 20)
            {
                File.AppendAllText(dirr, "\nTrue\nFalse\nTrue\n10000\n10000\n5000\n5000");
                cfg = File.ReadAllLines(dirr);
            }
            int clmin = Int32.Parse(cfg[2]), clmax = Int32.Parse(cfg[3]), crmin = Int32.Parse(cfg[4]), crmax = Int32.Parse(cfg[5]), rand = Int32.Parse(cfg[6]), minexhausttime = Int32.Parse(cfg[16]), maxexhausttime = Int32.Parse(cfg[17]), minexhaustendtime = Int32.Parse(cfg[18]), maxexhaustendtime = Int32.Parse(cfg[19]);
            bool clenabled = Convert.ToBoolean(cfg[0]), crenabled = Convert.ToBoolean(cfg[1]), random = Convert.ToBoolean(cfg[7]), always_on = Convert.ToBoolean(cfg[8]), shift_disable = Convert.ToBoolean(cfg[9]), smart_mode = Convert.ToBoolean(cfg[10]), eRefill = Convert.ToBoolean(cfg[13]), BindInMenu = Convert.ToBoolean(cfg[14]), shouldGetExhausted = Convert.ToBoolean(cfg[15]);
            string LBind = cfg[11], RBind = cfg[12];
            Keys LB = (Keys)Enum.Parse(typeof(Keys), LBind, true), RB = (Keys)Enum.Parse(typeof(Keys), RBind, true);
            isLoadingConfig = true;
            clicker.clicker.shouldExhaust = shouldGetExhausted;
            clicker.clicker.minExhaustTime = minexhausttime;
            clicker.clicker.maxExhaustTime = maxexhausttime;
            clicker.clicker.minExhaustEndTime = minexhaustendtime;
            clicker.clicker.maxExhaustEndTime = maxexhaustendtime;
            ExhaustCheck.Checked = shouldGetExhausted;
            bindInMenu = BindInMenu;
            inMenuBindCheck.Checked = BindInMenu;
            clicker.clicker.easyRefill = eRefill;
            ERefillCheck.Checked = eRefill;
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
            clicker.clicker.randomization_distribution = rand;
            KeyListener.keysToCheck.Remove(left_bind);
            KeyListener.keybinds.Remove(left_bind);
            KeyListener.keysToCheck.Remove(right_bind);
            KeyListener.keybinds.Remove(right_bind);
            left_bind = LB;
            cfg_left_bind = LB;
            right_bind = RB;
            cfg_right_bind = RB;
            KeyListener.keysToCheck.Clear();
            if (LB.ToString() != "None")
            {
                leftClickerBindButton.Text = $"[{LB.ToString().ToLower()}]";
                cfg_left_bind = LB;
                KeyListener.keysToCheck.Add(left_bind);
            } else
            {
                leftClickerBindButton.Text = "[None]";
            }
            if (RB.ToString() != "None")
            {
                rightClickerBindButton.Text = $"[{RB.ToString().ToLower()}]";
                cfg_right_bind = RB;
                right_bind = RB;
                KeyListener.keysToCheck.Add(right_bind);
            } else
            {
                rightClickerBindButton.Text = "[None]";
            }
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
            configStatus.ForeColor = Color.Green;
            configStatus.Text = $"Loaded {ConfigName.Text} Successfully";
            configStatus.Visible = true;
            LoadedConfigText.Text = $"Loaded Config: {ConfigName.Text}";
            isLoadingConfig = false;
            Task.Delay(1080).ContinueWith((task) =>
            {
                configStatus.Visible = false;
            });
            configList.Text = $"{LoadedConfigText.Text}";
        }

        public void OpenConfigWindow(object sender, MouseEventArgs e)
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

        private void holdPPlus(object source, ElapsedEventArgs e)
        {
            if (configProgress.Value == 65)
            {
                holdPlus.Stop();
                return;
            }
            configProgress.Value += 1;
            progressDisplay.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Error;
            progressDisplay.Value += 1;
            Console.WriteLine(configProgress.Value);
        }

        private void holdPNeg(object source, ElapsedEventArgs e)
        {
            if (configProgress.Value == 0)
            {
                holdNeg.Stop();
            }
            configProgress.Value += -4;
            progressDisplay.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
            progressDisplay.Value += -4;
            Console.WriteLine(configProgress.Value);
        }

        private static string deletedConfig = "";

        private void holdDelete(object source, ElapsedEventArgs e)
        {
            Console.WriteLine(true);
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Configs"));
            if (configList.InvokeRequired)
            {
                var d = new SafeDelCFG(holdDelete);
                configList.Invoke(d, new object[] { source, e });
            } else
            {
                if (configList.SelectedItem == null)
                {
                    configStatus.ForeColor = Color.Red;
                    configStatus.Text = $"Please select a config";
                    configStatus.Visible = true;
                    hideConfigStatus(true);
                    return;
                }
                var dirr = System.IO.Path.Combine(di.FullName, configList.SelectedItem.ToString() + ".sapphire");
                if (dirr == null)
                {
                    configStatus.ForeColor = Color.Red;
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
                configStatus.ForeColor = Color.Green;
                configStatus.Text = $"Successfully deleted {deletedConfig}";
                configStatus.Visible = true;
                configList.Items.Remove(deletedConfig);
                hideConfigStatus(true);
            }
            hold.Stop();
            Task.Delay(100).ContinueWith((task) =>
            {
                for (int i = 0; i < 13; i++)
                {
                    Thread.Sleep(8);
                    configProgress.Value += -5;
                    progressDisplay.State = Guna.UI2.WinForms.Guna2TaskBarProgress.TaskbarStates.Normal;
                    progressDisplay.Value += -5;
                }
            });
        }

        private async void hideConfigStatus(bool yn)
        {
            if (yn)
            {
                await Task.Delay(1080).ContinueWith((task) =>
                {
                    configStatus.Visible = false;
                });
            }
        }

        private void holdDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons != MouseButtons.Left) return;
            hold.Start();
            holdPlus.Start();
            holdNeg.Stop();
        }

        private void holdUp(object sender, MouseEventArgs e)
        {
            hold.Stop();
            holdNeg.Start();
            holdPlus.Stop();
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

        private void repair(object sender, MouseEventArgs e)
        {
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Resources"));
            if (di.Exists == false)
            {
                di.Create();
            }
            Console.WriteLine(di.FullName);
            var wc = new WebClient();
            var wwc = new WebClient();
            wc.DownloadFileAsync(
                    new Uri("https://github.com/Mczgodpiggy/Sapphire-Reborn/raw/main/Sapphire%20LITE/Resources/enable.wav"),
                    $@"{di.FullName}\\enable.wav"
                );
            wwc.DownloadFileAsync(
                new Uri("https://github.com/Mczgodpiggy/Sapphire-Reborn/raw/main/Sapphire%20LITE/Resources/disable.wav"),
                $@"{di.FullName}\\disable.wav"
            );
        }

        private void jitterSlider_Scroll(object sender) {
            randomizationText.Text = $"{randomizationSlider.Value}%";
            clicker.clicker.randomization_distribution = randomizationSlider.Value;
        }

        private void configList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigName.Text = configList.SelectedItem.ToString();
        }

        #endregion

        #region Clicker & conditions
        private void toggleRandomization_CheckedChanged(object sender, EventArgs e) { clicker.clicker.randomize ^= true; }

        private void toggleShiftDisable_CheckedChanged(object sender, EventArgs e) { clicker.clicker.shift_disable ^= true; }

        private void toggleAlwaysOn_CheckedChanged(object sender, EventArgs e) { clicker.clicker.always_on ^= true; }

        private void ERefillCheck_Click(object sender, EventArgs e)
        {
            clicker.clicker.easyRefill = ERefillCheck.Checked;
        }

        private void inMenuBindCheck_CheckedChanged(object sender, EventArgs e)
        {
            bindInMenu = inMenuBindCheck.Checked;
        }

        private void ExhaustCheck_CheckedChanged(object sender, EventArgs e)
        {
            clicker.clicker.shouldExhaust = ExhaustCheck.Checked;
        }

        private void ExhaustMin_Scroll(object sender)
        {
            clicker.clicker.minExhaustTime = ExhaustMin.Value;
            if (ExhaustMax.Value < ExhaustMin.Value)
            {
                ExhaustMax.Value = ExhaustMin.Value;
            }
            exhaustMinText.Text = $"{ExhaustMin.Value}MS";
            clicker.clicker.goExhaust.Interval = ExhaustMin.Value;
        }

        private void ExhaustMax_Scroll(object sender)
        {
            clicker.clicker.maxExhaustTime = ExhaustMax.Value;
            if (ExhaustMax.Value < ExhaustMin.Value)
            {
                ExhaustMin.Value = ExhaustMax.Value;
            }
            exhaustMaxText.Text = $"{ExhaustMax.Value}MS";
        }

        private void exhaustEndMin_Scroll(object sender)
        {
            clicker.clicker.minExhaustEndTime = exhaustEndMin.Value;
            if (exhaustEndMax.Value < exhaustEndMin.Value)
            {
                exhaustEndMax.Value = exhaustEndMin.Value;
            }
            exhaustEndMinText.Text = $"{exhaustEndMin.Value}MS";
        }

        private void exhaustEndMax_Scroll(object sender)
        {
            clicker.clicker.maxExhaustEndTime = exhaustEndMax.Value;
            if (exhaustEndMax.Value < exhaustEndMin.Value)
            {
                exhaustEndMin.Value = exhaustEndMax.Value;
            }
            exhaustEndMaxText.Text = $"{exhaustEndMax.Value}MS";
        }

        private void toggleSmartMode_CheckedChanged(object sender, EventArgs e) {
            clicker.clicker.smart_mode = toggleSmartMode.Checked;
        }

        #endregion

        #region Binds
        public static IntPtr minecraft_process = IntPtr.Zero;

        Keys left_bind = Keys.None, right_bind = Keys.None;

        private void page_Scroll(object sender)
        {
            if (page.Value == 1)
            {
                PanelTransition.AnimationType = AnimationType.HorizSlide;
                PanelTransition.HideSync(miscConfigs1);
            } else if (page.Value == 2)
            {
                PanelTransition.AnimationType = AnimationType.HorizSlide;
                PanelTransition.ShowSync(miscConfigs1);
            }
        }

        public void bindThread()
        {
            var path = Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)).FullName.Replace("AppData", "");
            DirectoryInfo di = new DirectoryInfo(System.IO.Path.Combine(path, ".sapphire", "Resources"));
            while (true)
            {
                Thread.Sleep(10);
                KeyListener.keybinds[cfg_left_bind] = () =>
                {
                    minecraft_process = DLLImports.FindWindow("LWJGL", null);
                    if (clicker.clicker.IsCursorVisisble() && bindInMenu)
                    {
                        Console.WriteLine("1");
                        return;
                    }
                    if (minecraft_process.ToString() != DLLImports.GetForegroundWindow().ToString() && clicker.clicker.IsCursorVisisble() && bindInMenu)
                    {
                        Console.WriteLine("2");
                        return;
                    }
                    if (LACCheck.Checked == false)
                    {
                        Console.WriteLine($"LAC ON");
                        string[] file = Directory.GetFiles(di.FullName, "enable.wav");
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                        player.Play();
                        LACCheck.Checked = true;
                        LACCheck.FillColor2 = Color.FromArgb(118, 126, 226);
                    }
                    else if (LACCheck.Checked == true)
                    {
                        Console.WriteLine($"LAC OFF");
                        string[] file = Directory.GetFiles(di.FullName, "disable.wav");
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                        player.Play();
                        LACCheck.Checked = false;
                        LACCheck.FillColor2 = Color.FromArgb(213, 215, 247);
                    }
                    toggleLeftClicker();
                };
                KeyListener.keybinds[right_bind] = () =>
                {
                    if (clicker.clicker.IsCursorVisisble() && bindInMenu)
                    {
                        Console.WriteLine("1");
                        return;
                    }
                    if (minecraft_process.ToString() != DLLImports.GetForegroundWindow().ToString() && clicker.clicker.IsCursorVisisble() && bindInMenu)
                    {
                        Console.WriteLine("2");
                        return;
                    }
                    if (RACCheck.Checked == false)
                    {
                        string[] file = Directory.GetFiles(di.FullName, "enable.wav");
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                        player.Play();
                        RACCheck.Checked = true;
                        RACCheck.FillColor2 = Color.FromArgb(118, 126, 226);
                    }
                    else if (RACCheck.Checked == true)
                    {
                        string[] file = Directory.GetFiles(di.FullName, "disable.wav");
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(file[0]);
                        player.Play();
                        RACCheck.Checked = false;
                        RACCheck.FillColor2 = Color.FromArgb(213, 215, 247);
                    }
                    toggleRightClicker();
                };
            }
        }

        private async void leftClickerBindButton_MouseDown(object sender, MouseEventArgs e) {
            if (MouseButtons != MouseButtons.Left) return;

            leftClickerBindButton.Text = "[press a key]";

            KeyListener.keysToCheck.Remove(left_bind);
            KeyListener.keybinds.Remove(left_bind);

            left_bind = await KeyListener.getBind();

            if (left_bind == Keys.Escape) left_bind = Keys.None;
            leftClickerBindButton.Text = $"[{left_bind.ToString().ToLower()}]";
            cfg_left_bind = left_bind;
            KeyListener.keysToCheck.Add(left_bind);
        }

        private async void rightClickerBindButton_MouseDown(object sender, MouseEventArgs e) {
            if (MouseButtons != MouseButtons.Left) return;

            rightClickerBindButton.Text = "[press a key]";

            KeyListener.keysToCheck.Remove(right_bind);
            KeyListener.keybinds.Remove(right_bind);

            right_bind = await KeyListener.getBind();

            if (right_bind == Keys.Escape) right_bind = Keys.None;
            rightClickerBindButton.Text = $"[{right_bind.ToString().ToLower()}]";
            cfg_right_bind = right_bind;
            KeyListener.keysToCheck.Add(right_bind);
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
