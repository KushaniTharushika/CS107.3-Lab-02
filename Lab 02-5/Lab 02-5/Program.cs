using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Madol duwa", "Martin Wikramasinghe"),
                new Book("Robinson Cruseo", "Daniel Defoe"),
                new Book("1984", "George Orwell")
            };

            Console.WriteLine("Attempting to borrow books...");

            foreach (var book in books)
            {
                book.BorrowBook();
            }

            
            Console.WriteLine("\nLibrary Status after borrowing:");

            foreach (var book in books)
            {
                Console.WriteLine($"Book '{book.Title}' by {book.Author} is {(book.Available ? "available" : "not available")}");
            }
        }
    }
}
