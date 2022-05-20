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
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listB_hotRank = new System.Windows.Forms.ListBox();
            this.lbl_hotWiki = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 398);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 330);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 250);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 90);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 60);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 170);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_main.Location = new System.Drawing.Point(245, 108);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(813, 551);
            this.pnl_main.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listB_hotRank);
            this.panel1.Controls.Add(this.lbl_hotWiki);
            this.panel1.Location = new System.Drawing.Point(1080, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 321);
            this.panel1.TabIndex = 2;
            // 
            // listB_hotRank
            // 
            this.listB_hotRank.FormattingEnabled = true;
            this.listB_hotRank.Location = new System.Drawing.Point(3, 27);
            this.listB_hotRank.Name = "listB_hotRank";
            this.listB_hotRank.Size = new System.Drawing.Size(202, 290);
            this.listB_hotRank.TabIndex = 1;
            // 
            // lbl_hotWiki
            // 
            this.lbl_hotWiki.AutoSize = true;
            this.lbl_hotWiki.Location = new System.Drawing.Point(4, 10);
            this.lbl_hotWiki.Name = "lbl_hotWiki";
            this.lbl_hotWiki.Size = new System.Drawing.Size(59, 13);
            this.lbl_hotWiki.TabIndex = 0;
            this.lbl_hotWiki.Text = "近期热门";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 686);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}