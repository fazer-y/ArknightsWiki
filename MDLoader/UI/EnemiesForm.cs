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
    public partial class EnemiesForm : Form
    {
        public event GetMD eneMD;
        DataTable oprData = new DataTable();
        DataGridView dgv = null;
        int count = 0;
        public int pageIndex = 1;
        List<Enemies> oprDataList = new List<Enemies>();
        List<Enemies> searchDataList = new List<Enemies>();
        public EnemiesForm()
        {
            InitializeComponent();
            TopLevel = false;
            cb_searchItem.SelectedIndex = 0;
            cb_searchItem.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv = new DataGridView();
            dgv.Parent = this.pnl_data;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;

            oprData.Columns.Add("eneIcon", typeof(string));
            oprData.Columns.Add("eneName", typeof(string));
            oprData.Columns.Add("eneAttack", typeof(string));
            oprData.Columns.Add("eneATK", typeof(string));
            oprData.Columns.Add("eneHP", typeof(string));
            oprData.Columns.Add("eneDEF", typeof(string));
            oprData.Columns.Add("eneSR", typeof(string));
            oprData.Columns.Add("eneFeature", typeof(string));

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Enemies");

            while (reader.Read())
            {
                oprDataList.Add(new Enemies(
                    reader["eneName"].ToString(),
                    "./Resources/" + reader["eneIcon"],
                    reader["eneAttack"].ToString(),
                    reader["eneAttributes"].ToString(),
                    reader["eneFeature"].ToString()));
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

            dgv.Columns.Add(new DataGridViewImageColumn() { HeaderText = "敌人图像", DataPropertyName = "eneIcon" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "敌人名称", DataPropertyName = "eneName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "攻击方式", DataPropertyName = "eneAttack" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "ATK", DataPropertyName = "eneATK" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "HP", DataPropertyName = "eneHP" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "DEF", DataPropertyName = "eneDEF" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "SR", DataPropertyName = "eneSR" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "特性", DataPropertyName = "eneFeature" });

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 180;
            dgv.Columns[2].Width = 140;
            dgv.Columns[3].Width = 50;
            dgv.Columns[4].Width = 50;
            dgv.Columns[5].Width = 50;
            dgv.Columns[6].Width = 50;
            dgv.Columns[7].Width = 285;

            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            dgv.AllowUserToAddRows = false;
            reloadData();
        }

        public void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string imagePath = "";
                if (e.Value.ToString() == "./Resources/")
                    imagePath = "./WikiPages/暂无道具图片.png";
                else
                    imagePath = e.Value.ToString();
                try
                {
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream oldms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(oldms);
                        Bitmap bt = new Bitmap(img, new Size(97, 97));
                        using (MemoryStream newms = new MemoryStream())
                        {
                            bt.Save(newms, ImageFormat.Jpeg);
                            e.Value = newms.ToArray();
                        }
                    }
                }
                catch (Exception ee)
                {
                    imagePath = "./WikiPages/暂无道具图片.png";
                    byte[] bytes = File.ReadAllBytes(imagePath);
                    using (MemoryStream oldms = new MemoryStream(bytes))
                    {
                        Image img = Image.FromStream(oldms);
                        Bitmap bt = new Bitmap(img, new Size(97,97));
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
                oprData.Rows.Add(oprDataList[count].eneIcon,
                    oprDataList[count].eneName,
                    oprDataList[count].eneAttack,
                    oprDataList[count].eneAttributes[0],
                    oprDataList[count].eneAttributes[1],
                    oprDataList[count].eneAttributes[2],
                    oprDataList[count].eneAttributes[3],
                    oprDataList[count].eneFeature);
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
                oprData.Rows.Add(oprDataList[count].eneIcon,
                    oprDataList[count].eneName,
                    oprDataList[count].eneAttack,
                    oprDataList[count].eneAttributes[0],
                    oprDataList[count].eneAttributes[1],
                    oprDataList[count].eneAttributes[2],
                    oprDataList[count].eneAttributes[3],
                    oprDataList[count].eneFeature);
                count++;
            }
            dgv.DataSource = oprData;
            lbl_pageIndex.Text = $"第{count / 5}页";
        }

        public void reloadData()
        {
            tb_search.Text = "";
            cb_searchItem.SelectedIndex = 0;
            count = 0;
            oprData.Rows.Clear();
            while (count < 5)
            {
                oprData.Rows.Add(oprDataList[count].eneIcon,
                    oprDataList[count].eneName,
                    oprDataList[count].eneAttack,
                    oprDataList[count].eneAttributes[0],
                    oprDataList[count].eneAttributes[1],
                    oprDataList[count].eneAttributes[2],
                    oprDataList[count].eneAttributes[3],
                    oprDataList[count].eneFeature);
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
                string oprID = table.Rows[e.RowIndex]["eneName"].ToString();
                eneMD("Enemies", oprID);
            }
        }

        private void btn_searchOpr_Click(object sender, EventArgs e)
        {
            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();

            string option = cb_searchItem.SelectedItem.ToString();
            switch (option)
            {
                case "敌人名称":
                    option = "eneName";
                    break;
                case "敌人特性":
                    option = "eneFeature";
                    break;
                case "攻击方式":
                    option = "eneFeature";
                    break;
                default:
                    option = "eneAttributes";
                    break;
            }

            SqlDataReader reader = dbManager.SelectData("Enemies", $"{option} like '%{tb_search.Text}%'");
            searchDataList.Clear();
            while (reader.Read())
            {
                searchDataList.Add(new Enemies(
                    reader["eneName"].ToString(),
                    "./Resources/" + reader["eneIcon"],
                    reader["eneAttack"].ToString(),
                    reader["eneAttributes"].ToString(),
                    reader["eneFeature"].ToString()));
            }
            dbManager.CloseDB();

            oprData.Clear();
            foreach (Enemies o in searchDataList)
            {
                oprData.Rows.Add(o.eneIcon, o.eneName, o.eneAttack, o.eneAttributes[0], o.eneAttributes[1], o.eneAttributes[2], o.eneAttributes[3], o.eneFeature);
            }

            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.DataSource = oprData;
            btn_next.Enabled = false;
            btn_pre.Enabled = false;
        }
    }
}
