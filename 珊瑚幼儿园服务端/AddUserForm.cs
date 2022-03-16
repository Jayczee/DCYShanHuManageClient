using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace 珊瑚幼儿园服务端
{
    public partial class AddUserForm : Form
    {
        MainForm mf;
        public AddUserForm()
        {
            InitializeComponent();
        }
        public AddUserForm(MainForm mf)
        {
            InitializeComponent();
            this.mf = mf;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (userName.Text == "" || userName.Text == null && userPwd.Text == "" || userPwd.Text == null && userKind.Text == "" || userKind.Text == null)
            //{
            //    MessageBox.Show("请填写用户信息！");
            //    return;
            //}
            User user = new User();
            UserBll userBll = new UserBll();
            user.Uid = userName.Text;
            user.Upwd = userPwd.Text;
            user.UserKind = userKind.Text;
            if (user.Uid==""||user.Uid==null)
            {
                MessageBox.Show("请填写用户信息！");
                return;
            }
            if (user.Upwd==""||user.Upwd==null)
            {
                MessageBox.Show("请填写用户信息！");
                return;
            }
            if (user.UserKind==""||user.UserKind==null)
            {
                MessageBox.Show("请填写用户信息！");
                return;
            }
            if (userBll.AddUser(user))
            {
                MessageBox.Show("添加用户信息成功！");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("添加用户信息失败！");
            }
        }
    }
}
