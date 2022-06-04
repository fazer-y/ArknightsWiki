using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArknightsWiki.Arknights;

namespace ArknightsWiki.UI
{
    public partial class RecruitForm : Form
    {
        List<Operator> oprList = new List<Operator>();
        DBManager dBManager = new DBManager("127.0.0.1", "ArkWiki", "fazer", "zxc123456..");
        DataTable oprData = new DataTable();
        public RecruitForm()
        {
            InitializeComponent();
            TopLevel = false;

            foreach (Control c in gb_job.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckStateChanged += new EventHandler(myCheckChange);
                }
            }
            foreach (Control c in gb_position.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckStateChanged += new EventHandler(myCheckChange);
                }
            }
            foreach (Control c in gb_tags.Controls)
            {
                if (c is CheckBox)
                {
                    ((CheckBox)c).CheckStateChanged += new EventHandler(myCheckChange);
                }
            }

            dBManager.OpenDB();
            SqlDataReader reader = dBManager.SelectData("Operators");

            while (reader.Read())
            {
                oprList.Add(new Operator(
                    reader["oprName"].ToString(),
                    reader["oprRace"].ToString(),
                    reader["oprTags"].ToString(),
                    reader["oprSkills"].ToString(),
                    "./Resources/" + reader["oprImagePath"]));
            }
            dBManager.CloseDB();

            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ScrollBars = ScrollBars.Vertical;
            dgv.ReadOnly = true;
            dgv.ColumnHeadersHeight = 35;
            dgv.AllowUserToAddRows = false;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 12);
            dgv.DoubleBufferedDataGirdView(true);


            dgv.RowsDefaultCellStyle.WrapMode= DataGridViewTriState.True;

            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "Tags", DataPropertyName = "tags" });
            dgv.Columns.Add(new DataGridViewTextBoxColumn() { HeaderText = "可能出现干员", DataPropertyName = "oprs" });

            dgv.Columns[0].Width = 280;
            dgv.Columns[1].Width = 550;

            oprData.Columns.Add("tags", typeof(string));
            oprData.Columns.Add("oprs", typeof(string));
        }

        public void myCheckChange(object sender, EventArgs e)
        {
            reloadResult();
        }

        public void reloadResult()
        {
            oprData.Rows.Clear();

            List<string> jobList = new List<string>();
            List<string> positionList = new List<string>();
            List<string> tagList = new List<string>();

            // 获取被选中项,添加单tag项
            foreach (CheckBox jobCB in gb_job.Controls)
            {
                if (jobCB.Checked)
                {
                    jobList.Add(jobCB.Text);
                }
            }

            foreach (CheckBox posiCB in gb_position.Controls)
            {
                if (posiCB.Checked)
                {
                    positionList.Add(posiCB.Text);
                } 
            }
                
            foreach (CheckBox tagCB in gb_tags.Controls)
            {
                if (tagCB.Checked)
                {
                    tagList.Add(tagCB.Text);
                }
            }

            // job&position&tags
            if (jobList.Count > 0 && tagList.Count > 0 && positionList.Count > 0)
            {
                foreach (string job in jobList)
                {
                    foreach (string p in positionList)
                    {
                        for (int i = 1; i <= tagList.Count; i++)
                        {
                            List<List<string>> tagsComList1 = Combination<string>.GetCombination(tagList, i);
                            foreach (List<string> tc in tagsComList1)
                            {
                                tc.Add(p);
                                tc.Add(job);
                                string result = getOprList(tc);
                                if (result != "")
                                    oprData.Rows.Add(string.Join(", ", tc), result);
                            }
                        }
                    }
                }
            }

            // tags内部组合
            for (int i = 2; i <= tagList.Count; i++)
            {
                List<List<string>> tagsComList1 = Combination<string>.GetCombination(tagList, i);
                foreach (List<string> tc in tagsComList1)
                {
                    string result = getOprList(tc);
                    if (result != "")
                    {
                        oprData.Rows.Add(string.Join(", ", tc), result);
                    }
                }
            }

            // job&tag
            if (jobList.Count > 0 && tagList.Count > 0)
            {
                foreach (string job in jobList)
                {
                    for (int i = 1; i <= tagList.Count; i++)
                    {
                        List<List<string>> tagsComList1 = Combination<string>.GetCombination(tagList, i);
                        foreach (List<string> tc in tagsComList1)
                        {
                            tc.Add(job);
                            string result = getOprList(tc);
                            if (result != "")
                            {
                                oprData.Rows.Add(string.Join(", ", tc), result);
                            }
                        }
                    }
                }
            }

            // position&tag
            if (positionList.Count > 0 && tagList.Count > 0)
            {
                foreach (string p in positionList)
                {
                    for (int i = 1; i <= tagList.Count; i++)
                    {
                        List<List<string>> tagsComList1 = Combination<string>.GetCombination(tagList, i);
                        foreach (List<string> tc in tagsComList1)
                        {
                            tc.Add(p);
                            string result = getOprList(tc);
                            if (result != "")
                            {
                                oprData.Rows.Add(string.Join(", ", tc), result);
                            }
                        }
                    }
                }
            }

            // job&position
            if (jobList.Count > 0 && positionList.Count > 0)
            {
                foreach (string job in jobList)
                {
                    foreach (string p in positionList)
                    {
                        string result = getOprList(new List<string> { job, p });
                        if (result != "")
                        {
                            oprData.Rows.Add(job + ", " + p, result);
                        }
                    }
                }
            }



            if (jobList.Count > 0)
            {
                foreach (string s in jobList)
                {
                    oprData.Rows.Add(s, getOprList(new List<string> { s }));
                }
            }

            if (positionList.Count > 0)
            {
                foreach (string s in positionList)
                {
                    oprData.Rows.Add(s, getOprList(new List<string> { s }));
                }
            }

            if (tagList.Count > 0)
            {
                foreach (string s in tagList)
                {
                    oprData.Rows.Add(s, getOprList(new List<string> { s }));
                }
            }


            dgv.DataSource = oprData;
        }

        public string getOprList(List<string> tagArray)
        {
            string result = "";
            bool flag = true;
            foreach (Operator o in oprList)
            {
                flag = true;
                foreach (string s in tagArray)
                {
                    if(s==null)
                        break;
                    else if (!o.oprTags.Contains(s))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    result +=  o.oprName + ", ";
                }
            }
            if(result != "")
            {
                result = result.Substring(0, result.LastIndexOf(","));
            }
            return result;
        }

        private void btn_全选1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_job.Controls)
            {
                C.Checked = true;
            }
        }

        private void btn_取消1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_job.Controls)
            {
                C.Checked = false;
            }
        }

        private void btn_全选2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_position.Controls)
            {
                C.Checked = true;
            }
        }

        private void btn_取消2_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_position.Controls)
            {
                C.Checked = false;
            }
        }

        private void btn_全选3_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_tags.Controls)
            {
                C.Checked = true;
            }
        }

        private void btn_取消3_Click(object sender, EventArgs e)
        {
            foreach (CheckBox C in gb_tags.Controls)
            {
                C.Checked = false;
            }
        }
    }

    // 实现排列组合
    public class Combination<T>
    {
        /// <summary>
        /// 递归算法求数组的组合(私有成员)
        /// </summary>
        /// <param name="list">返回的范型</param>
        /// <param name="t">所求数组</param>
        /// <param name="n">辅助变量</param>
        /// <param name="m">辅助变量</param>
        /// <param name="b">辅助数组</param>
        /// <param name="M">辅助变量M</param>
        private static void GetCombination(ref List<List<T>> list, List<T> t, int n, int m, int[] b, int M)
        {
            for (int i = n; i >= m; i--)
            {
                b[m - 1] = i - 1;
                if (m > 1)
                {
                    GetCombination(ref list, t, i - 1, m - 1, b, M);
                }
                else
                {
                    if (list == null)
                    {
                        list = new List<List<T>>();
                    }
                    List<T> temp = new List<T>();
                    for (int j = 0; j < b.Length; j++)
                    {
                        temp.Add(t[b[j]]);
                    }
                    list.Add(temp);
                }
            }
        }
        /// <summary>
        /// 求数组中n个元素的组合
        /// </summary>
        /// <param name="t">所求数组</param>
        /// <param name="n">元素个数</param>
        /// <returns>数组中n个元素的组合的范型</returns>
        public static List<List<T>> GetCombination(List<T> t, int n)
        {
            if (t.Count < n)
            {
                return null;
            }
            int[] temp = new int[n];
            List<List<T>> list = new List<List<T>>();
            GetCombination(ref list, t, t.Count, n, temp, n);
            return list.ToList();
        }
    }

    public static class DoubleBufferDataGridView
    {
        /// <summary>
        /// 双缓冲，解决闪烁问题
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="flag"></param>
        public static void DoubleBufferedDataGirdView(this DataGridView dgv, bool flag)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, flag, null);
        }
    }

    public static class DoubleBufferListView
    {
        /// <summary>
        /// 双缓冲，解决闪烁问题
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="flag"></param>
        public static void DoubleBufferedListView(this ListView lv, bool flag)
        {
            Type lvType = lv.GetType();
            PropertyInfo pi = lvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(lv, flag, null);
        }

    }
}
