using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClassInf
    {
        private string _CNo = "";
        private string _CName = "";
        private string _CTUid = "";
        private string _CTUid2 = "";

        public string CNo { get => _CNo; set => _CNo = value; }
        public string CName { get => _CName; set => _CName = value; }
        public string CTUid { get => _CTUid; set => _CTUid = value; }
        public string CTUid2 { get => _CTUid2; set => _CTUid2 = value; }
    }
}
