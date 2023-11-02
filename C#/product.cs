using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform_product
{
    internal class Product
    {
        public string productname {  get; set; }
        public int productprice {  get; set; }
        public int productitem {  get; set; }

        public void getadata(string productname, int productprice,int productitem)
        {
            this.productname = productname;
            this.productprice = productprice;
            this.productitem = productitem;
        }
    }
}