namespace ArknightsWiki.UI
{
    partial class DropSubmit
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_chapter = new System.Windows.Forms.ComboBox();
            this.NumBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_opr = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_material = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "主题曲"});
            this.comboBox1.Location = new System.Drawing.Point(237, 91);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // cb_chapter
            // 
            this.cb_chapter.FormattingEnabled = true;
            this.cb_chapter.Items.AddRange(new object[] {
            "第零章",
            "第一章",
            "第二章",
            "第三章",
            "第四章",
            "第五章",
            "第六章",
            "第七章",
            "第八章",
            "第九章",
            "第十章"});
            this.cb_chapter.Location = new System.Drawing.Point(237, 161);
            this.cb_chapter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_chapter.Name = "cb_chapter";
            this.cb_chapter.Size = new System.Drawing.Size(155, 26);
            this.cb_chapter.TabIndex = 1;
            this.cb_chapter.SelectedIndexChanged += new System.EventHandler(this.cb_chapter_SelectedIndexChanged);
            // 
            // NumBox
            // 
            this.NumBox.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumBox.Location = new System.Drawing.Point(237, 371);
            this.NumBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumBox.Name = "NumBox";
            this.NumBox.Size = new System.Drawing.Size(154, 28);
            this.NumBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "关卡类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "章节选择";
            // 
            // cb_opr
            // 
            this.cb_opr.FormattingEnabled = true;
            this.cb_opr.Location = new System.Drawing.Point(237, 240);
            this.cb_opr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_opr.Name = "cb_opr";
            this.cb_opr.Size = new System.Drawing.Size(155, 26);
            this.cb_opr.TabIndex = 5;
            this.cb_opr.SelectedIndexChanged += new System.EventHandler(this.cb_opr_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "关卡选择";
            // 
            // cb_material
            // 
            this.cb_material.FormattingEnabled = true;
            this.cb_material.Location = new System.Drawing.Point(236, 308);
            this.cb_material.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_material.Name = "cb_material";
            this.cb_material.Size = new System.Drawing.Size(155, 26);
            this.cb_material.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "材料选择";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "掉落数量";
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(129, 444);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(84, 28);
            this.btn_cancle.TabIndex = 10;
            this.btn_cancle.Text = "取消";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(307, 444);
            this.btn_submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(84, 28);
            this.btn_submit.TabIndex = 11;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // DropSubmit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(530, 537);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_material);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_opr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumBox);
            this.Controls.Add(this.cb_chapter);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DropSubmit";
            this.Text = "掉落记录提交";
            ((System.ComponentModel.ISupportInitialize)(this.NumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cb_chapter;
        private System.Windows.Forms.NumericUpDown NumBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_opr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_material;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_submit;
    }
}