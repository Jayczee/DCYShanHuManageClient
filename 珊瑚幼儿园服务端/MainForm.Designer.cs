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
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAllUser);
            this.tabPage1.Controls.Add(this.btnSearchStu);
            this.tabPage1.Controls.Add(this.btnAllStu);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "人员信息管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAllUser
            // 
            this.btnAllUser.Location = new System.Drawing.Point(127, 20);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(115, 35);
            this.btnAllUser.TabIndex = 3;
            this.btnAllUser.Text = "全部用户信息";
            this.btnAllUser.UseVisualStyleBackColor = true;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // btnSearchStu
            // 
            this.btnSearchStu.Location = new System.Drawing.Point(248, 20);
            this.btnSearchStu.Name = "btnSearchStu";
            this.btnSearchStu.Size = new System.Drawing.Size(115, 35);
            this.btnSearchStu.TabIndex = 2;
            this.btnSearchStu.Text = "条件检索学生";
            this.btnSearchStu.UseVisualStyleBackColor = true;
            this.btnSearchStu.Click += new System.EventHandler(this.btnSearchStu_Click);
            // 
            // btnAllStu
            // 
            this.btnAllStu.Location = new System.Drawing.Point(6, 20);
            this.btnAllStu.Name = "btnAllStu";
            this.btnAllStu.Size = new System.Drawing.Size(115, 35);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(809, 454);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 554);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
    }
}