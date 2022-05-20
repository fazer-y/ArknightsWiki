using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    public partial class MainFrame : Form
    {
        private EditorForm editorform;
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            editorform = new EditorForm();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnl_main.Controls.Clear();
            pnl_main.Controls.Add(editorform);
            SendKeys.Send("{F10}");
            editorform.Show();
        }
    }
}
