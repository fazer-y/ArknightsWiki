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
    public partial class OperationForm : Form
    {
        public event GetMD operationMD;
        DataTable oprData = new DataTable();
        DataGridView dgv = null;
        int count = 0;
        public int pageIndex = 1;
        List<Operation> oprDataList = new List<Operation>();
        List<Operation> searchDataList = new List<Operation>();
        public OperationForm()
        {
            InitializeComponent();
            TopLevel = false;
            cb_searchItem.SelectedIndex = 0;
            cb_searchItem.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv = new DataGridView();
            dgv.Parent = this.pnl_data;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;

            oprData.Columns.Add("oprImage", typeof(string));
            oprData.Columns.Add("oprID", typeof(string));
            oprData.Columns.Add("oprName", typeof(string));
            oprData.Columns.Add("oprGoal", typeof(string));
            oprData.Columns.Add("oprEneAmount", typeof(string));
            oprData.Columns.Add("oprCost", typeof(string));

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Operations");

            while (reader.Read())
            {
                oprDataList.Add(new Operation(
                    reader["oprID"].ToString(),
                    reader["oprName"].ToString(),
                    reader["eneAmmount"].ToString(),
                    reader["goals"].ToString(),
                    "./Resources/" + reader["mapPath"],
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

            dgv.Columns.Add(new DataGridViewImageColumn() { HeaderText = "关卡地图", DataPropertyName = "oprImage" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "编号", DataPropertyName = "oprID" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "名称", DataPropertyName = "oprName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "目标生命值", DataPropertyName = "oprGoal" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "敌人总数", DataPropertyName = "oprEneAmount" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "理智消耗", DataPropertyName = "oprCost" });

            dgv.Columns[0].Width = 150;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 170;
            dgv.Columns[3].Width = 140;
            dgv.Columns[4].Width = 140;
            dgv.Columns[5].Width = 130;

            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            dgv.AllowUserToAddRows = false;

            reloadData();
        }

        public void reloadData()
        {
            tb_search.Text = "";
            cb_searchItem.SelectedIndex = 0;
            count = 0;
            oprData.Rows.Clear();
            while (count < 5)
            {
                oprData.Rows.Add(oprDataList[count].oprMapPath,
                    oprDataList[count].oprID,
                    oprDataList[count].oprName,
                    oprDataList[count].goal,
                    oprDataList[count].eneAmount,
                    oprDataList[count].cost);
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 5}页";
        }

        public void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string imagePath = "";
                if (e.Value.ToString() == "./Resources/")
                    imagePath = "./WikiPages/暂无图片.png";
                else
                    imagePath = e.Value.ToString();
                try 
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream oldms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(oldms);
                        Bitmap bt = new Bitmap(img, new Size(186, 96));
                        using (MemoryStream newms = new MemoryStream())
                        {
                            bt.Save(newms, ImageFormat.Jpeg);
                            e.Value = newms.ToArray();
                        }
                    }
                }
                catch(Exception ee)
                {
                    imagePath = "./WikiPages/暂无图片.png";
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream oldms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(oldms);
                        Bitmap bt = new Bitmap(img, new Size(186, 96));
                        using (MemoryStream newms = new MemoryStream())
                        {
                            bt.Save(newms, ImageFormat.Jpeg);
                            e.Value = newms.ToArray();
                        }
                    }
                }
            }
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
                oprData.Rows.Add(oprDataList[count].oprMapPath,
                    oprDataList[count].oprID,
                    oprDataList[count].oprName,
                    oprDataList[count].goal,
                    oprDataList[count].eneAmount,
                    oprDataList[count].cost);
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
                oprData.Rows.Add(oprDataList[count].oprMapPath,
                    oprDataList[count].oprID,
                    oprDataList[count].oprName,
                    oprDataList[count].goal,
                    oprDataList[count].eneAmount,
                    oprDataList[count].cost);
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
                string oprID = table.Rows[e.RowIndex]["oprID"].ToString();
                operationMD("Operations", oprID);
            }
        }

        private void btn_searchOpr_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();

            string option = cb_searchItem.SelectedItem.ToString();
            switch (option)
            {
                case "关卡编号":
                    option = "oprID";
                    break;
                case "关卡名称":
                    option = "oprName";
                    break;
            }

            SqlDataReader reader = dbManager.SelectData("Operations", $"{option} like '%{tb_search.Text}%'");
            searchDataList.Clear();
            while (reader.Read())
            {
                searchDataList.Add(new Operation(
                    reader["oprID"].ToString(),
                    reader["oprName"].ToString(),
                    reader["eneAmmount"].ToString(),
                    reader["goals"].ToString(),
                    "./Resources/" + reader["mapPath"],
                    reader["cost"].ToString()));
            }
            dbManager.CloseDB();

            oprData.Clear();
            foreach (Operation o in searchDataList)
            {
                oprData.Rows.Add(o.oprMapPath, o.oprID, o.oprName, o.goal, o.eneAmount, o.cost);
            }

            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.DataSource = oprData;
            btn_next.Enabled = false;
            btn_pre.Enabled = false;
        }
    }
}
