using ArknightsWiki.Wiki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    public partial class LoginForm : Form
    {
        private string _username = "";
        private string _password = "";
        DBManager _dbManager;
        public User user;
        public MainFrame owner;
        public LoginForm(MainFrame owner)
        {
            this.owner = owner;
            InitializeComponent();
            TopLevel = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            _username = tb_userName.Text;
            _password = tb_pwd.Text;

            _dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            _dbManager.OpenDB();
            SqlDataReader reader = _dbManager.SelectData("Users",
                                        $"userID='{_username}' and userPwd='{_password}'");

            if (reader.Read())
            {
                // 登录成功
                user = new User(reader["userID"].ToString(),
                                reader["userPwd"].ToString(),
                                reader["userName"].ToString(),
                                reader["userEmail"].ToString());
                MessageBox.Show("登陆成功!");
                owner.user = new User(user);
                owner.btn_login.Text = "个人中心";
                owner.btn_login.Click -= btn_login_Click;
                owner.btn_login.Click += owner.btn_login_personal_Click;
                owner.btn_mainPage_Click(sender, e);
                this.Visible = false;
            }
            else
            {
                // 登陆失败
                MessageBox.Show("账号或密码错误,请检查后重新输入.");
            }
            _dbManager.CloseDB();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // 取消登录,关闭登录窗口
            this.Visible = false;
        }

        //private void btn_register_Click(object sender, EventArgs e)
        //{
        //    RegisterForm registerForm = new RegisterForm();
        //    registerForm.Show();
        //    if (registerForm.user != null)
        //        user = registerForm.user;
        //    MessageBox.Show($"您的UID为{user.userID}，系统将自动登录。");
        //    this.Visible = false;
        //}
    }
}
