using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class employee
    {
        public int empno { get; set; }
        public string empname { get; set; }
        public employee(int e1,string en)
        {
            empno = e1;
            empname = en;
        }
    }
}
