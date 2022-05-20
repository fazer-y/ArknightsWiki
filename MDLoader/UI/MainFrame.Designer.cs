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
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listB_hotRank = new System.Windows.Forms.ListBox();
            this.lbl_hotWiki = new System.Windows.Forms.Label();
            this.lbl_arkWiki = new System.Windows.Forms.Label();
            this.btn_readSource = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_history = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 108);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 551);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(3, 330);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(194, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "道具资料";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(3, 490);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "关卡掉落提交";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(3, 250);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "敌人档案";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(3, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "干员资料";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "首页";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(3, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "关卡一览";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(3, 410);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "公开招募";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.Location = new System.Drawing.Point(222, 108);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(849, 566);
            this.pnl_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listB_hotRank);
            this.panel1.Controls.Add(this.lbl_hotWiki);
            this.panel1.Location = new System.Drawing.Point(1080, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 348);
            this.panel1.TabIndex = 2;
            // 
            // listB_hotRank
            // 
            this.listB_hotRank.FormattingEnabled = true;
            this.listB_hotRank.Location = new System.Drawing.Point(3, 42);
            this.listB_hotRank.Name = "listB_hotRank";
            this.listB_hotRank.Size = new System.Drawing.Size(202, 303);
            this.listB_hotRank.TabIndex = 1;
            // 
            // lbl_hotWiki
            // 
            this.lbl_hotWiki.AutoSize = true;
            this.lbl_hotWiki.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_hotWiki.Location = new System.Drawing.Point(50, 10);
            this.lbl_hotWiki.Name = "lbl_hotWiki";
            this.lbl_hotWiki.Size = new System.Drawing.Size(102, 21);
            this.lbl_hotWiki.TabIndex = 0;
            this.lbl_hotWiki.Text = "近期热门";
            // 
            // lbl_arkWiki
            // 
            this.lbl_arkWiki.AutoSize = true;
            this.lbl_arkWiki.BackColor = System.Drawing.Color.Transparent;
            this.lbl_arkWiki.Font = new System.Drawing.Font("幼圆", 25.81132F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_arkWiki.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_arkWiki.Location = new System.Drawing.Point(5, 10);
            this.lbl_arkWiki.Name = "lbl_arkWiki";
            this.lbl_arkWiki.Size = new System.Drawing.Size(277, 38);
            this.lbl_arkWiki.TabIndex = 9;
            this.lbl_arkWiki.Text = "ArknightsWiki";
            // 
            // btn_readSource
            // 
            this.btn_readSource.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_readSource.Location = new System.Drawing.Point(1080, 518);
            this.btn_readSource.Name = "btn_readSource";
            this.btn_readSource.Size = new System.Drawing.Size(124, 26);
            this.btn_readSource.TabIndex = 10;
            this.btn_readSource.Text = "查看页面源代码";
            this.btn_readSource.UseVisualStyleBackColor = true;
            // 
            // btn_read
            // 
            this.btn_read.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_read.Location = new System.Drawing.Point(1080, 489);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(124, 26);
            this.btn_read.TabIndex = 11;
            this.btn_read.Text = "阅读";
            this.btn_read.UseVisualStyleBackColor = true;
            // 
            // btn_history
            // 
            this.btn_history.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_history.Location = new System.Drawing.Point(1080, 547);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(124, 26);
            this.btn_history.TabIndex = 12;
            this.btn_history.Text = "查看历史";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.button10_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(848, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 49);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btn_min
            // 
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_min.Location = new System.Drawing.Point(1240, 0);
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
            this.btn_close.Location = new System.Drawing.Point(1270, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 15;
            this.btn_close.Text = "×";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 686);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_history);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_readSource);
            this.Controls.Add(this.lbl_arkWiki);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mianFrame_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listB_hotRank;
        private System.Windows.Forms.Label lbl_hotWiki;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_arkWiki;
        private System.Windows.Forms.Button btn_readSource;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        private Button button8;
    }
}