using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class product
    {
        int productid;
        string productname;
        public void getproductdata(string productname)
        {
            productid = 1;
            this.productname = productname;
        }
        public void getproductdata(int productid,string productname)
        {
            this.productid = productid;
            this.productname = productname;
        }
        public void getproductdata( string productname,int productid)
        {
            this.productid = productid;
            this.productname = productname;
        }
        public void display()
        {
            Console.WriteLine("productid " + productid);
            Console.WriteLine("productname " + productname);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
          

            product p = new product();
            p.getproductdata("mouse");
            p.display();
            Console.WriteLine("method with 2 parameters integer first");
            p.getproductdata(123, "monitor");
            p.display();
            Console.WriteLine("method with 2 parameters string first");
            p.getproductdata( "monitor",222);
            p.display();


        }
    }
}
