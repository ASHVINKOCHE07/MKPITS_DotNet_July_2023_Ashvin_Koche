using System;

namespace BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numBooks = int.Parse(Console.ReadLine());
            Book[] books = new Book[numBooks];

            for (int i = 0; i < numBooks; i++)
            {
                Console.WriteLine("Enter details for book " + (i + 1) + ":");
                Console.WriteLine("Title:");
                string title = Console.ReadLine();
                Console.WriteLine("Author:");
                string author = Console.ReadLine();
                Console.WriteLine("Publication Year:");
                int publicationYear = int.Parse(Console.ReadLine());

                books[i] = new Book(title, author, publicationYear);
            }

            Console.WriteLine("Library Collection:");
            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("Publication Year: " + book.PublicationYear);
                Console.WriteLine();
            }
        }
    }
}