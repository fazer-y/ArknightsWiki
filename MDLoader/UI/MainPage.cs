using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArknightsWiki.UI
{
    public partial class MainPage : Form
    {
        MainFrame mainFrame;
        public MainPage(MainFrame owner)
        {
            mainFrame = owner;
            InitializeComponent();
            TopLevel = false;
        }

        private void btn_operator_Click(object sender, EventArgs e)
        {
            mainFrame.btn_operator_Click(sender, e);
        }

        private void btn_enemies_Click(object sender, EventArgs e)
        {
            mainFrame.btn_enemies_Click(sender, e);
        }

        private void btn_operation_Click(object sender, EventArgs e)
        {
            mainFrame.btn_operation_Click(sender, e);
        }

        private void btn_materail_Click(object sender, EventArgs e)
        {
            mainFrame.btn_materail_Click(sender, e);
        }

        private void btn_recruit_Click(object sender, EventArgs e)
        {
            mainFrame.btn_recruit_Click(sender, e);
        }
    }
}
