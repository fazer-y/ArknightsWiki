namespace ArknightsWiki.UI
{
    partial class EnemiesForm
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
            this.lbl_pageIndex = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_pre = new System.Windows.Forms.Button();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_searchOpr = new System.Windows.Forms.Button();
            this.cb_searchItem = new System.Windows.Forms.ComboBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_pageIndex
            // 
            this.lbl_pageIndex.AutoSize = true;
            this.lbl_pageIndex.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_pageIndex.Location = new System.Drawing.Point(776, 66);
            this.lbl_pageIndex.Name = "lbl_pageIndex";
            this.lbl_pageIndex.Size = new System.Drawing.Size(57, 19);
            this.lbl_pageIndex.TabIndex = 20;
            this.lbl_pageIndex.Text = "第1页";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(845, 66);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 19;
            this.btn_next.Text = "-->";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(695, 66);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(75, 23);
            this.btn_pre.TabIndex = 18;
            this.btn_pre.Text = "<--";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.Transparent;
            this.pnl_data.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl_data.Location = new System.Drawing.Point(11, 98);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(909, 522);
            this.pnl_data.TabIndex = 17;
            // 
            // btn_searchOpr
            // 
            this.btn_searchOpr.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_searchOpr.Location = new System.Drawing.Point(607, 26);
            this.btn_searchOpr.Name = "btn_searchOpr";
            this.btn_searchOpr.Size = new System.Drawing.Size(102, 28);
            this.btn_searchOpr.TabIndex = 16;
            this.btn_searchOpr.Text = "查找敌人";
            this.btn_searchOpr.UseVisualStyleBackColor = true;
            this.btn_searchOpr.Click += new System.EventHandler(this.btn_searchOpr_Click);
            // 
            // cb_searchItem
            // 
            this.cb_searchItem.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_searchItem.FormattingEnabled = true;
            this.cb_searchItem.Items.AddRange(new object[] {
            "敌人名称",
            "敌人特性",
            "攻击方式",
            "攻击力",
            "耐久",
            "防御力",
            "法术抗性"});
            this.cb_searchItem.Location = new System.Drawing.Point(171, 26);
            this.cb_searchItem.Name = "cb_searchItem";
            this.cb_searchItem.Size = new System.Drawing.Size(111, 26);
            this.cb_searchItem.TabIndex = 15;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("宋体", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_search.Location = new System.Drawing.Point(288, 23);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(300, 33);
            this.tb_search.TabIndex = 14;
            // 
            // EnemiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 631);
            this.Controls.Add(this.lbl_pageIndex);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.btn_searchOpr);
            this.Controls.Add(this.cb_searchItem);
            this.Controls.Add(this.tb_search);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnemiesForm";
            this.Text = "EnemiesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pageIndex;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Button btn_searchOpr;
        private System.Windows.Forms.ComboBox cb_searchItem;
        private System.Windows.Forms.TextBox tb_search;
    }
}