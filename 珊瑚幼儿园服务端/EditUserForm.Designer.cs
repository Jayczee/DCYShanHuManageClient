namespace 珊瑚幼儿园服务端
{
    partial class EditUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UserKind = new System.Windows.Forms.TextBox();
            this.UserPwd = new System.Windows.Forms.TextBox();
            this.UserLastTime = new System.Windows.Forms.TextBox();
            this.UserLastIP = new System.Windows.Forms.TextBox();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "用  户 名：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户标识：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "用户最近登录时间：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "用户最近登录地址：";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(128, 50);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(200, 38);
            this.UserName.TabIndex = 5;
            // 
            // UserKind
            // 
            this.UserKind.Location = new System.Drawing.Point(128, 176);
            this.UserKind.Name = "UserKind";
            this.UserKind.Size = new System.Drawing.Size(200, 38);
            this.UserKind.TabIndex = 6;
            this.UserKind.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserPwd
            // 
            this.UserPwd.Location = new System.Drawing.Point(128, 113);
            this.UserPwd.Name = "UserPwd";
            this.UserPwd.Size = new System.Drawing.Size(200, 38);
            this.UserPwd.TabIndex = 7;
            // 
            // UserLastTime
            // 
            this.UserLastTime.Location = new System.Drawing.Point(570, 53);
            this.UserLastTime.Name = "UserLastTime";
            this.UserLastTime.Size = new System.Drawing.Size(200, 38);
            this.UserLastTime.TabIndex = 8;
            // 
            // UserLastIP
            // 
            this.UserLastIP.Location = new System.Drawing.Point(570, 180);
            this.UserLastIP.Name = "UserLastIP";
            this.UserLastIP.Size = new System.Drawing.Size(200, 38);
            this.UserLastIP.TabIndex = 9;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(284, 312);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(212, 65);
            this.btnEditUser.TabIndex = 10;
            this.btnEditUser.Text = "编辑用户信息";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.UserLastIP);
            this.Controls.Add(this.UserLastTime);
            this.Controls.Add(this.UserPwd);
            this.Controls.Add(this.UserKind);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditUserForm";
            this.Text = "用户信息编辑";
            this.Load += new System.EventHandler(this.EditUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox UserName;
        private TextBox UserKind;
        private TextBox UserPwd;
        private TextBox UserLastTime;
        private TextBox UserLastIP;
        private Button btnEditUser;
    }
}