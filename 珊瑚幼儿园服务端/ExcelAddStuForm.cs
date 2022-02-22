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
    public partial class ExcelAddStuForm : Form
    {
        StudentBll sbll = new();
        string file = "";
        DataTable dtstu;
        public ExcelAddStuForm()
        {
            InitializeComponent();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("【使用说明】\n1.首先先点击导出学生信息标准模板到指定位置\n2.打开学生信息标准模板EXCEL文件，填入学生信息\n3.点击导入表格按钮将填写好信息的学生模板导入程序\n4.点击添加学生信息，等待完成");
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowDialog();
            string path=folderDlg.SelectedPath;
            CreateExcel(path);
        }

        public void CreateExcel(string destDir)
        {
            if (Directory.Exists(destDir))
            {
                if(File.Exists(destDir + "\\标准学生信息模板.xls"))
                {
                    MessageBox.Show("文件已存在！");
                    return;
                }
                File.Copy(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase+"mb.data", destDir + "\\标准学生信息模板.xls");
                MessageBox.Show("导出成功，模板存放在" + destDir + "\\标准学生信息模板.xls");
            }
            else
            {
                MessageBox.Show("路径不存在！");
            }
        }

        private void btnGetExcel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog opdialog = new System.Windows.Forms.OpenFileDialog();
            opdialog.Multiselect = false;
            opdialog.Filter = "Excel文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            if (opdialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.Stream stream = null;
                try
                {
                    if ((stream = opdialog.OpenFile()) != null)
                    {
                        file = opdialog.FileNames[0];
                        stream.Dispose();
                        listInf.Items.Add(DateTime.Now.ToString("T") + " 获取文件成功！路径为" + file);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("表格文件已被占用！或驱动未安装");
                }
            }
            else
                return;
            listInf.Items.Add(DateTime.Now.ToString("T") + " 正在将表格转化为数据...");
            DataTable dt = sbll.GetStuInfFromExcel(file);
            if (dt.Rows.Count < 1)
            {
                listInf.Items.Add(DateTime.Now.ToString("T")+" 表格数据行数不足（小于1行），转化失败");
                btnAdd.Enabled = false;
                return;
            }else if(dt.Rows[1][0].ToString()=="李四" && dt.Rows[1][1].ToString() == "101")
            {
                listInf.Items.Add(DateTime.Now.ToString("T") + " 信息表内第二行默认数据（李四）仍然存在，请用新数据手动清除并用新学生数据填入该行");
                btnAdd.Enabled = false;
                return;
            }
            listInf.Items.Add(DateTime.Now.ToString("T") + " 表格数据导入成功，等待开始添加");
            MessageBox.Show("表格数据导入成功，等待开始添加!共" + (dt.Rows.Count) + "个学生数据");
            btnAdd.Enabled = true;
            dtstu = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int total = 0;int success = 0;
            listInf.Items.Add("[0]开始添加学生信息！");
            for (int i = 0; i < dtstu.Rows.Count; i++)
            {
                total++;
                Student s = new();
                if (dtstu.Rows[i][0] != null) s.SName = dtstu.Rows[i][0].ToString();
                if (dtstu.Rows[i][1] != null) s.SClassNo = dtstu.Rows[i][1].ToString();
                if (dtstu.Rows[i][2] != null) s.SYear = dtstu.Rows[i][2].ToString();
                if (dtstu.Rows[i][3] != null) s.SPoints = dtstu.Rows[i][3].ToString();
                if (dtstu.Rows[i][4] != null) s.SPhone = dtstu.Rows[i][4].ToString();
                if (dtstu.Rows[i][5] != null) s.SCardNum = dtstu.Rows[i][5].ToString();
                if (dtstu.Rows[i][6] != null) s.STotalPoints = dtstu.Rows[i][6].ToString();
                if (dtstu.Rows[i][0] != null) s.SSex = dtstu.Rows[i][7].ToString();
                int code = sbll.AddStudent(s, true);
                if (code==-1)
                {
                    listInf.Items.Add("["+i+1 +"]"+ " 添加失败，卡号" + s.SName+s.SCardNum + "重复");
                    continue;
                }else if (code == 1)
                {
                    listInf.Items.Add("[" + i + 1 + "]" + " 学生" + s.SName+s.SCardNum+"添加成功！");
                    success++;
                }
                else
                {
                    listInf.Items.Add("[" + i + 1 + "]" + " 学生" + s.SName + s.SCardNum + "添加失败！未知错误");
                }
            }
            MessageBox.Show("添加完成，共" + total + "个学生信息！" + "成功" + success + "个");
        }
    }
}
