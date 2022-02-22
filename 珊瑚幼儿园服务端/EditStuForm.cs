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
    public partial class EditStuForm : Form
    {
        Student s = new();
        StudentBll sbll = new();
        public EditStuForm()
        {
            InitializeComponent();
        }

        public EditStuForm(Student s)
        {
            InitializeComponent();
            this.s = s;
            txtCardNum.Text = s.SCardNum;
            txtClass.Text = s.SClassNo;
            txtName.Text= s.SName;
            txtPhone.Text= s.SPhone;
            txtPoints.Text = s.SPoints;
            txtSex.Text = s.SSex;
            txtTotalPoints.Text = s.STotalPoints;
            txtYear.Text = s.SYear;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            s.SCardNum=txtCardNum.Text;
            s.SClassNo=txtClass.Text;
            s.SName=txtName.Text;
            s.SPhone=txtPhone.Text;
            s.SPoints=txtPoints.Text;
            s.SSex=txtSex.Text;
            s.STotalPoints=txtTotalPoints.Text;
            s.SYear=txtYear.Text;
            if (sbll.EditStudent(s))
            {
                MessageBox.Show("编辑学生信息成功！");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("编辑学生信息失败！");
            }
        }
    }
}
