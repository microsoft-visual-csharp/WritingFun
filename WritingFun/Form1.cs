using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;


namespace WritingFun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义...
        string BGPath = @"Music\trip_128.mp3"; //背景音乐路径
        string KBPath = @"Sound\seq7_key3.wav"; //键盘音效路径
        string ErrorLog = null;
        int BGVolume = 40; //背景音乐音量
        int KBVolume = 80; //键盘音效音量
        int BGVolume_temp = 0; //背景音乐音量 静音存储
        int KBVolume_temp = 0; //键盘音效音量 静音存储

        Form2 form2 = new Form2();
        Screen[] screens = Screen.AllScreens;

        Ini ini = new Ini(Directory.GetCurrentDirectory() + @"\WritingFun.cfg");

        WMPLib.WindowsMediaPlayerClass BGplayer = new WMPLib.WindowsMediaPlayerClass();
        WMPLib.WindowsMediaPlayerClass KBplayer = new WMPLib.WindowsMediaPlayerClass();

        KeyboardHook kh;


        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left; //最左坐标
            public int Top; //最上坐标
            public int Right; //最右坐标
            public int Bottom; //最下坐标
        }



        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0x2;
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );

        public void CanPenetrate(IntPtr hwnd)
        {
            uint intExTemp = GetWindowLong(hwnd, GWL_EXSTYLE);
            uint oldGWLEx = SetWindowLong(hwnd, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            //SetLayeredWindowAttributes(this.Handle, 0, 200, LWA_ALPHA);
        }
        #endregion 定义结束

        #region 事件...
        //背景音乐单选事件
        private void toolStripMenuItem_BGSound_Click(object sender, EventArgs e)
        {
            SingleCheck(sender, 背景音乐ToolStripMenuItem.DropDownItems);
            BGPath = @"Music\" + ((ToolStripMenuItem)sender).Text + ".mp3";
            BGplaySound(BGPath, BGVolume, true);

            //写入ini文件
            ini.WriteValue("Music", "Name", BGPath);
        }

        //键盘音效单选事件
        private void toolStripMenuItem_KBEffect_Click(object sender, EventArgs e)
        {
            SingleCheck(sender, 键盘音效ToolStripMenuItem.DropDownItems);
            KBPath = @"Sound\" + ((ToolStripMenuItem)sender).Text + ".wav";

            //写入ini文件
            ini.WriteValue("Sound", "Name", KBPath);
        }



        //背景音乐音量单选事件
        private void toolStripMenuItem_BGSoundVolume_Click(object sender, EventArgs e)
        {
            SingleCheck(sender, 背景音量ToolStripMenuItem.DropDownItems);
            BGVolume = Convert.ToInt16(((ToolStripMenuItem)sender).Text);
            BGplayer.volume = BGVolume;
            全部静音ToolStripMenuItem.Checked = false;

            //写入ini文件
            ini.WriteValue("Music", "Volume", BGVolume.ToString());
        }


        //键盘音效音量单选事件
        private void toolStripMenuItem_KBEffectVolume_Click(object sender, EventArgs e)
        {
            SingleCheck(sender, 音效音量ToolStripMenuItem.DropDownItems);
            KBVolume = Convert.ToInt16(((ToolStripMenuItem)sender).Text);
            KBplayer.volume = KBVolume;
            全部静音ToolStripMenuItem.Checked = false;

            //写入ini文件
            ini.WriteValue("Sound", "Volume", KBVolume.ToString());
        }


        //按键触发的事件
        void kh_OnKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            KBplaySound(KBPath, KBVolume, false);
        }

        #region 音乐音效测试事件...
        //键盘音效测试事件
        private void toolStripMenuItem_KBEffect_MouseEnter(object sender, EventArgs e)
        {
            KBplaySoundTest(@"Sound\" + ((ToolStripMenuItem)sender).Text + ".wav", KBVolume, false);
        }

        //键盘音效音量测试事件
        private void toolStripMenuItem_KBEffectVolume_MouseEnter(object sender, EventArgs e)
        {
            KBplaySoundTest(KBPath, Convert.ToInt16(((ToolStripMenuItem)sender).Text), false);
        }

        //背景音乐音量测试事件
        private void toolStripMenuItem_BGSoundVolume_MouseEnter(object sender, EventArgs e)
        {
            BGplayer.volume = Convert.ToInt16(((ToolStripMenuItem)sender).Text);
        }

        //背景音乐音量测试恢复事件
        private void toolStripMenuItem_BGSoundVolume_MouseLeave(object sender, EventArgs e)
        {
            BGplayer.volume = BGVolume;
        }
        #endregion
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 全部静音ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (全部静音ToolStripMenuItem.Checked == true)
            {
                BGVolume_temp = BGplayer.volume;
                KBVolume_temp = KBplayer.volume;
                BGVolume = BGplayer.volume = 0;
                KBVolume = KBplayer.volume = 0;
            }
            else
            {
                BGVolume = BGplayer.volume = BGVolume_temp;
                KBVolume = KBplayer.volume = KBVolume_temp;
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region 方法...

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.ShowInTaskbar = false;

            kh = new KeyboardHook();
            kh.SetHook();
            kh.OnKeyPressEvent += kh_OnKeyPressEvent;

            BGplaySound(BGPath, BGVolume, true);

            #region 初始化...


            //CanPenetrate(); //鼠标穿透

            if (File.Exists("WritingFun.cfg"))
            {
                //获取配置文件信息
                BGPath = ini.ReadValue("Music", "Name");
                BGVolume = Convert.ToInt16(ini.ReadValue("Music", "Volume"));
                KBPath = ini.ReadValue("Sound", "Name");
                KBVolume = Convert.ToInt16(ini.ReadValue("Sound", "Volume"));
            }

            if (!File.Exists(BGPath)) ErrorLog = "\r\n背景音乐不存在，请确保程序目录的Music文件夹下存在上次选择的音乐文件！";
            if (!File.Exists(KBPath)) ErrorLog += "\r\n键盘音效不存在，请确保程序目录的Sound文件夹下存在上次选择的音效文件！";

            if (ErrorLog != null) MessageBox.Show(ErrorLog);

            //遍历背景音乐音量菜单
            foreach (ToolStripItem MenuItem in 背景音量ToolStripMenuItem.DropDownItems)
            {
                if (MenuItem.Text == BGVolume.ToString())
                {
                    ((ToolStripMenuItem)MenuItem).Checked = true;
                }
            }

            //遍历键盘音效音量菜单
            foreach (ToolStripItem MenuItem in 音效音量ToolStripMenuItem.DropDownItems)
            {
                if (MenuItem.Text == KBVolume.ToString())
                {
                    ((ToolStripMenuItem)MenuItem).Checked = true;
                }
            }
            #endregion

            #region 获取背景音乐文件...
            string[] MyBGSound = Directory.GetFiles("Music");
            int i = 0;

            this.背景音乐ToolStripMenuItem.DropDownItems.Clear();

            ToolStripMenuItem MyBGMenuNone = new ToolStripMenuItem();
            ToolStripSeparator MyBGMenuHr = new ToolStripSeparator();
            MyBGMenuNone.Name = "BG_None";
            MyBGMenuNone.Text = "无";
            MyBGMenuHr.Name = "BG_Hr";
            MyBGMenuNone.Click += new System.EventHandler(this.toolStripMenuItem_BGSound_Click);

            this.背景音乐ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            MyBGMenuNone,
            MyBGMenuHr});

            foreach (string mf in MyBGSound)
            {
                string BGList = Path.GetFileNameWithoutExtension(mf);

                ToolStripMenuItem MyBGMenu = new ToolStripMenuItem();
                MyBGMenu.Name = "BG_" + i;
                MyBGMenu.Text = BGList;
                MyBGMenu.Click += new System.EventHandler(this.toolStripMenuItem_BGSound_Click);
                this.背景音乐ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { MyBGMenu });
                if (Path.GetFileNameWithoutExtension(BGPath) == MyBGMenu.Text) MyBGMenu.Checked = true;
                i++;
            }
            #endregion


            #region 获取键盘音效文件...
            string[] MyKBEffect = Directory.GetFiles("Sound");
            int j = 0;

            this.键盘音效ToolStripMenuItem.DropDownItems.Clear();

            ToolStripMenuItem MyKBMenuNone = new ToolStripMenuItem();
            ToolStripSeparator MyKBMenuHr = new ToolStripSeparator();
            MyKBMenuNone.Name = "BG_None";
            MyKBMenuNone.Text = "无";
            MyKBMenuHr.Name = "BG_Hr";
            MyKBMenuNone.Click += new System.EventHandler(this.toolStripMenuItem_KBEffect_Click);

            this.键盘音效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MyKBMenuNone,
            MyKBMenuHr});

            foreach (string mf in MyKBEffect)
            {
                string BGList = Path.GetFileNameWithoutExtension(mf);

                ToolStripMenuItem MyKBMenu = new ToolStripMenuItem();
                MyKBMenu.Name = "BG_" + j;
                MyKBMenu.Text = BGList;
                MyKBMenu.Click += new System.EventHandler(this.toolStripMenuItem_KBEffect_Click);
                MyKBMenu.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffect_MouseEnter);
                this.键盘音效ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { MyKBMenu });
                if (Path.GetFileNameWithoutExtension(KBPath) == MyKBMenu.Text) MyKBMenu.Checked = true;
                j++;
            }
            #endregion



        }

        //播放背景音乐
        public void BGplaySound(string soundPath, int volume, bool loop)
        {
            BGplayer.URL = soundPath;
            BGplayer.uiMode = "none";

            BGplayer.settings.volume = volume;
            BGplayer.settings.playCount = 1;
            BGplayer.settings.setMode("loop", loop);  //循环播放
            BGplayer.play();

        }

        //播放键盘音效
        public void KBplaySound(string soundPath, int volume, bool loop)
        {
            KBplayer.URL = soundPath;
            KBplayer.uiMode = "none";

            KBplayer.settings.volume = volume;
            KBplayer.settings.playCount = 1;
            KBplayer.settings.setMode("loop", loop);  //循环播放
            KBplayer.play();

        }

        //键盘音效试音
        public void KBplaySoundTest(string soundPath, int volume, bool loop)
        {
            KBplayer.URL = soundPath;
            KBplayer.uiMode = "none";

            KBplayer.settings.volume = volume;
            KBplayer.settings.playCount = 5;
            KBplayer.settings.setMode("loop", loop);  //循环播放
            KBplayer.play();
        }

        //实现单选
        private void SingleCheck(object sender, ToolStripItemCollection StripItem)   //自定义函数   
        {

            foreach (ToolStripItem MenuItem in StripItem)
            {
                if (MenuItem is ToolStripMenuItem)
                {
                    ((ToolStripMenuItem)MenuItem).Checked = false;
                }
            }

            ((ToolStripMenuItem)sender).Checked = true;
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr awin = GetForegroundWindow(); //获取当前窗口句柄
            RECT rect = new RECT();
            GetWindowRect(awin, ref rect);
            int width = rect.Right - rect.Left; //窗口的宽度
            int height = rect.Bottom - rect.Top; //窗口的高度
            int x = rect.Left;
            int y = rect.Top;

            //form1
            label1.Location = new Point(x, y);
            label1.Size = new Size(width, height);

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            CanPenetrate(this.Handle);

            //form2
            form2.label1.Location = new Point(x - screens[1].WorkingArea.X, y - screens[1].WorkingArea.Y);
            form2.label1.Size = new Size(width, height);

            form2.Size = screens[1].WorkingArea.Size;
            form2.Location = screens[1].WorkingArea.Location;

            CanPenetrate(form2.Handle);
        }

        private void 关灯ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (关灯ToolStripMenuItem.Text == "关灯")
            {
                //form1
                if (this.TopMost == false) this.TopMost = true;
                this.Show();

                //form2
                if (screens.Length == 2)
                {
                    if (form2.TopMost == false) form2.TopMost = true;
                    form2.Show();
                }

                timer1.Enabled = true;
                关灯ToolStripMenuItem.Text = "开灯";
            }
            else
            {
                timer1.Enabled = false;
                关灯ToolStripMenuItem.Text = "关灯";
                this.Hide();
            }
        }
    }
}
