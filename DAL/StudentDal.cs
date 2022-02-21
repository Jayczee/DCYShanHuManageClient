using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
    }
}
