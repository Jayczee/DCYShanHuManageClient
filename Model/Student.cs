using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student
    {
        private string _SName = "";
        private string _SSex = "";
        private string _SClassNo = "";
        private string _SYear = "";
        private string _SPoints = "";
        private string _SWxId = "";
        private string _SPhone = "";
        private string _SWxId2 = "";
        private string _SCardNum = "";
        private string _STotalPoints = "";

        public string SName { get => _SName; set => _SName = value; }
        public string SSex { get => _SSex; set => _SSex = value; }
        public string SClassNo { get => _SClassNo; set => _SClassNo = value; }
        public string SYear { get => _SYear; set => _SYear = value; }
        public string SPoints { get => _SPoints; set => _SPoints = value; }
        public string SWxId { get => _SWxId; set => _SWxId = value; }
        public string SPhone { get => _SPhone; set => _SPhone = value; }
        public string SWxId2 { get => _SWxId2; set => _SWxId2 = value; }
        public string SCardNum { get => _SCardNum; set => _SCardNum = value; }
        public string STotalPoints { get => _STotalPoints; set => _STotalPoints = value; }
    }
}
