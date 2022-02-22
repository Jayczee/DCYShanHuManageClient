using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using Model;

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
                ci.CTUid= dt.Rows[i]["CTUid"].ToString();
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

        public bool EditStudent(Student s)
        {
            int res = sdal.EditStudent(s);
            if(res>=1)
                return true;
            return false;
        }
    }
}
