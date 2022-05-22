namespace ArknightsWiki.UI
{
    partial class RegisterForm
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
            this.tb_nickName = new System.Windows.Forms.TextBox();
            this.lbl_nickName = new System.Windows.Forms.Label();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_nickName
            // 
            this.tb_nickName.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_nickName.Location = new System.Drawing.Point(420, 161);
            this.tb_nickName.MaxLength = 20;
            this.tb_nickName.Name = "tb_nickName";
            this.tb_nickName.Size = new System.Drawing.Size(194, 31);
            this.tb_nickName.TabIndex = 0;
            // 
            // lbl_nickName
            // 
            this.lbl_nickName.AutoSize = true;
            this.lbl_nickName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nickName.Font = new System.Drawing.Font("幼圆", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_nickName.Location = new System.Drawing.Point(314, 164);
            this.lbl_nickName.Name = "lbl_nickName";
            this.lbl_nickName.Size = new System.Drawing.Size(96, 27);
            this.lbl_nickName.TabIndex = 1;
            this.lbl_nickName.Text = "昵称：";
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passwd.Font = new System.Drawing.Font("幼圆", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_passwd.Location = new System.Drawing.Point(314, 223);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(96, 27);
            this.lbl_passwd.TabIndex = 2;
            this.lbl_passwd.Text = "密码：";
            // 
            // tb_pwd
            // 
            this.tb_pwd.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd.Location = new System.Drawing.Point(420, 220);
            this.tb_pwd.MaxLength = 20;
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(194, 31);
            this.tb_pwd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 18.33962F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(314, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "邮箱：";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_email.Location = new System.Drawing.Point(420, 284);
            this.tb_email.MaxLength = 30;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(194, 31);
            this.tb_email.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("宋体", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_register.Location = new System.Drawing.Point(497, 350);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(117, 44);
            this.btn_register.TabIndex = 6;
            this.btn_register.Text = "注册账号";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancle.Font = new System.Drawing.Font("幼圆", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancle.Location = new System.Drawing.Point(319, 350);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(113, 44);
            this.btn_cancle.TabIndex = 7;
            this.btn_cancle.Text = "取消注册";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 566);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.lbl_passwd);
            this.Controls.Add(this.lbl_nickName);
            this.Controls.Add(this.tb_nickName);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nickName;
        private System.Windows.Forms.Label lbl_nickName;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancle;
    }
}