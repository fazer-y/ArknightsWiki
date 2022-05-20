using ArknightsWiki.Wiki;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    public partial class PersonalForm : Form
    {
        DBManager dbManager;
        User user;
        public PersonalForm()
        {
            InitializeComponent();
            TopLevel = false;
        }
        public PersonalForm(MainFrame owner)
        {
            this.dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            this.user = owner.user;
            InitializeComponent();
            this.lbl_ID.Text = user.userID;
            this.tb_nickName.Text = user.userName;
            this.tb_pwd.Text = user.userPwd;
            this.tb_email.Text = user.userEmail;
            TopLevel = false;
            this.tb_email.Enabled = false;
            this.tb_nickName.Enabled = false;
            this.tb_pwd.Enabled = false;
        }


        private void btn_change_Click(object sender, EventArgs e)
        {
            this.tb_email.Enabled = true;
            this.tb_nickName.Enabled = true;
            this.tb_pwd.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            dbManager.OpenDB();
            string pwd = tb_pwd.Text;
            string nickname = tb_nickName.Text;
            string email = tb_email.Text;
            if (!string.IsNullOrEmpty(pwd) && !(string.IsNullOrEmpty(nickname))
                && !string.IsNullOrEmpty(email))
            {
                dbManager.UpdateData("Users", $"userName='{nickname}', " +
                    $"userEmail='{email}', " +
                    $"userPwd='{pwd}'",
                    $"userID='{lbl_ID.Text}'");
                tb_email.Enabled = false;
                tb_nickName.Enabled = false;
                tb_pwd.Enabled = false;
                user.userPwd = pwd;
                user.userName = nickname;
                user.userEmail = email;
                MessageBox.Show("信息修改成功！");
            }
            else 
            {
                MessageBox.Show("信息格式有误，请检查后再次尝试！");
                this.tb_nickName.Text = user.userName;
                this.tb_pwd.Text = user.userPwd;
                this.tb_email.Text = user.userEmail;
            }
            dbManager.CloseDB();
        }
    }
}
