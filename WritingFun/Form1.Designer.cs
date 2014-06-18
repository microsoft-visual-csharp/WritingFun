namespace WritingFun
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全部静音ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.背景音乐ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景音量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.键盘音效ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.音效音量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.关灯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "右键功能：1.设置背景音乐；2.设置键盘音效；3.设置音量；4.对当前窗口开灯或者关灯。";
            this.notifyIcon1.BalloonTipTitle = "WritingFun";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "右键设置：\r\n1.背景音乐；\r\n2.键盘音效；\r\n3.音量；\r\n4.开灯、关灯";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部静音ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.背景音乐ToolStripMenuItem,
            this.背景音量ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.键盘音效ToolStripMenuItem,
            this.音效音量ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.关灯ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.退出ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 182);
            // 
            // 全部静音ToolStripMenuItem
            // 
            this.全部静音ToolStripMenuItem.CheckOnClick = true;
            this.全部静音ToolStripMenuItem.Name = "全部静音ToolStripMenuItem";
            this.全部静音ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全部静音ToolStripMenuItem.Text = "全部静音";
            this.全部静音ToolStripMenuItem.Click += new System.EventHandler(this.全部静音ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(121, 6);
            // 
            // 背景音乐ToolStripMenuItem
            // 
            this.背景音乐ToolStripMenuItem.Name = "背景音乐ToolStripMenuItem";
            this.背景音乐ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.背景音乐ToolStripMenuItem.Text = "背景音乐";
            // 
            // 背景音量ToolStripMenuItem
            // 
            this.背景音量ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11,
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.背景音量ToolStripMenuItem.Name = "背景音量ToolStripMenuItem";
            this.背景音量ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.背景音量ToolStripMenuItem.Text = "音乐音量";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem8.Text = "10";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem8.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem8.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem9.Text = "20";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem9.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem9.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem10.Text = "30";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem10.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem10.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem11.Text = "40";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem11.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem11.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem12.Text = "50";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem12.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem12.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem13.Text = "60";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem13.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem13.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem14.Text = "70";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem14.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem14.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem15.Text = "80";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem15.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem15.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem16.Text = "90";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem16.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem16.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem17.Text = "100";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_Click);
            this.toolStripMenuItem17.MouseEnter += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseEnter);
            this.toolStripMenuItem17.MouseLeave += new System.EventHandler(this.toolStripMenuItem_BGSoundVolume_MouseLeave);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 6);
            // 
            // 键盘音效ToolStripMenuItem
            // 
            this.键盘音效ToolStripMenuItem.Name = "键盘音效ToolStripMenuItem";
            this.键盘音效ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.键盘音效ToolStripMenuItem.Text = "键盘音效";
            // 
            // 音效音量ToolStripMenuItem
            // 
            this.音效音量ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem26,
            this.toolStripMenuItem27});
            this.音效音量ToolStripMenuItem.Name = "音效音量ToolStripMenuItem";
            this.音效音量ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.音效音量ToolStripMenuItem.Text = "音效音量";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem18.Text = "10";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem18.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem19.Text = "20";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem19.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem20.Text = "30";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem20.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem21.Text = "40";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem21.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem22.Text = "50";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem22.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem23.Text = "60";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem23.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem24.Text = "70";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem24.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem25.Text = "80";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem25.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem26.Text = "90";
            this.toolStripMenuItem26.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem26.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(97, 22);
            this.toolStripMenuItem27.Text = "100";
            this.toolStripMenuItem27.Click += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_Click);
            this.toolStripMenuItem27.MouseEnter += new System.EventHandler(this.toolStripMenuItem_KBEffectVolume_MouseEnter);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(121, 6);
            // 
            // 关灯ToolStripMenuItem
            // 
            this.关灯ToolStripMenuItem.CheckOnClick = true;
            this.关灯ToolStripMenuItem.Name = "关灯ToolStripMenuItem";
            this.关灯ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关灯ToolStripMenuItem.Text = "关灯";
            this.关灯ToolStripMenuItem.Click += new System.EventHandler(this.关灯ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(175, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 120);
            this.label1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(594, 477);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 全部静音ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 键盘音效ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 背景音量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem 音效音量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem23;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem24;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem26;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem27;
        private System.Windows.Forms.ToolStripMenuItem 背景音乐ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 关灯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    }
}

