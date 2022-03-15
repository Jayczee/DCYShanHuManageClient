using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private string _id="";//用户id用来作为编辑信息时更新到数据库的依据
        private string _Uid = "";//用户名
        private string _Upwd = "";//用户密码
        private string _UserKind = "";//用户标识
        private string _LastLoginTime = "";//最近登录时间
        private string _LastLoginIP = "";//最后登录地址

        public string Uid { get => _Uid; set => _Uid = value; }
        public string Upwd { get => _Upwd; set => _Upwd = value; }
        public string UserKind { get => _UserKind; set => _UserKind = value; }
        public string LastLoginTime { get => _LastLoginTime; set => _LastLoginTime = value; }
        public string LastLoginIP { get => _LastLoginIP; set => _LastLoginIP = value; }
        public string Id { get => _id; set => _id = value; }
    }
}
