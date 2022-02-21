using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 珊瑚幼儿园服务端
{
    public partial class StuSearchForm : Form
    {
        MainForm mf;
        public StuSearchForm()
        {
            InitializeComponent();
        }

        public StuSearchForm(MainForm mf)
        {
            InitializeComponent();
            this.mf=mf;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text==null || comboBox1.Text == "")
            {
                MessageBox.Show("请选择搜索条件！");
                return;
            }
            if (comboBox2.Text == null || comboBox2.Text == "")
            {
                MessageBox.Show("请输入具体搜索值！");
                return;
            }
            string key = comboBox1.Text;
            string value = comboBox2.Text;
            mf.SearchStu(key, value);
            this.Close();
            this.Dispose();
        }
    }
}
