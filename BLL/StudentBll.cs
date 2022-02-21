using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class StudentBll
    {
        StudentDal sdal = new();
        public DataTable GetAllStudent()
        {
            return sdal.GetAllStudent();
        }
    }
}
