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
    public partial class EditUserForm : Form
    {
        User user = new User();
        UserBll UserBll = new UserBll();
        public EditUserForm()
        {
            InitializeComponent();
        }
        public EditUserForm(User user)
        {
            InitializeComponent();
            this.user = user;
            UserName.Text = user.Uid;
            UserPwd.Text = user.Upwd;
            UserKind.Text = user.UserKind;
            UserLastTime.Text = user.LastLoginTime;
            UserLastIP.Text = user.LastLoginIP;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            user.Uid = UserName.Text;
            user.Upwd = UserPwd.Text;
            user.UserKind = UserKind.Text;
            if (UserBll.EditUser(user))
            {
                MessageBox.Show("编辑用户信息成功！");
                this.Close();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("编辑用户信息失败！");
            }
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
