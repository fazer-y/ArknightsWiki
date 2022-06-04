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
    public delegate void LunchForm();
    public partial class DropsForm : Form
    {
        public event GetMD dropMD;
        public event LunchForm lunchSubmit;
        DataTable oprData = new DataTable();
        DataGridView dgv = null;
        int count = 0;
        public int pageIndex = 1;
        List<Drops> oprDataList = new List<Drops>();
        List<Drops> searchDataList = new List<Drops>();
        public DropsForm()
        {
            InitializeComponent();
            TopLevel = false;
            cb_searchItem.SelectedIndex = 0;
            cb_searchItem.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv = new DataGridView();
            dgv.Parent = this.pnl_data;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;

            oprData.Columns.Add("matName", typeof(string));
            oprData.Columns.Add("oprID", typeof(string));
            oprData.Columns.Add("sampleSize", typeof(string));
            oprData.Columns.Add("dropSize", typeof(string));
            oprData.Columns.Add("probability", typeof(string));
            oprData.Columns.Add("cost", typeof(string));

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Drops");

            while (reader.Read())
            {
                oprDataList.Add(new Drops(
                    reader["matName"].ToString(),
                    reader["oprID"].ToString(),
                    reader["sampleSize"].ToString(),
                    reader["dropSize"].ToString(),
                    reader["probability"].ToString(),
                    reader["cost"].ToString()));
            }
            dbManager.CloseDB();

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.ScrollBars = ScrollBars.None;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ReadOnly = true;
            dgv.ColumnHeadersHeight = 35;
            dgv.AllowUserToAddRows = false;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGVCell_MouseDoubleClick);

            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "道具名称", DataPropertyName = "matName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "关卡编号", DataPropertyName = "oprID" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "样本总数", DataPropertyName = "sampleSize" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "掉落总数", DataPropertyName = "dropSize" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "掉落概率", DataPropertyName = "probability" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "单件理智消耗", DataPropertyName = "cost" });

            dgv.Columns[0].Width = 150;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 140;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 150;
            dgv.Columns[5].Width = 200;

            dgv.AllowUserToAddRows = false;
            reloadData();
        }

        private void btn_pre_Click(object sender, EventArgs e)
        {
            oprData.Rows.Clear();
            dgv.DataSource = oprData;
            if (count >= 42)
                count -= 42;
            else
                return;
            int max = count + 21;
            while (count < max && count < oprDataList.Count())
            {
                oprData.Rows.Add(oprDataList[count].matName,
                    oprDataList[count].oprID,
                    oprDataList[count].sampleSize,
                    oprDataList[count].dropSize,
                    oprDataList[count].probability,
                    oprDataList[count].cost);
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 21}页";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            oprData.Rows.Clear();
            int max = count + 21;
            while (count < max && count < oprDataList.Count())
            {
                oprData.Rows.Add(oprDataList[count].matName,
                    oprDataList[count].oprID,
                    oprDataList[count].sampleSize,
                    oprDataList[count].dropSize,
                    oprDataList[count].probability,
                    oprDataList[count].cost);
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 21}页";
        }

        public void reloadData()
        {
            tb_search.Text = "";
            cb_searchItem.SelectedIndex = 0;
            count = 0;
            oprData.Rows.Clear();
            while (count < 21)
            {
                oprData.Rows.Add(oprDataList[count].matName,
                    oprDataList[count].oprID,
                    oprDataList[count].sampleSize,
                    oprDataList[count].dropSize,
                    oprDataList[count].probability,
                    oprDataList[count].cost);
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 20}页";
        }

        private void DGVCell_MouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataTable table = (DataTable)dgv.DataSource;//数据源
                string oprID = table.Rows[e.RowIndex]["oprID"].ToString();
                dropMD("Operations", oprID);
            }
        }

        private void btn_searchOpr_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();

            string option = cb_searchItem.SelectedItem.ToString();
            switch (option)
            {
                case "道具名称":
                    option = "matName";
                    break;
                case "关卡编号":
                    option = "oprID";
                    break;
            }

            SqlDataReader reader = dbManager.SelectData("Drops", $"{option} like '%{tb_search.Text}%'");
            searchDataList.Clear();
            while (reader.Read())
            {
                oprDataList.Add(new Drops(
                    reader["matName"].ToString(),
                    reader["oprID"].ToString(),
                    reader["sampleSize"].ToString(),
                    reader["dropSize"].ToString(),
                    reader["probability"].ToString(),
                    reader["cost"].ToString()));
            }
            dbManager.CloseDB();

            oprData.Clear();
            foreach (Drops o in searchDataList)
            {
                oprData.Rows.Add(o.matName, o.oprID, o.sampleSize, o.dropSize, o.probability, o.cost);
            }

            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.DataSource = oprData;
            btn_next.Enabled = false;
            btn_pre.Enabled = false;
        }

        private void btn_dropSubmit_Click(object sender, EventArgs e)
        {
            lunchSubmit();
        }
    }
}
