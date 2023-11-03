using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp156
{
    class Book
    {
        int bookid;
        String title,author;
        //creating a constructor with no parameters.
        int price;
        public Book() {

            bookid = 1;
            title = "oracle";
            author = "James";
            price = 200;
        }
        public void display()
        {
            Console.WriteLine("book id = "+bookid);
            Console.WriteLine("book title = "+title);
            Console.WriteLine("book author = "+author);
            Console.WriteLine("price = " + price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            
        }
    }
}
