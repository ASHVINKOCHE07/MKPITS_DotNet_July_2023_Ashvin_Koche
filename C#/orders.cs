using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class orders
    {
        public int orderid { get; set; }
        public string itemname { get; set; }
        public int rate { get; set; }
        public int quantity { get; set; }
        public orders (int o,string i,int r,int q)
        {
            orderid = o;
            itemname = i;
            rate = r;
            quantity = q;
        }
    }
}
