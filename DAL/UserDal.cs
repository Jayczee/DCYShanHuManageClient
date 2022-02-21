using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class UserDal
    {
        public DataTable UserLogin(string uid, string pwd,int userkind)
        {
            return SqlHelper.ExecuteTable("select * from userinf where Uid=@para1 and Pwd=@para2 and UserKind=@para3",
                new SqlParameter("@para1",uid),
                new SqlParameter("@para2",pwd),
                new SqlParameter("@para3",userkind));
        }

        public DataTable GetAllUser()
        {
            return SqlHelper.ExecuteTable("select * from userinf");
        }
    }
}
