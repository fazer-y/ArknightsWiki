using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArknightsWiki.Arknights;

namespace ArknightsWiki.UI
{
    public delegate void GetMD(string item, string name);
    public partial class OperatorForm : Form
    {
        public event GetMD oprMD;
        DataTable oprData = new DataTable();
        DataGridView dgv = null;
        int count = 0;
        public int pageIndex = 1;
        List<Operator> oprDataList = new List<Operator>();
        List<Operator> searchDataList = new List<Operator>();
        public OperatorForm()
        {
            InitializeComponent();
            TopLevel = false;
            cb_searchItem.SelectedIndex = 0;

            dgv = new DataGridView();
            dgv.Parent = this.pnl_data;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;

            oprData.Columns.Add("oprImage", typeof(string));
            oprData.Columns.Add("oprName", typeof(string));
            oprData.Columns.Add("oprRace", typeof(string));
            oprData.Columns.Add("oprTags", typeof(string));
            oprData.Columns.Add("oprSkills", typeof(string));

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Operators");

            while (reader.Read())
            {
                oprDataList.Add(new Operator(
                    reader["oprName"].ToString(),
                    reader["oprRace"].ToString(),
                    reader["oprTags"].ToString(),
                    reader["oprSkills"].ToString(),
                    "./Resources/" + reader["oprImagePath"]));
            }
            dbManager.CloseDB();

            while (count < 5)
            {
                oprData.Rows.Add(oprDataList[count].oprImagePath,
                    oprDataList[count].oprName,
                    oprDataList[count].oprRace,
                    string.Join(", ", oprDataList[count].oprTags),
                    string.Join(", ", oprDataList[count].oprSkills));
                count++;
            }

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.None;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersHeight = 30;

            dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVCell_MouseDoubleClick);

            dgv.Columns.Add(new DataGridViewImageColumn() { HeaderText = "干员头像", DataPropertyName = "oprImage" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "干员名称", DataPropertyName = "oprName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "干员种族", DataPropertyName = "oprRace" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "干员标签", DataPropertyName = "oprTags" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "干员技能", DataPropertyName = "oprSkills" });

            dgv.Columns[0].Width = 95;
            dgv.Columns[1].Width = 105;
            dgv.Columns[2].Width = 100;
            dgv.Columns[3].Width = 300;
            dgv.Columns[4].Width = 350;

            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            dgv.AllowUserToAddRows = false;

            dgv.DataSource = oprData;
        }

        void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                byte[] bytes = File.ReadAllBytes(e.Value.ToString());
                using (MemoryStream oldms = new MemoryStream(bytes))
                {
                    Image img = Image.FromStream(oldms);
                    Bitmap bt = new Bitmap(img, new Size(80, 80));
                    using (MemoryStream newms = new MemoryStream())
                    {
                        bt.Save(newms, ImageFormat.Jpeg);
                        e.Value = newms.ToArray();
                    }
                }
            }
        }


        private void OperatorForm_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“arkWikiDataSet.Operators”中。您可以根据需要移动或移除它。
            // this.operatorsTableAdapter.Fill(this.arkWikiDataSet.Operators); 
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            oprData.Rows.Clear();
            dgv.DataSource = oprData;
            if (count >= 10)
                count -= 10;
            else
                return;
            int max = count + 5;
            while (count < max && count < oprDataList.Count())
            {
                oprData.Rows.Add(oprDataList[count].oprImagePath,
                    oprDataList[count].oprName,
                    oprDataList[count].oprRace,
                    string.Join(", ", oprDataList[count].oprTags),
                    string.Join(", ", oprDataList[count].oprSkills));
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 5}页";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            oprData.Rows.Clear();
            int max = count + 5;
            while (count < max && count < oprDataList.Count())
            {
                oprData.Rows.Add(oprDataList[count].oprImagePath,
                    oprDataList[count].oprName,
                    oprDataList[count].oprRace,
                    string.Join(", ", oprDataList[count].oprTags),
                    string.Join(", ", oprDataList[count].oprSkills));
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 5}页";
        }

        private void DGVCell_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable table = (DataTable)dgv.DataSource;//数据源
                string oprName = table.Rows[e.RowIndex]["oprName"].ToString();
                oprMD("Operators", oprName);
            }
        }

        private void btn_searchOpr_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();

            string option = cb_searchItem.SelectedItem.ToString();
            switch (option)
            {
                case "干员名称":
                    option = "oprName";
                    break;
                case "干员标签":
                    option = "oprTags";
                    break;
                case "干员种族":
                    option = "oprRace";
                    break;
                case "干员技能":
                    option = "oprSkills";
                    break;
            }

            SqlDataReader reader = dbManager.SelectData("Operators", $"{option} like '%{tb_search.Text}%'");
            searchDataList.Clear();
            while (reader.Read())
            {
                searchDataList.Add(new Operator(
                    reader["oprName"].ToString(),
                    reader["oprRace"].ToString(),
                    reader["oprTags"].ToString(),
                    reader["oprSkills"].ToString(),
                    "./Resources/" + reader["oprImagePath"]));
            }
            dbManager.CloseDB();

            oprData.Clear();
            foreach (Operator o in searchDataList)
            {
                oprData.Rows.Add(o.oprImagePath, o.oprName, o.oprRace,
                    string.Join(", ", o.oprTags), string.Join(", ", o.oprSkills));
            }

            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.DataSource = oprData;
            btn_next.Enabled = false;
            btn_pre.Enabled = false;
        }
    }
}
