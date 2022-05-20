using ArknightsWiki.WinformEx;
using System.Drawing;
using ArknightsWiki.UI;

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
            this.btn_cancel = new ArknightsWiki.WinformEx.ButtonEx();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_login = new ArknightsWiki.WinformEx.ButtonEx();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.lbl_loginHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.crBorderPainting = System.Drawing.Color.AliceBlue;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 12.22642F);
            this.btn_cancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_cancel.Location = new System.Drawing.Point(274, 371);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(109, 40);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_pwd
            // 
            this.tb_pwd.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd.Location = new System.Drawing.Point(396, 293);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.PasswordChar = '*';
            this.tb_pwd.Size = new System.Drawing.Size(149, 31);
            this.tb_pwd.TabIndex = 9;
            // 
            // tb_userName
            // 
            this.tb_userName.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_userName.Location = new System.Drawing.Point(396, 224);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(149, 31);
            this.tb_userName.TabIndex = 8;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.Transparent;
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_register.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_register.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_register.Location = new System.Drawing.Point(608, 483);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(213, 30);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "尚无账号?点击注册";
            this.btn_register.UseVisualStyleBackColor = false;
            // 
            // btn_login
            // 
            this.btn_login.crBorderPainting = System.Drawing.Color.AliceBlue;
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 12.22642F);
            this.btn_login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_login.Location = new System.Drawing.Point(436, 371);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(109, 40);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.UseWaitCursor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_UserName.Font = new System.Drawing.Font("幼圆", 16.30189F);
            this.lbl_UserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_UserName.Location = new System.Drawing.Point(269, 230);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(103, 25);
            this.lbl_UserName.TabIndex = 0;
            this.lbl_UserName.Text = "用户名:";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pwd.Font = new System.Drawing.Font("幼圆", 16.30189F);
            this.lbl_Pwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Pwd.Location = new System.Drawing.Point(269, 299);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(103, 25);
            this.lbl_Pwd.TabIndex = 1;
            this.lbl_Pwd.Text = "密  码:";
            // 
            // lbl_loginHead
            // 
            this.lbl_loginHead.AutoSize = true;
            this.lbl_loginHead.BackColor = System.Drawing.Color.Transparent;
            this.lbl_loginHead.Font = new System.Drawing.Font("微软雅黑", 18.33962F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_loginHead.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_loginHead.Location = new System.Drawing.Point(299, 172);
            this.lbl_loginHead.Name = "lbl_loginHead";
            this.lbl_loginHead.Size = new System.Drawing.Size(196, 35);
            this.lbl_loginHead.TabIndex = 8;
            this.lbl_loginHead.Text = "ArknightsWiki";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.ClientSize = new System.Drawing.Size(833, 525);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_loginHead);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_userName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_Pwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "登录ArknightsWiki";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WinformEx.ButtonEx btn_cancel;
        private System.Windows.Forms.Button btn_register;
        private WinformEx.ButtonEx btn_login;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.Label lbl_loginHead;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.TextBox tb_userName;
    }
}