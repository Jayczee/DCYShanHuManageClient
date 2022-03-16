﻿using System;
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
    public partial class AddStuForm : Form
    {
        StudentBll sbll = new();
        public AddStuForm()
        {
            InitializeComponent();
        }

        private void AddStuForm_Load(object sender, EventArgs e)
        {
            List<ClassInf> list = sbll.GetClassInfs();
            comboClass.Items.Clear();
            for (int i = 0; i < list.Count; i++)
                comboClass.Items.Add(list[i].CNo);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txtName.Text == "" && txtYear.Text == ""&& comboClass.Text == ""  && txtCard.Text == "" && txtSex.Text == "")
            //{
            //    MessageBox.Show("请填写学生信息！");
            //    return;
            //}
            Student s = new();
            s.SName = txtName.Text;
            s.SYear = txtYear.Text;
            s.SClassNo = comboClass.Text;
            s.SCardNum = txtCard.Text;
            s.SSex = txtSex.Text;
            s.SPhone = txtPhone.Text;
            if (s.SName==""|| s.SName ==null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (s.SYear ==""||s.SYear==null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (s.SClassNo==""||s.SClassNo==null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (s.SCardNum==""||s.SCardNum==null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (s.SSex == "" || s.SSex == null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (s.SPhone==""||s.SPhone==null)
            {
                MessageBox.Show("请填写学生信息！");
                return;
            }
            if (sbll.AddStudent(s))
            {
                MessageBox.Show("添加学生信息成功！");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("添加学生信息失败！");
            }
        }
    }
}
