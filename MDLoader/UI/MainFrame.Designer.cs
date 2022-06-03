using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_materail = new System.Windows.Forms.Button();
            this.btn_enemies = new System.Windows.Forms.Button();
            this.btn_operator = new System.Windows.Forms.Button();
            this.btn_mainPage = new System.Windows.Forms.Button();
            this.btn_operation = new System.Windows.Forms.Button();
            this.btn_recruit = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_arkWiki = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.arkWikiDataSet = new ArknightsWiki.ArkWikiDataSet();
            this.btn_login = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_drops = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_materail, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_drops, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_enemies, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_operator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_mainPage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_operation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_recruit, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 118);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 566);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_materail
            // 
            this.btn_materail.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_materail.Location = new System.Drawing.Point(4, 335);
            this.btn_materail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_materail.Name = "btn_materail";
            this.btn_materail.Size = new System.Drawing.Size(192, 60);
            this.btn_materail.TabIndex = 7;
            this.btn_materail.Text = "道具资料";
            this.btn_materail.UseVisualStyleBackColor = true;
            this.btn_materail.Click += new System.EventHandler(this.btn_materail_Click);
            // 
            // btn_enemies
            // 
            this.btn_enemies.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_enemies.Location = new System.Drawing.Point(4, 254);
            this.btn_enemies.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_enemies.Name = "btn_enemies";
            this.btn_enemies.Size = new System.Drawing.Size(192, 60);
            this.btn_enemies.TabIndex = 3;
            this.btn_enemies.Text = "敌人档案";
            this.btn_enemies.UseVisualStyleBackColor = true;
            this.btn_enemies.Click += new System.EventHandler(this.btn_enemies_Click);
            // 
            // btn_operator
            // 
            this.btn_operator.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_operator.Location = new System.Drawing.Point(4, 92);
            this.btn_operator.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_operator.Name = "btn_operator";
            this.btn_operator.Size = new System.Drawing.Size(192, 60);
            this.btn_operator.TabIndex = 1;
            this.btn_operator.Text = "干员资料";
            this.btn_operator.UseVisualStyleBackColor = true;
            this.btn_operator.Click += new System.EventHandler(this.btn_operator_Click);
            // 
            // btn_mainPage
            // 
            this.btn_mainPage.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_mainPage.Location = new System.Drawing.Point(4, 11);
            this.btn_mainPage.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_mainPage.Name = "btn_mainPage";
            this.btn_mainPage.Size = new System.Drawing.Size(192, 60);
            this.btn_mainPage.TabIndex = 0;
            this.btn_mainPage.Text = "首页";
            this.btn_mainPage.UseVisualStyleBackColor = true;
            this.btn_mainPage.Click += new System.EventHandler(this.btn_mainPage_Click);
            // 
            // btn_operation
            // 
            this.btn_operation.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_operation.Location = new System.Drawing.Point(4, 173);
            this.btn_operation.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_operation.Name = "btn_operation";
            this.btn_operation.Size = new System.Drawing.Size(192, 60);
            this.btn_operation.TabIndex = 2;
            this.btn_operation.Text = "关卡一览";
            this.btn_operation.UseVisualStyleBackColor = true;
            this.btn_operation.Click += new System.EventHandler(this.btn_operation_Click);
            // 
            // btn_recruit
            // 
            this.btn_recruit.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_recruit.Location = new System.Drawing.Point(4, 416);
            this.btn_recruit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_recruit.Name = "btn_recruit";
            this.btn_recruit.Size = new System.Drawing.Size(192, 60);
            this.btn_recruit.TabIndex = 5;
            this.btn_recruit.Text = "公开招募";
            this.btn_recruit.UseVisualStyleBackColor = true;
            this.btn_recruit.Click += new System.EventHandler(this.btn_recruit_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_main.Location = new System.Drawing.Point(225, 118);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(933, 631);
            this.pnl_main.TabIndex = 1;
            // 
            // lbl_arkWiki
            // 
            this.lbl_arkWiki.AutoSize = true;
            this.lbl_arkWiki.BackColor = System.Drawing.Color.Transparent;
            this.lbl_arkWiki.Font = new System.Drawing.Font("幼圆", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_arkWiki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_arkWiki.Location = new System.Drawing.Point(3, 9);
            this.lbl_arkWiki.Name = "lbl_arkWiki";
            this.lbl_arkWiki.Size = new System.Drawing.Size(387, 53);
            this.lbl_arkWiki.TabIndex = 9;
            this.lbl_arkWiki.Text = "ArknightsWiki";
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.Location = new System.Drawing.Point(1090, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(30, 30);
            this.btn_min.TabIndex = 14;
            this.btn_min.Text = "—";
            this.btn_min.UseVisualStyleBackColor = false;
            this.btn_min.Click += new System.EventHandler(this.minPictureBox_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_close.Location = new System.Drawing.Point(1126, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // arkWikiDataSet
            // 
            this.arkWikiDataSet.DataSetName = "ArkWikiDataSet";
            this.arkWikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_login
            // 
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_login.Location = new System.Drawing.Point(3, 3);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(125, 45);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "尚未登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_login);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(846, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 49);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btn_drops
            // 
            this.btn_drops.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_drops.Location = new System.Drawing.Point(4, 497);
            this.btn_drops.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btn_drops.Name = "btn_drops";
            this.btn_drops.Size = new System.Drawing.Size(192, 60);
            this.btn_drops.TabIndex = 6;
            this.btn_drops.Text = "掉落统计";
            this.btn_drops.UseVisualStyleBackColor = true;
            this.btn_drops.Click += new System.EventHandler(this.btn_drops_Click);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 761);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_arkWiki);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mianFrame_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_enemies;
        private System.Windows.Forms.Button btn_operation;
        private System.Windows.Forms.Button btn_operator;
        private System.Windows.Forms.Button btn_mainPage;
        private System.Windows.Forms.Button btn_recruit;
        public System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btn_materail;
        private System.Windows.Forms.Label lbl_arkWiki;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private ArkWikiDataSet arkWikiDataSet;
        public Button btn_login;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_drops;
    }
}