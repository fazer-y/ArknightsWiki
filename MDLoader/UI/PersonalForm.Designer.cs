namespace ArknightsWiki.UI
{
    partial class PersonalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nickName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(192, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户昵称：";
            // 
            // tb_nickName
            // 
            this.tb_nickName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_nickName.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_nickName.Location = new System.Drawing.Point(397, 151);
            this.tb_nickName.Name = "tb_nickName";
            this.tb_nickName.Size = new System.Drawing.Size(301, 27);
            this.tb_nickName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(192, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "用户编号：";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_ID.Location = new System.Drawing.Point(392, 91);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(90, 25);
            this.lbl_ID.TabIndex = 19;
            this.lbl_ID.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(192, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "用户密码：";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_pwd.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd.Location = new System.Drawing.Point(397, 213);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(301, 27);
            this.tb_pwd.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(192, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "用户邮箱：";
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.Transparent;
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_change.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_change.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_change.Location = new System.Drawing.Point(197, 371);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(128, 35);
            this.btn_change.TabIndex = 23;
            this.btn_change.Text = "修改信息";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(570, 371);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 35);
            this.btn_save.TabIndex = 24;
            this.btn_save.Text = "保存修改";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tb_email
            // 
            this.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_email.Font = new System.Drawing.Font("幼圆", 16.30189F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_email.Location = new System.Drawing.Point(397, 290);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(301, 27);
            this.tb_email.TabIndex = 25;
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancle.FlatAppearance.BorderSize = 0;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancle.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancle.Location = new System.Drawing.Point(378, 371);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(128, 35);
            this.btn_cancle.TabIndex = 26;
            this.btn_cancle.Text = "取消修改";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 631);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nickName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalForm";
            this.Text = "个人中心";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nickName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btn_cancle;
    }
}