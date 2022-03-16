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
    public class UserDal
    {
        public DataTable UserLogin(string uid, string pwd,int userkind)
        {
            return SqlHelper.ExecuteTable("select * from userinf where Uid=@para1 and Pwd=@para2 and UserKind=@para3",
                new SqlParameter("@para1",uid),
                new SqlParameter("@para2",pwd),
                new SqlParameter("@para3",userkind));
        }
        public int EditUser(User user)
        {
            return SqlHelper.ExecuteNonQuery("UPDATE userinf set uid=@name, pwd=@pwd,userkind=@k WHERE ID=@id",
                new SqlParameter("@name",user.Uid.Trim()),
                new SqlParameter("@pwd",user.Upwd.Trim()),
                new SqlParameter ("@k",user.UserKind.Trim()),
                new SqlParameter("@id",user.Id)
                );
        }
        public int AddUser(User user)
        {
            return SqlHelper.ExecuteNonQuery(
                "insert into userinf(Uid,Pwd,UserKind,LastLoginTime,LastLoginIP)values(@id,@pwd,@kind,@time,@ip)",
                new SqlParameter("@id",user.Uid.Trim()),
                new SqlParameter("@pwd",user.Upwd.Trim()),
                new SqlParameter("@kind",user.UserKind.Trim()),
                new SqlParameter("@time",user.LastLoginTime.Trim()),
                new SqlParameter("@ip",user.LastLoginIP.Trim())
                );
        }
        public DataTable GetAllUser()
        {
            return SqlHelper.ExecuteTable("select * from userinf");
        }
    }
}
