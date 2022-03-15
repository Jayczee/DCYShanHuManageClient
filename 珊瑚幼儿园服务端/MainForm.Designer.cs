namespace 珊瑚幼儿园服务端
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAllStus = new System.Windows.Forms.Button();
            this.btnUpStu = new System.Windows.Forms.Button();
            this.btnAddStu = new System.Windows.Forms.Button();
            this.btnAllUser = new System.Windows.Forms.Button();
            this.btnSearchStu = new System.Windows.Forms.Button();
            this.btnAllStu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2082, 1007);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUpUser);
            this.tabPage1.Controls.Add(this.btnAddUser);
            this.tabPage1.Controls.Add(this.btnAllStus);
            this.tabPage1.Controls.Add(this.btnUpStu);
            this.tabPage1.Controls.Add(this.btnAddStu);
            this.tabPage1.Controls.Add(this.btnAllUser);
            this.tabPage1.Controls.Add(this.btnSearchStu);
            this.tabPage1.Controls.Add(this.btnAllStu);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(8, 45);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage1.Size = new System.Drawing.Size(2066, 954);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnUpUser
            // 
            this.btnUpUser.Location = new System.Drawing.Point(1706, 36);
            this.btnUpUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpUser.Name = "btnUpUser";
            this.btnUpUser.Size = new System.Drawing.Size(230, 64);
            this.btnUpUser.TabIndex = 8;
            this.btnUpUser.Text = "编辑用户信息";
            this.btnUpUser.UseVisualStyleBackColor = true;
            this.btnUpUser.Click += new System.EventHandler(this.btnUpUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(1464, 36);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(230, 64);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "添加用户信息";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAllStus
            // 
            this.btnAllStus.Location = new System.Drawing.Point(1222, 36);
            this.btnAllStus.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAllStus.Name = "btnAllStus";
            this.btnAllStus.Size = new System.Drawing.Size(230, 64);
            this.btnAllStus.TabIndex = 6;
            this.btnAllStus.Text = "EXCEL批量导入";
            this.btnAllStus.UseVisualStyleBackColor = true;
            this.btnAllStus.Click += new System.EventHandler(this.btnAllStus_Click);
            // 
            // btnUpStu
            // 
            this.btnUpStu.Location = new System.Drawing.Point(980, 36);
            this.btnUpStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnUpStu.Name = "btnUpStu";
            this.btnUpStu.Size = new System.Drawing.Size(230, 64);
            this.btnUpStu.TabIndex = 5;
            this.btnUpStu.Text = "编辑学生信息";
            this.btnUpStu.UseVisualStyleBackColor = true;
            this.btnUpStu.Click += new System.EventHandler(this.btnUpStu_Click);
            // 
            // btnAddStu
            // 
            this.btnAddStu.Location = new System.Drawing.Point(738, 36);
            this.btnAddStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAddStu.Name = "btnAddStu";
            this.btnAddStu.Size = new System.Drawing.Size(230, 64);
            this.btnAddStu.TabIndex = 4;
            this.btnAddStu.Text = "添加学生信息";
            this.btnAddStu.UseVisualStyleBackColor = true;
            this.btnAddStu.Click += new System.EventHandler(this.btnAddStu_Click);
            // 
            // btnAllUser
            // 
            this.btnAllUser.Location = new System.Drawing.Point(254, 36);
            this.btnAllUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(230, 64);
            this.btnAllUser.TabIndex = 3;
            this.btnAllUser.Text = "全部用户信息";
            this.btnAllUser.UseVisualStyleBackColor = true;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // btnSearchStu
            // 
            this.btnSearchStu.Location = new System.Drawing.Point(496, 36);
            this.btnSearchStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSearchStu.Name = "btnSearchStu";
            this.btnSearchStu.Size = new System.Drawing.Size(230, 64);
            this.btnSearchStu.TabIndex = 2;
            this.btnSearchStu.Text = "条件检索学生";
            this.btnSearchStu.UseVisualStyleBackColor = true;
            this.btnSearchStu.Click += new System.EventHandler(this.btnSearchStu_Click);
            // 
            // btnAllStu
            // 
            this.btnAllStu.Location = new System.Drawing.Point(12, 36);
            this.btnAllStu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAllStu.Name = "btnAllStu";
            this.btnAllStu.Size = new System.Drawing.Size(230, 64);
            this.btnAllStu.TabIndex = 1;
            this.btnAllStu.Text = "全部学生信息";
            this.btnAllStu.UseVisualStyleBackColor = true;
            this.btnAllStu.Click += new System.EventHandler(this.btnAllStu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1618, 828);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2080, 1010);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "珊瑚幼儿园校园平台管理服务端";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private Button btnAllStu;
        private Button btnSearchStu;
        private Button btnAllUser;
        private Button btnAllStus;
        private Button btnUpStu;
        private Button btnAddStu;
        private Button btnUpUser;
        private Button btnAddUser;
    }
}