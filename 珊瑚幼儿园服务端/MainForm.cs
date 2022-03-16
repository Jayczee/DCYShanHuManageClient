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
using Model;

namespace 珊瑚幼儿园服务端
{
    public partial class MainForm : Form
    {

        UserBll ubll = new();
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
            //dataGridView1.Columns.RemoveAt(0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;//行高自动调整
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//列宽自动调整
        }

        private void btnSearchStu_Click(object sender, EventArgs e)
        {
            StuSearchForm ssf = new(this);
            ssf.StartPosition = FormStartPosition.CenterScreen;
            ssf.Show();
        }

        public void SearchStu(string key, string value)
        {
            DataTable dt = sbll.SearchStu(key, value);
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("未查询到信息！");
                return;
            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns.RemoveAt(0);
        }

        private void btnUpStu_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count >= 5 && dataGridView1.Columns.Count < 10)
            {
                MessageBox.Show("请选中要编辑的学生信息");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要编辑的学生信息");
                return;
            }
            else
            {
                int index = this.dataGridView1.CurrentRow.Index;
                Student s = new();
                s.SName = dataGridView1.Rows[index].Cells["SName"].Value.ToString();
                s.SClassNo = dataGridView1.Rows[index].Cells["SClassNo"].Value.ToString();
                s.SYear = dataGridView1.Rows[index].Cells["SYear"].Value.ToString();
                s.SSex = dataGridView1.Rows[index].Cells["SSex"].Value.ToString();
                s.STotalPoints = dataGridView1.Rows[index].Cells["STotalPoints"].Value.ToString();
                s.SPoints = dataGridView1.Rows[index].Cells["SPoints"].Value.ToString();
                s.SPhone = dataGridView1.Rows[index].Cells["SPhone"].Value.ToString();
                s.SCardNum = dataGridView1.Rows[index].Cells["SCardNum"].Value.ToString();
                EditStuForm edf = new EditStuForm(s);
                edf.Show();
            }
        }

        private void btnAllStus_Click(object sender, EventArgs e)
        {
            ExcelAddStuForm easf = new();
            easf.Show();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new(this);
            addUserForm.StartPosition = FormStartPosition.CenterScreen;
            addUserForm.Show();
        }

        private void btnUpUser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count >= 5 && dataGridView1.Columns.Count < 10)
            {
                int index = this.dataGridView1.CurrentRow.Index;
                User user = new User();
                user.Id = dataGridView1.Rows[index].Cells["id"].Value.ToString();
                user.Uid = dataGridView1.Rows[index].Cells["Uid"].Value.ToString();
                user.Upwd = dataGridView1.Rows[index].Cells["Pwd"].Value.ToString();
                user.UserKind = dataGridView1.Rows[index].Cells["UserKind"].Value.ToString();
                user.LastLoginTime = dataGridView1.Rows[index].Cells["LastLoginTime"].Value.ToString();
                user.LastLoginIP = dataGridView1.Rows[index].Cells["LastLoginIP"].Value.ToString();
                EditUserForm editUserForm = new EditUserForm(user);
                editUserForm.StartPosition = FormStartPosition.CenterScreen;
                editUserForm.Show();
            }
            if (dataGridView1.Columns.Count == 10)
            {
                MessageBox.Show("请选中要编辑的用户信息");
                return;
            }
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选中要编辑的用户信息");
                return;
            }
        }

        private void btnAddStu_Click(object sender, EventArgs e)
        {
            AddStuForm addStuForm = new AddStuForm();
            addStuForm.StartPosition = FormStartPosition.CenterScreen;
            addStuForm.Show();

        }
    }
}
