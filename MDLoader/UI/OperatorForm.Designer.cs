namespace ArknightsWiki.UI
{
    partial class OperatorForm
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
            this.components = new System.ComponentModel.Container();
            this.operatorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arkWikiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arkWikiDataSet = new ArknightsWiki.ArkWikiDataSet();
            this.operatorsTableAdapter = new ArknightsWiki.ArkWikiDataSetTableAdapters.OperatorsTableAdapter();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_pre = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.lbl_pageIndex = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.cb_searchItem = new System.Windows.Forms.ComboBox();
            this.btn_searchOpr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // operatorsBindingSource
            // 
            this.operatorsBindingSource.DataMember = "Operators";
            this.operatorsBindingSource.DataSource = this.arkWikiDataSetBindingSource;
            // 
            // arkWikiDataSetBindingSource
            // 
            this.arkWikiDataSetBindingSource.DataSource = this.arkWikiDataSet;
            this.arkWikiDataSetBindingSource.Position = 0;
            // 
            // arkWikiDataSet
            // 
            this.arkWikiDataSet.DataSetName = "ArkWikiDataSet";
            this.arkWikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // operatorsTableAdapter
            // 
            this.operatorsTableAdapter.ClearBeforeFill = true;
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.Transparent;
            this.pnl_data.Location = new System.Drawing.Point(12, 98);
            this.pnl_data.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(909, 429);
            this.pnl_data.TabIndex = 0;
            // 
            // btn_pre
            // 
            this.btn_pre.Location = new System.Drawing.Point(702, 72);
            this.btn_pre.Name = "btn_pre";
            this.btn_pre.Size = new System.Drawing.Size(75, 23);
            this.btn_pre.TabIndex = 1;
            this.btn_pre.Text = "<--";
            this.btn_pre.UseVisualStyleBackColor = true;
            this.btn_pre.Click += new System.EventHandler(this.btn_pre_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(846, 70);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "-->";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // lbl_pageIndex
            // 
            this.lbl_pageIndex.AutoSize = true;
            this.lbl_pageIndex.Location = new System.Drawing.Point(783, 72);
            this.lbl_pageIndex.Name = "lbl_pageIndex";
            this.lbl_pageIndex.Size = new System.Drawing.Size(57, 19);
            this.lbl_pageIndex.TabIndex = 3;
            this.lbl_pageIndex.Text = "第1页";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("宋体", 14.9434F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_search.Location = new System.Drawing.Point(288, 23);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(300, 33);
            this.tb_search.TabIndex = 4;
            // 
            // cb_searchItem
            // 
            this.cb_searchItem.FormattingEnabled = true;
            this.cb_searchItem.Items.AddRange(new object[] {
            "干员名称",
            "干员种族",
            "干员标签",
            "干员技能"});
            this.cb_searchItem.Location = new System.Drawing.Point(171, 26);
            this.cb_searchItem.Name = "cb_searchItem";
            this.cb_searchItem.Size = new System.Drawing.Size(111, 26);
            this.cb_searchItem.TabIndex = 5;
            // 
            // btn_searchOpr
            // 
            this.btn_searchOpr.Font = new System.Drawing.Font("宋体", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_searchOpr.Location = new System.Drawing.Point(607, 26);
            this.btn_searchOpr.Name = "btn_searchOpr";
            this.btn_searchOpr.Size = new System.Drawing.Size(102, 28);
            this.btn_searchOpr.TabIndex = 6;
            this.btn_searchOpr.Text = "查找干员";
            this.btn_searchOpr.UseVisualStyleBackColor = true;
            this.btn_searchOpr.Click += new System.EventHandler(this.btn_searchOpr_Click);
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArknightsWiki.Properties.Resources.sunBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 566);
            this.Controls.Add(this.btn_searchOpr);
            this.Controls.Add(this.cb_searchItem);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.lbl_pageIndex);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_pre);
            this.Controls.Add(this.pnl_data);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            this.Load += new System.EventHandler(this.OperatorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.operatorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource arkWikiDataSetBindingSource;
        private ArkWikiDataSet arkWikiDataSet;
        private System.Windows.Forms.BindingSource operatorsBindingSource;
        private ArkWikiDataSetTableAdapters.OperatorsTableAdapter operatorsTableAdapter;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Button btn_pre;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label lbl_pageIndex;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.ComboBox cb_searchItem;
        private System.Windows.Forms.Button btn_searchOpr;
    }
}