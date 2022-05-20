﻿using ArknightsWiki.Wiki;
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

namespace ArknightsWiki.UI
{
    public partial class MainFrame : Form
    {
        public User user = null;
        private EditorForm editorform;
        private MainPage mainpage;
        private LoginForm loginform;
        private PersonalForm personalForm;
        private RegisterForm registerform;
        DBManager dbManager;
        public MainFrame()
        {
            InitializeComponent();
            dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            editorform = new EditorForm();
            mainpage = new MainPage();
            loginform = new LoginForm(this);
            registerform = new RegisterForm();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
        }

        public void btn_mainPage_Click(object sender, EventArgs e)
        {
            //pnl_main.Controls.Clear();
            //pnl_main.Controls.Add(editorform);
            //SendKeys.Send("{F10}");
            //editorform.Show();
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(mainpage);
            mainpage.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        [DllImport("user32", CharSet = CharSet.Unicode)] 
        private static extern int mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo); 
        //移动鼠标 
        const int MOUSEEVENTF_MOVE = 0x0001;      
        //模拟鼠标左键按下 
        const int MOUSEEVENTF_LEFTDOWN = 0x0002; 
        //模拟鼠标左键抬起 
        const int MOUSEEVENTF_LEFTUP = 0x0004; 
        //模拟鼠标右键按下 
        const int MOUSEEVENTF_RIGHTDOWN = 0x0008; 
        //模拟鼠标右键抬起 
        const int MOUSEEVENTF_RIGHTUP = 0x0010; 
        //模拟鼠标中键按下 
        const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; 
        //模拟鼠标中键抬起
        const int MOUSEEVENTF_MIDDLEUP = 0x0040;  
        //标示是否采用绝对坐标
        const int MOUSEEVENTF_ABSOLUTE = 0x8000;
        #region 窗体操作

        /// <summary>
        /// 窗体拖动
        /// </summary>
        private void mianFrame_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        /// <summary>
        /// 绘制边框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.FromArgb(109, 155, 241));
            e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
        }

        /// <summary>
        /// 最小化窗体
        /// </summary>
        private void minPictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        private void closePictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        ///设置最小化和关闭图片tip提示
        /// </summary>
        private void SetToolTip()
        {
            //定义ToolTip对象
            ToolTip toolTip = new ToolTip();
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 100;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.btn_min, "最小化");
            toolTip.SetToolTip(this.btn_close, "关闭");
        }
        #endregion

        private void btn_operator_Click(object sender, EventArgs e)
        {
            editorform.fileName = "C:\\Users\\23887\\Desktop\\ArkWiki\\References\\md-fileloader-master\\Program\\MDLoader\\Resources\\WikiPages\\干员档案——阿米娅.md";
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(editorform);
            editorform.webBrowser1.Refresh();
            editorform.Show();
        }

        private void btn_readSource_Click(object sender, EventArgs e)
        {
            editorform.Visible = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, -150, 0, 0, 0);
            editorform.readSource();
            editorform.Visible = true;
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            editorform.Visible = false;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, -150, 0, 0, 0);
            editorform.fullscreen();
            editorform.webBrowser1.Refresh();
            editorform.Visible = true;
        }

        public void btn_login_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(loginform);
            loginform.Show();
        }

        public void btn_login_personal_Click(object sender, EventArgs e)
        {
            personalForm = new PersonalForm(this);
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(personalForm);
            personalForm.Show();
        }

        public void btn_register_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(registerform);
            registerform.Show();
        }
    }
}
