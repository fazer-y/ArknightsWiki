using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    public delegate void submitRecord(string oprID, string matName, int amount);
    public partial class DropSubmit : Form
    {
        public event submitRecord sR;
        public DropSubmit()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            cb_chapter.SelectedIndex = 0;
        }

        private void btn_cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_chapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chapter = cb_chapter.SelectedIndex;
            
            cb_opr.Items.Clear();
            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Operations", $"oprID like '{chapter}-[1-9]%'");

            while (reader.Read())
            {
                cb_opr.Items.Add(reader["oprID"].ToString());
            }
            dbManager.CloseDB();
        }

        private void cb_opr_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opr = cb_opr.SelectedItem.ToString();
            cb_material.Items.Clear();

            DBManager dbManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
            dbManager.OpenDB();
            SqlDataReader reader = dbManager.SelectData("Drops", $"oprID='{opr}'");

            while (reader.Read())
            {
                cb_material.Items.Add(reader["matName"].ToString());
            }
            dbManager.CloseDB();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string oprID = cb_opr.SelectedItem.ToString();
            string matName = cb_material.SelectedItem.ToString();
            int amount = (int)NumBox.Value;
            sR(oprID, matName, amount);
            Close();
        }
    }
}
