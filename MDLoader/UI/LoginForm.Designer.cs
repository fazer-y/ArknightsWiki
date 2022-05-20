using System.Drawing;
using ArknightsWiki.WinformEx;

namespace ArknightsWiki.UI
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pb_loginBG = new System.Windows.Forms.PictureBox();
            this.lbl_arkWiki = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.tb_pwd = new TextBoxEx(true, 30.0f, Color.AliceBlue);
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.btn_cancel = new ButtonEx(true, 20.0f, Color.AliceBlue);
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new ButtonEx(true, 20.0f, Color.AliceBlue);
            this.tb_userName = new TextBoxEx(true, 30.0f, Color.AliceBlue);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lbl_loginHead = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginBG)).BeginInit();
            this.pb_loginBG.SuspendLayout();
            this.pnl_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_loginBG
            // 
            this.pb_loginBG.BackgroundImage = global::ArknightsWiki.Properties.Resources.loginBG;
            resources.ApplyResources(this.pb_loginBG, "pb_loginBG");
            this.pb_loginBG.Controls.Add(this.lbl_arkWiki);
            this.pb_loginBG.Name = "pb_loginBG";
            this.pb_loginBG.TabStop = false;
            // 
            // lbl_arkWiki
            // 
            resources.ApplyResources(this.lbl_arkWiki, "lbl_arkWiki");
            this.lbl_arkWiki.BackColor = System.Drawing.Color.Transparent;
            this.lbl_arkWiki.Name = "lbl_arkWiki";
            // 
            // lbl_Pwd
            // 
            resources.ApplyResources(this.lbl_Pwd, "lbl_Pwd");
            this.lbl_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pwd.Name = "lbl_Pwd";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.tb_pwd, "tb_pwd");
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Name = "tb_pwd";
            // 
            // lbl_UserName
            // 
            resources.ApplyResources(this.lbl_UserName, "lbl_UserName");
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Name = "lbl_UserName";
            // 
            // pnl_login
            // 
            this.pnl_login.Controls.Add(this.btn_cancel);
            this.pnl_login.Controls.Add(this.btn_register);
            this.pnl_login.Controls.Add(this.btn_login);
            this.pnl_login.Controls.Add(this.tb_userName);
            this.pnl_login.Controls.Add(this.lbl_UserName);
            this.pnl_login.Controls.Add(this.lbl_Pwd);
            this.pnl_login.Controls.Add(this.tb_pwd);
            this.pnl_login.Cursor = System.Windows.Forms.Cursors.UpArrow;
            resources.ApplyResources(this.pnl_login, "pnl_login");
            this.pnl_login.Name = "pnl_login";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_cancel, "btn_cancel");
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_register, "btn_register");
            this.btn_register.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_register.Name = "btn_register";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_login, "btn_login");
            this.btn_login.Name = "btn_login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.UseWaitCursor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.BackColor = System.Drawing.Color.AliceBlue;
            resources.ApplyResources(this.tb_userName, "tb_userName");
            this.tb_userName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Location = new System.Drawing.Point(112, 15);
            // 
            // splitter1
            // 
            resources.ApplyResources(this.splitter1, "splitter1");
            this.splitter1.Name = "splitter1";
            this.splitter1.TabStop = false;
            // 
            // lbl_loginHead
            // 
            resources.ApplyResources(this.lbl_loginHead, "lbl_loginHead");
            this.lbl_loginHead.Name = "lbl_loginHead";
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lbl_loginHead);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pb_loginBG);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_loginBG)).EndInit();
            this.pb_loginBG.ResumeLayout(false);
            this.pb_loginBG.PerformLayout();
            this.pnl_login.ResumeLayout(false);
            this.pnl_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_loginBG;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label lbl_arkWiki;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_loginHead;
    }
}