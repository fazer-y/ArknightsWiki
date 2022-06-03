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
    public partial class MaterailForm : Form
    {
        public event GetMD matMD;
        DataTable oprData = new DataTable();
        DataGridView dgv = null;
        int count = 0;
        public int pageIndex = 1;
        List<Materail> oprDataList = new List<Materail>();
        List<Materail> searchDataList = new List<Materail>();
        public MaterailForm()
        {
            InitializeComponent();
            TopLevel = false;
            cb_searchItem.SelectedIndex = 0;
            cb_searchItem.DropDownStyle = ComboBoxStyle.DropDownList;

            dgv = new DataGridView();
            dgv.Parent = this.pnl_data;
            dgv.Dock = DockStyle.Fill;
            dgv.RowHeadersVisible = false;

            oprData.Columns.Add("matIcon", typeof(string));
            oprData.Columns.Add("matName", typeof(string));
            oprData.Columns.Add("matAccess", typeof(string));

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Material");

            while (reader.Read())
            {
                oprDataList.Add(new Materail(
                    reader["matName"].ToString(),
                    "./Resources/" + reader["matIcon"],
                    reader["matAccess"].ToString()));
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

            dgv.Columns.Add(new DataGridViewImageColumn() { HeaderText = "道具图标", DataPropertyName = "matIcon" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "道具名称", DataPropertyName = "matName" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "获取方式", DataPropertyName = "matAccess" });

            dgv.Columns[0].Width = 100;
            dgv.Columns[1].Width = 280;
            dgv.Columns[2].Width = 525;

            dgv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgv_CellFormatting);
            dgv.AllowUserToAddRows = false;
        }

        public void myForm_Shown(object sender, EventArgs e)
        {
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
                oprData.Rows.Add(oprDataList[count].matIcon,
                    oprDataList[count].matName,
                    oprDataList[count].matAccess);
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
                        Bitmap bt = new Bitmap(img, new Size(97, 97));
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
                oprData.Rows.Add(oprDataList[count].matIcon,
                    oprDataList[count].matName,
                    oprDataList[count].matAccess);
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
                oprData.Rows.Add(oprDataList[count].matIcon,
                    oprDataList[count].matName,
                    oprDataList[count].matAccess);
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
                string oprID = table.Rows[e.RowIndex]["matName"].ToString();
                matMD("Materail", oprID);
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
                case "获取方式":
                    option = "matAccess";
                    break;
            }

            SqlDataReader reader = dbManager.SelectData("Material", $"{option} like '%{tb_search.Text}%'");
            searchDataList.Clear();
            while (reader.Read())
            {
                searchDataList.Add(new Materail(
                    reader["matName"].ToString(),
                    "./Resources/" + reader["matIcon"],
                    reader["matAccess"].ToString()));
            }
            dbManager.CloseDB();

            oprData.Clear();
            foreach (Materail o in searchDataList)
            {
                oprData.Rows.Add(o.matIcon, o.matName, o.matAccess);
            }

            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.DataSource = oprData;
            btn_next.Enabled = false;
            btn_pre.Enabled = false;
        }
    }
}
