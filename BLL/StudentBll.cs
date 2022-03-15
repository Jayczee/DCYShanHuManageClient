using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;
using System.Data.OleDb;


namespace BLL
{
    public class StudentBll
    {
        StudentDal sdal = new();
        public DataTable GetAllStudent()
        {
            return sdal.GetAllStudent();
        }

        public DataTable SearchStu(string key, string value)
        {
            return sdal.SearchStu(key, value);
        }

        public List<ClassInf> GetClassInfs()
        {
            DataTable dt = sdal.GetClassInfs();
            if (dt == null)
                return null;
            List<ClassInf> list = new List<ClassInf>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                ClassInf ci = new();
                ci.CNo = dt.Rows[i]["CNo"].ToString();
                ci.CName= dt.Rows[i]["CName"].ToString();
                ci.CTUid= dt.Rows[i]["CTUid1"].ToString();
                ci.CTUid2 = dt.Rows[i]["CTUid2"].ToString();
                list.Add(ci);
            }
            return list;
        }

        public bool AddStudent(Student s)
        {
            int res = sdal.AddStudent(s);
            if (res >= 1)
                return true;
            return false;
        }

        public int AddStudent(Student s,bool check)
        {
            if (ExistStuByCardNum(s.SCardNum))
                return -1;
            int res = sdal.AddStudent(s);
            if (res >= 1)
                return 1;
            return 0;
        }

        public bool EditStudent(Student s)
        {
            int res = sdal.EditStudent(s);
            if(res>=1)
                return true;
            return false;
        }

        public bool ExistStuByCardNum(string cardnum)
        {
            DataTable dt = sdal.ExistStuByCardNum(cardnum);
            if (dt.Rows.Count >= 1)
                return true;
            return false;
        }

        public DataTable GetStuInfFromExcel(string path)
        {
            string conStr = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; Data source={0}; Extended Properties=Excel 12.0;", path);
            using (OleDbConnection conn = new OleDbConnection(conStr))
            {
                conn.Open();
                //获取所有Sheet的相关信息
                DataTable dtSheet = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                //获取第一个 Sheet的名称
                string sheetName = dtSheet.Rows[0]["Table_Name"].ToString();
                string sql = string.Format("select * from [{0}]", sheetName);
                using (OleDbDataAdapter oda = new OleDbDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    oda.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
