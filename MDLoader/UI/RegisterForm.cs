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
    public partial class RegisterForm : Form
    {
        DBManager dBManager;
        public User user = null;
        public RegisterForm()
        {
            InitializeComponent();
            TopLevel = false;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (tb_nickName.Text != "" && tb_pwd.Text != "" && tb_email.Text != "")
            {
                string nickName = tb_nickName.Text;
                string pwd = tb_pwd.Text;
                string email = tb_email.Text;
                dBManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
                dBManager.OpenDB();
                SqlDataReader reader = dBManager.SelectData("Users", "", "count(*)");
                int count = (int)reader[""];
                string uid = string.Format("{0:0000000000}", count);
                user = new User(uid, pwd, nickName, email);
                dBManager.InsertData("Users", user.ToString());
                MessageBox.Show($"注册成功!\n您的UID为{ user.userID}，系统将自动登录。");
            }
            else
            {
                MessageBox.Show("信息不全，请检查后重试！");
            }
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
