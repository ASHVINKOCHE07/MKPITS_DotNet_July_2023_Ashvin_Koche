using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public customer(int i,string n)
        {
            Id = i;
            name = n;
        }
    }
}
