using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArknightsWiki.Arknights;
using ArknightsWiki.Wiki;

namespace ArknightsWiki.UI
{
    public partial class LoginForm : Form
    {
        private string _username = "";
        private string _password = "";
        DBManager _dbManager;
        User user;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // 取消登录,关闭登录窗口
            Close();
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
                                reader["userName"].ToString(),
                                reader["userPwd"].ToString(),
                                reader["userEmail"].ToString());
                MessageBox.Show("登陆成功!");
            }
            else
            {
                // 登陆失败
                MessageBox.Show("账号或密码错误,请检查后重新输入.");
            }
            _dbManager.CloseDB();
        }
    }
}
