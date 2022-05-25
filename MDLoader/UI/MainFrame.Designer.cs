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
            this.btn_operator = new System.Windows.Forms.Button();
            this.btn_mainPage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_arkWiki = new System.Windows.Forms.Label();
            this.btn_readSource = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_wikiInfo = new System.Windows.Forms.Panel();
            this.tb_contributor = new System.Windows.Forms.TextBox();
            this.tb_wikiTags = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.arkWikiDataSet = new ArknightsWiki.ArkWikiDataSet();
            this.btn_discuss = new System.Windows.Forms.Button();
            this.pnl_editorBtn = new System.Windows.Forms.Panel();
            this.pnl_wikiDetail = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_createTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_changeTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_views = new System.Windows.Forms.TextBox();
            this.btn_expand = new System.Windows.Forms.Button();
            this.lbl_wikiID = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl_wikiInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).BeginInit();
            this.pnl_editorBtn.SuspendLayout();
            this.pnl_wikiDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_operator, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_mainPage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 5);
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
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button7.Location = new System.Drawing.Point(4, 335);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(192, 60);
            this.button7.TabIndex = 7;
            this.button7.Text = "道具资料";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(4, 497);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "关卡掉落提交";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(4, 254);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 60);
            this.button4.TabIndex = 3;
            this.button4.Text = "敌人档案";
            this.button4.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(4, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "关卡一览";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("幼圆", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button6.Location = new System.Drawing.Point(4, 416);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(192, 60);
            this.button6.TabIndex = 5;
            this.button6.Text = "公开招募";
            this.button6.UseVisualStyleBackColor = true;
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
            // btn_readSource
            // 
            this.btn_readSource.BackColor = System.Drawing.Color.Transparent;
            this.btn_readSource.FlatAppearance.BorderSize = 0;
            this.btn_readSource.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_readSource.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_readSource.Location = new System.Drawing.Point(206, 3);
            this.btn_readSource.Name = "btn_readSource";
            this.btn_readSource.Size = new System.Drawing.Size(100, 30);
            this.btn_readSource.TabIndex = 10;
            this.btn_readSource.Text = "源代码";
            this.btn_readSource.UseVisualStyleBackColor = false;
            this.btn_readSource.Click += new System.EventHandler(this.btn_readSource_Click);
            // 
            // btn_read
            // 
            this.btn_read.BackColor = System.Drawing.Color.Transparent;
            this.btn_read.FlatAppearance.BorderSize = 0;
            this.btn_read.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_read.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_read.Location = new System.Drawing.Point(103, 3);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(100, 30);
            this.btn_read.TabIndex = 11;
            this.btn_read.Text = "阅读";
            this.btn_read.UseVisualStyleBackColor = false;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
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
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_save.Location = new System.Drawing.Point(0, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 30);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "提交修改";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_wikiInfo
            // 
            this.pnl_wikiInfo.AutoSize = true;
            this.pnl_wikiInfo.BackColor = System.Drawing.Color.Transparent;
            this.pnl_wikiInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_wikiInfo.Controls.Add(this.lbl_title);
            this.pnl_wikiInfo.Controls.Add(this.lbl_wikiID);
            this.pnl_wikiInfo.Controls.Add(this.tb_views);
            this.pnl_wikiInfo.Controls.Add(this.label7);
            this.pnl_wikiInfo.Controls.Add(this.tb_changeTime);
            this.pnl_wikiInfo.Controls.Add(this.label6);
            this.pnl_wikiInfo.Controls.Add(this.tb_createTime);
            this.pnl_wikiInfo.Controls.Add(this.label5);
            this.pnl_wikiInfo.Controls.Add(this.tb_contributor);
            this.pnl_wikiInfo.Controls.Add(this.tb_wikiTags);
            this.pnl_wikiInfo.Controls.Add(this.label4);
            this.pnl_wikiInfo.Controls.Add(this.label3);
            this.pnl_wikiInfo.Controls.Add(this.label2);
            this.pnl_wikiInfo.Controls.Add(this.label1);
            this.pnl_wikiInfo.Font = new System.Drawing.Font("宋体", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl_wikiInfo.Location = new System.Drawing.Point(3, 3);
            this.pnl_wikiInfo.Name = "pnl_wikiInfo";
            this.pnl_wikiInfo.Size = new System.Drawing.Size(239, 386);
            this.pnl_wikiInfo.TabIndex = 18;
            // 
            // tb_contributor
            // 
            this.tb_contributor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_contributor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_contributor.Enabled = false;
            this.tb_contributor.Location = new System.Drawing.Point(13, 192);
            this.tb_contributor.Name = "tb_contributor";
            this.tb_contributor.ReadOnly = true;
            this.tb_contributor.Size = new System.Drawing.Size(221, 21);
            this.tb_contributor.TabIndex = 11;
            // 
            // tb_wikiTags
            // 
            this.tb_wikiTags.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_wikiTags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_wikiTags.Enabled = false;
            this.tb_wikiTags.Location = new System.Drawing.Point(13, 133);
            this.tb_wikiTags.Name = "tb_wikiTags";
            this.tb_wikiTags.ReadOnly = true;
            this.tb_wikiTags.Size = new System.Drawing.Size(221, 21);
            this.tb_wikiTags.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(10, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "贡献者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "页面标签";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "搜索标题";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "页面编号";
            // 
            // dgv_history
            // 
            this.dgv_history.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Location = new System.Drawing.Point(3, 392);
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.RowHeadersVisible = false;
            this.dgv_history.RowHeadersWidth = 45;
            this.dgv_history.RowTemplate.Height = 24;
            this.dgv_history.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_history.Size = new System.Drawing.Size(239, 201);
            this.dgv_history.TabIndex = 19;
            // 
            // arkWikiDataSet
            // 
            this.arkWikiDataSet.DataSetName = "ArkWikiDataSet";
            this.arkWikiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_discuss
            // 
            this.btn_discuss.BackColor = System.Drawing.Color.Transparent;
            this.btn_discuss.FlatAppearance.BorderSize = 0;
            this.btn_discuss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_discuss.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_discuss.Location = new System.Drawing.Point(309, 3);
            this.btn_discuss.Name = "btn_discuss";
            this.btn_discuss.Size = new System.Drawing.Size(100, 30);
            this.btn_discuss.TabIndex = 20;
            this.btn_discuss.Text = "讨论";
            this.btn_discuss.UseVisualStyleBackColor = false;
            // 
            // pnl_editorBtn
            // 
            this.pnl_editorBtn.BackColor = System.Drawing.Color.Transparent;
            this.pnl_editorBtn.Controls.Add(this.btn_expand);
            this.pnl_editorBtn.Controls.Add(this.btn_save);
            this.pnl_editorBtn.Controls.Add(this.btn_read);
            this.pnl_editorBtn.Controls.Add(this.btn_discuss);
            this.pnl_editorBtn.Controls.Add(this.btn_readSource);
            this.pnl_editorBtn.Font = new System.Drawing.Font("宋体", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnl_editorBtn.Location = new System.Drawing.Point(709, 82);
            this.pnl_editorBtn.Name = "pnl_editorBtn";
            this.pnl_editorBtn.Size = new System.Drawing.Size(449, 36);
            this.pnl_editorBtn.TabIndex = 21;
            this.pnl_editorBtn.Visible = false;
            // 
            // pnl_wikiDetail
            // 
            this.pnl_wikiDetail.BackColor = System.Drawing.Color.Transparent;
            this.pnl_wikiDetail.Controls.Add(this.dgv_history);
            this.pnl_wikiDetail.Controls.Add(this.pnl_wikiInfo);
            this.pnl_wikiDetail.Location = new System.Drawing.Point(1164, 82);
            this.pnl_wikiDetail.Name = "pnl_wikiDetail";
            this.pnl_wikiDetail.Size = new System.Drawing.Size(248, 602);
            this.pnl_wikiDetail.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "创建时间";
            // 
            // tb_createTime
            // 
            this.tb_createTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_createTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_createTime.Enabled = false;
            this.tb_createTime.Location = new System.Drawing.Point(13, 248);
            this.tb_createTime.Name = "tb_createTime";
            this.tb_createTime.ReadOnly = true;
            this.tb_createTime.Size = new System.Drawing.Size(221, 21);
            this.tb_createTime.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "修改时间";
            // 
            // tb_changeTime
            // 
            this.tb_changeTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_changeTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_changeTime.Enabled = false;
            this.tb_changeTime.Location = new System.Drawing.Point(13, 311);
            this.tb_changeTime.Name = "tb_changeTime";
            this.tb_changeTime.ReadOnly = true;
            this.tb_changeTime.Size = new System.Drawing.Size(221, 21);
            this.tb_changeTime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(10, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "浏览量";
            // 
            // tb_views
            // 
            this.tb_views.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_views.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_views.Enabled = false;
            this.tb_views.Location = new System.Drawing.Point(13, 360);
            this.tb_views.Name = "tb_views";
            this.tb_views.ReadOnly = true;
            this.tb_views.Size = new System.Drawing.Size(221, 21);
            this.tb_views.TabIndex = 17;
            // 
            // btn_expand
            // 
            this.btn_expand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expand.Location = new System.Drawing.Point(412, 3);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(37, 30);
            this.btn_expand.TabIndex = 21;
            this.btn_expand.Text = ">>";
            this.btn_expand.UseVisualStyleBackColor = true;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // lbl_wikiID
            // 
            this.lbl_wikiID.AutoSize = true;
            this.lbl_wikiID.Location = new System.Drawing.Point(10, 32);
            this.lbl_wikiID.Name = "lbl_wikiID";
            this.lbl_wikiID.Size = new System.Drawing.Size(62, 18);
            this.lbl_wikiID.TabIndex = 18;
            this.lbl_wikiID.Text = "label8";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(10, 85);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(62, 18);
            this.lbl_title.TabIndex = 19;
            this.lbl_title.Text = "label9";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1165, 761);
            this.Controls.Add(this.pnl_editorBtn);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_arkWiki);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_wikiDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrame";
            this.Text = "MainFrame";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mianFrame_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl_wikiInfo.ResumeLayout(false);
            this.pnl_wikiInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arkWikiDataSet)).EndInit();
            this.pnl_editorBtn.ResumeLayout(false);
            this.pnl_wikiDetail.ResumeLayout(false);
            this.pnl_wikiDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_operator;
        private System.Windows.Forms.Button btn_mainPage;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbl_arkWiki;
        public System.Windows.Forms.Button btn_readSource;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_close;
        public Button btn_login;
        public Button btn_save;
        private Panel pnl_wikiInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgv_history;
        private ArkWikiDataSet arkWikiDataSet;
        public Button btn_discuss;
        private Panel pnl_editorBtn;
        private Panel pnl_wikiDetail;
        private TextBox tb_contributor;
        private TextBox tb_wikiTags;
        private TextBox tb_createTime;
        private Label label5;
        private TextBox tb_views;
        private Label label7;
        private TextBox tb_changeTime;
        private Label label6;
        private Button btn_expand;
        private Label lbl_title;
        private Label lbl_wikiID;
    }
}