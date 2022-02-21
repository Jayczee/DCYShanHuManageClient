using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace 珊瑚幼儿园服务端
{
    public partial class MainForm : Form
    {
        UserBll ubll=new();
        StudentBll sbll = new();
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void btnAllStu_Click(object sender, EventArgs e)
        {
            DataTable dt = sbll.GetAllStudent();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            DataTable dt = ubll.GetAllUser();
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//行高自动调整
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//列宽自动调整
        }
    }
}
