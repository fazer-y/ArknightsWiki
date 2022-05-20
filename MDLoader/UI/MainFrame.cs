using ArknightsWiki.Wiki;
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
        public User user;
        private EditorForm editorform;
        private MainPage mainpage;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            editorform = new EditorForm();
            mainpage = new MainPage();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
