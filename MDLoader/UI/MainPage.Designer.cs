
namespace ArknightsWiki.UI
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_recruit = new ArknightsWiki.WinformEx.ButtonEx();
            this.btn_materail = new ArknightsWiki.WinformEx.ButtonEx();
            this.btn_operation = new ArknightsWiki.WinformEx.ButtonEx();
            this.btn_operator = new ArknightsWiki.WinformEx.ButtonEx();
            this.btn_enemies = new ArknightsWiki.WinformEx.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ImageLocation = "0,0";
            this.pictureBox1.Location = new System.Drawing.Point(53, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(825, 291);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_recruit
            // 
            this.btn_recruit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_recruit.BackgroundImage = global::ArknightsWiki.Properties.Resources.RecruitIcon;
            this.btn_recruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_recruit.crBorderPainting = System.Drawing.Color.Empty;
            this.btn_recruit.Font = new System.Drawing.Font("微软雅黑", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_recruit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_recruit.Location = new System.Drawing.Point(758, 323);
            this.btn_recruit.Name = "btn_recruit";
            this.btn_recruit.Size = new System.Drawing.Size(120, 120);
            this.btn_recruit.TabIndex = 4;
            this.btn_recruit.Text = "公开招募";
            this.btn_recruit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_recruit.UseVisualStyleBackColor = false;
            this.btn_recruit.Click += new System.EventHandler(this.btn_recruit_Click);
            // 
            // btn_materail
            // 
            this.btn_materail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_materail.BackgroundImage = global::ArknightsWiki.Properties.Resources.MaterialIcon;
            this.btn_materail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_materail.crBorderPainting = System.Drawing.Color.Empty;
            this.btn_materail.Font = new System.Drawing.Font("微软雅黑", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_materail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_materail.Location = new System.Drawing.Point(587, 323);
            this.btn_materail.Name = "btn_materail";
            this.btn_materail.Size = new System.Drawing.Size(120, 120);
            this.btn_materail.TabIndex = 3;
            this.btn_materail.Text = "道具资料";
            this.btn_materail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_materail.UseVisualStyleBackColor = false;
            this.btn_materail.Click += new System.EventHandler(this.btn_materail_Click);
            // 
            // btn_operation
            // 
            this.btn_operation.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_operation.BackgroundImage = global::ArknightsWiki.Properties.Resources.OperationIcon;
            this.btn_operation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_operation.crBorderPainting = System.Drawing.Color.Empty;
            this.btn_operation.Font = new System.Drawing.Font("微软雅黑", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_operation.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_operation.Location = new System.Drawing.Point(407, 323);
            this.btn_operation.Name = "btn_operation";
            this.btn_operation.Size = new System.Drawing.Size(120, 120);
            this.btn_operation.TabIndex = 2;
            this.btn_operation.Text = "关卡一览";
            this.btn_operation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_operation.UseVisualStyleBackColor = false;
            this.btn_operation.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_operator
            // 
            this.btn_operator.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_operator.BackgroundImage = global::ArknightsWiki.Properties.Resources.OperatorIcon;
            this.btn_operator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_operator.crBorderPainting = System.Drawing.Color.Empty;
            this.btn_operator.Font = new System.Drawing.Font("微软雅黑", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_operator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_operator.Location = new System.Drawing.Point(53, 323);
            this.btn_operator.Name = "btn_operator";
            this.btn_operator.Size = new System.Drawing.Size(120, 120);
            this.btn_operator.TabIndex = 1;
            this.btn_operator.Text = "干员资料";
            this.btn_operator.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_operator.UseVisualStyleBackColor = false;
            this.btn_operator.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_enemies
            // 
            this.btn_enemies.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_enemies.BackgroundImage = global::ArknightsWiki.Properties.Resources.EnemiesIcon;
            this.btn_enemies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_enemies.crBorderPainting = System.Drawing.Color.Empty;
            this.btn_enemies.Font = new System.Drawing.Font("微软雅黑", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_enemies.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_enemies.Location = new System.Drawing.Point(236, 323);
            this.btn_enemies.Name = "btn_enemies";
            this.btn_enemies.Size = new System.Drawing.Size(120, 120);
            this.btn_enemies.TabIndex = 0;
            this.btn_enemies.Text = "敌人档案";
            this.btn_enemies.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_enemies.UseVisualStyleBackColor = false;
            this.btn_enemies.Click += new System.EventHandler(this.btn_enemies_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 631);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_recruit);
            this.Controls.Add(this.btn_materail);
            this.Controls.Add(this.btn_operation);
            this.Controls.Add(this.btn_operator);
            this.Controls.Add(this.btn_enemies);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "MainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinformEx.ButtonEx btn_enemies;
        private WinformEx.ButtonEx btn_operator;
        private WinformEx.ButtonEx btn_operation;
        private WinformEx.ButtonEx btn_materail;
        private WinformEx.ButtonEx btn_recruit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}