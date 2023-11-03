using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp157
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public Book()
        {
            Console.WriteLine("constructor with no parameters called.");
            bookid = 123;
            title = "Vb.net";
            author = "roshan kumar";
            price = 2333;
        
        }
        //creating a parameterized constructor with 4 parameters.
        public Book(int bookid,string title,string author,int price)
        {
            Console.WriteLine("constructor with parameters called");
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id : "+ bookid);
            Console.WriteLine("title : " + bookid);
            Console.WriteLine("book id : " + bookid);
            Console.WriteLine("book id : " + bookid);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Book b1=new Book(123, "wikipedia", "denvil", 456);
            b1.display();
        }
    }
}
