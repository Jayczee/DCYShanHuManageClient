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
    public partial class LoginForm : Form
    {
        UserBll ubll = new();
        int logintime=0;//短时间内登录次数
        int logininterval = 15;//登录时间间隔
        int userkind = -1;
        public LoginForm()
        {
            InitializeComponent();
            timer1.Interval = logininterval * 1000;
            timer1.Enabled = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (logintime > 5)
            {
                MessageBox.Show("登录过于频繁，请" + logininterval + "秒后再试！");
                return;
            }
            if (rBtnAdmin.Checked)
                userkind = 0;
            if (rBtnTeacher.Checked)
                userkind = 1;
            if (userkind == -1)
            {
                MessageBox.Show("请选择用户类型");
                return;
            }
            if (ubll.UserLogin(txtUid.Text.Trim(), txtPwd.Text,userkind))
            {
                MessageBox.Show("登陆成功！");
                this.DialogResult = DialogResult.OK;
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("用户名密码错误或用户类型错误！");
                logintime++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            logintime--;
        }

    }
}
