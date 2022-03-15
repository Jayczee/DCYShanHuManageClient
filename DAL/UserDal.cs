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
            return SqlHelper.ExecuteNonQuery("update userinf set Uid=@uid,Pwd=@pwd,UserKind=@kind,LastLoginTime=@time,LastLoginIP=@ip where Uid=@olduid and Pwd=@oldpwd ",new SqlParameter("@uid",user.Uid.Trim()),
                new SqlParameter("@pwd",user.Upwd.Trim()),
                new SqlParameter("@kind", user.UserKind.Trim()),
                new SqlParameter("@time", user.LastLoginTime.Trim()),
                new SqlParameter("@ip", user.LastLoginIP.Trim()),
                new SqlParameter("@id", user.Upwd.Trim())
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
