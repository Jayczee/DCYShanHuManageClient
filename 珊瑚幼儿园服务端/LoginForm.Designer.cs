namespace 珊瑚幼儿园服务端
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnTeacher = new System.Windows.Forms.RadioButton();
            this.rBtnAdmin = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(79, 13);
            this.txtUid.Name = "txtUid";
            this.txtUid.Size = new System.Drawing.Size(172, 23);
            this.txtUid.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(79, 52);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(172, 23);
            this.txtPwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "密   码：";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(79, 166);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnTeacher);
            this.groupBox1.Controls.Add(this.rBtnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(17, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 64);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户类型";
            // 
            // rBtnTeacher
            // 
            this.rBtnTeacher.AutoSize = true;
            this.rBtnTeacher.Location = new System.Drawing.Point(159, 29);
            this.rBtnTeacher.Name = "rBtnTeacher";
            this.rBtnTeacher.Size = new System.Drawing.Size(50, 21);
            this.rBtnTeacher.TabIndex = 1;
            this.rBtnTeacher.TabStop = true;
            this.rBtnTeacher.Text = "教师";
            this.rBtnTeacher.UseVisualStyleBackColor = true;
            // 
            // rBtnAdmin
            // 
            this.rBtnAdmin.AutoSize = true;
            this.rBtnAdmin.Location = new System.Drawing.Point(18, 29);
            this.rBtnAdmin.Name = "rBtnAdmin";
            this.rBtnAdmin.Size = new System.Drawing.Size(62, 21);
            this.rBtnAdmin.TabIndex = 0;
            this.rBtnAdmin.TabStop = true;
            this.rBtnAdmin.Text = "管理员";
            this.rBtnAdmin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 200);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "珊瑚幼儿园管理服务端登录";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtUid;
        private TextBox txtPwd;
        private Label label2;
        private Button btnLogin;
        private System.Windows.Forms.Timer timer1;
        private GroupBox groupBox1;
        private RadioButton rBtnTeacher;
        private RadioButton rBtnAdmin;
    }
}