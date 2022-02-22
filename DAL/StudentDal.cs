using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class StudentDal
    {
        public DataTable GetAllStudent()
        {
            return SqlHelper.ExecuteTable("select * from student");
        }

        public DataTable SearchStu(string key, string value)
        {
            switch (key)
            {
                case "班级编号":
                    {
                        return SqlHelper.ExecuteTable("select * from student where SClassNo = @para1",
                            new SqlParameter("@para1", value));
                    }
                case "姓名":
                    {
                        return SqlHelper.ExecuteTable("select * from student where SName = @para1",
                            new SqlParameter("@para1", value));
                    }
                case "性别":
                    {
                        return SqlHelper.ExecuteTable("select * from student where SSex = @para1",
                            new SqlParameter("@para1", value));
                    }
                case "入学年份":
                    {
                        return SqlHelper.ExecuteTable("select * from student where SYear = @para1",
                            new SqlParameter("@para1", value));
                    }
                case "卡号":
                    {
                        return SqlHelper.ExecuteTable("select * from student where SCardNum = @para1",
                            new SqlParameter("@para1", value));
                    }
            }
            return null;
        }

        public int EditStudent(Student s)
        {
            return SqlHelper.ExecuteNonQuery("update student set SName=@para1,SClassNo=@para2,SYear=@para3,SPoints=@para4,SPhone=@para5,STotalPoints=@para6,SSex=@para7 where SCardNum=@para8",
               new SqlParameter("@para1", s.SName),
               new SqlParameter("@para2", s.SClassNo),
               new SqlParameter("@para3", s.SYear),
               new SqlParameter("@para4", s.SPoints),
               new SqlParameter("@para5", s.SPhone),
               new SqlParameter("@para6", s.STotalPoints),
               new SqlParameter("@para7", s.SSex),
               new SqlParameter("@para8", s.SCardNum));
        }

        public int AddStudent(Student s)
        {
            return SqlHelper.ExecuteNonQuery("insert into student(SName,SClassNo,SYear,SPhone,SCardNum,SSex)values(@para1,@para2,@para3,@para4,@para5,@para6)",
                new SqlParameter("@para1",s.SName),
                new SqlParameter("@para2",s.SClassNo),
                new SqlParameter("@para3",s.SYear),
                new SqlParameter("@para4",s.SPhone),
                new SqlParameter("@para5",s.SCardNum),
                new SqlParameter("@para6",s.SSex));
        }

        public DataTable GetClassInfs()
        {
            return SqlHelper.ExecuteTable("select * from classinfo");
        }
    }
}
