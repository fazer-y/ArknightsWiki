using ArknightsWiki.Wiki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDLoader;
using System.Diagnostics;

namespace ArknightsWiki.UI
{
    
    public partial class MainFrame : Form
    {
        public User user = null;
        public string wikiPageID = "";

        // 子页面
        private MainPage mainpage;
        private LoginForm loginform;
        private PersonalForm personalForm;
        private RegisterForm registerform;
        private OperatorForm operatorform;
        private EnemiesForm enemiesform;
        private OperationForm operationform;
        private MaterailForm materailform;
        private RecruitForm recruitform;
        private DropsForm dropsform;

        private string wikiPath = "";

        DBManager dbManager;
        public MainFrame()
        {
            InitializeComponent();
            dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            mainpage = new MainPage(this);
            loginform = new LoginForm(this);
            registerform = new RegisterForm();
            operatorform = new OperatorForm();
            operationform = new OperationForm();
            enemiesform = new EnemiesForm();
            materailform = new MaterailForm();
            dropsform = new DropsForm();
            recruitform = new RecruitForm();

            pnl_main.Controls.Add(mainpage);
            mainpage.Show();
        }
           

        private void MainFrame_Load(object sender, EventArgs e)
        {
        }

       
        #region 无边框显示
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
            closeProc("MDLoader");
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


        public void registerGetUser(User user)
        {
            this.user = new User(user);
            btn_login.Text = "个人中心";
            btn_login.Click -= btn_login_Click;
            btn_login.Click += btn_login_personal_Click;
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(mainpage);
            mainpage.Show();
        }

        public void loadMD(string item, string name)
        {
            dbManager.OpenDB();
            SqlDataReader reader = null;
            switch (item)
            {
                case "Operators":
                    reader = dbManager.SelectData("WikiPages", $"wikiTitle like '%{name}' and wikiTags='干员资料'", "*");
                    break;
                case "Enemies":
                    reader = dbManager.SelectData("WikiPages", $"wikiTitle like '%{name}' and wikiTags='敌人档案'", "*");
                    break;
                case "Operations":
                    reader = dbManager.SelectData("WikiPages", $"wikiTitle like '%{name}' and wikiTags='关卡一览'", "*");
                    break;
                case "Material":
                    reader = dbManager.SelectData("WikiPages", $"wikiTitle like '%{name}' and wikiTags='道具资料'", "*");
                    break;
                default:
                    reader = dbManager.SelectData("WikiPages", $"wikiTitle like '%{name}'", "*");
                    break;
            }
            
            if (reader.Read())
            {
                wikiPath = $"C:\\Users\\23887\\Desktop\\ArkWiki\\References\\md-fileloader-master\\Program\\MDLoader\\bin\\Debug\\"
                    + reader["wikiPath"];
                wikiPageID = reader["wikiID"].ToString();
            }
            dbManager.CloseDB();

            // 更新浏览量
            dbManager.OpenDB();
            dbManager.UpdateData("wikiPages", $"wikiPageViews=wikiPageViews+1", $"wikiID='{wikiPageID}'");
            dbManager.CloseDB();


            // 启动editormd
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Users\23887\Downloads\Compressed\md-fileloader-master\Program\MDLoader\bin\Debug\MDLoader.exe"; //启动的应用程序名称
            if(user != null)
                startInfo.Arguments = $"{wikiPath} {user.userID} {wikiPageID}";
            else
                startInfo.Arguments = $"{wikiPath} _ {wikiPageID}";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            Process.Start(startInfo);
            Console.WriteLine(startInfo.Arguments);
        }

        public void lunchSubmitForm()
        {
            DropSubmit dropSubmit = new DropSubmit();
            dropSubmit.sR += submitDrop;
            dropSubmit.ShowDialog();
        }

        public void submitDrop(string oprID, string matName, int amount)
        {
            DateTime currentDateTime = DateTime.Now;
            dbManager.OpenDB();
            dbManager.InsertData("DropsRecords", $"('{user.userID}', '{oprID}', '{currentDateTime.ToString()}', '{matName}', {amount})");
            dbManager.CloseDB();

            // 更新Drops表
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Drops", $"oprID='{oprID}' and matName='{matName}'");
            int sampleSize = 0;
            int dropSize = 0;
            double probability = 0.0;
            double cost = 0.0;
            int oprCost = 0;
            if (reader.Read())
            {
                int.TryParse(reader["sampleSize"].ToString(), out sampleSize);
                int.TryParse(reader["dropSize"].ToString(), out dropSize);
                double.TryParse(reader["probability"].ToString(), out probability);
                double.TryParse(reader["cost"].ToString(), out cost);
            }
            dbManager.CloseDB();

            dbManager.OpenDB();
            reader = dbManager.SelectData("Operations", $"oprID='{oprID}'", "cost");
            if (reader.Read())
                int.TryParse(reader["cost"].ToString(), out oprCost);
            dbManager.CloseDB();

            sampleSize++;
            dropSize += amount;
            probability = dropSize*1.00 / sampleSize;
            cost = probability * oprCost;

            dbManager.OpenDB();
            dbManager.UpdateData("Drops", $"sampleSize={sampleSize}, dropSize={dropSize}, probability={probability}, cost={cost} ", $"oprID='{oprID}' and matName='{matName}'");
            dbManager.CloseDB();
            MessageBox.Show("提交成功，感谢您的贡献！");
        }


        private void closeProc(string ProcName)
        {
            try
            {
                //获取Jt的所有进程
                Process[] processIdAry = Process.GetProcessesByName(ProcName);
                //如果有这个进程运行那么就是
                if (processIdAry.Count() > 0)
                {
                    for (int i = 0; i < processIdAry.Count(); i++)
                    {
                        Console.WriteLine("第{0}个{1}程序的ID:{2}", i, ProcName, processIdAry[i].Id);
                        processIdAry[i].Kill();
                        Console.WriteLine($"{ProcName}进程关闭成功！\n");
                    }
                }
                else
                {
                    Console.WriteLine($"{ProcName}进程没有运行");
                }
            }
            catch
            {
                Console.WriteLine($"无法关闭{ProcName}进程！");
            }
        }

        #region ButtonEvent
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
            registerform.register += registerGetUser;
            registerform.Show();
        }

        public void btn_mainPage_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(mainpage);
            mainpage.Show();
        }

        public void btn_recruit_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(recruitform);
            recruitform.Show();
        }

        private void btn_drops_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(dropsform);
            dropsform.dropMD += loadMD;
            dropsform.lunchSubmit += lunchSubmitForm;
            if(user == null)
                dropsform.btn_dropSubmit.Enabled = false;
            else
                dropsform.btn_dropSubmit.Enabled = true;
            dropsform.reloadData();
            dropsform.Show();
        }

        public void btn_operator_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(operatorform);
            operatorform.oprMD += loadMD;
            operatorform.reloadData();
            operatorform.Show();
        }

        public void btn_operation_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(operationform);
            operationform.operationMD += loadMD;
            operationform.reloadData();
            operationform.Show();
        }

        public void btn_enemies_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(enemiesform);
            enemiesform.eneMD += loadMD;
            enemiesform.reloadData();
            enemiesform.Show();
        }

        public void btn_materail_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(materailform);
            materailform.matMD += loadMD;
            materailform.reloadData();
            materailform.Show();
        }
        #endregion
    }
}
