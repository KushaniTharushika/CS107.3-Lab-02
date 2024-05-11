using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_5
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        
        public void LibraryBook(string title, string author )
        {
            Title = title;
            Author = author;
            Available = true;
        }

        public void BorrowBook() 
        {
            if (Available)
            {
                Available = false;

                Console.WriteLine($"Book '{Title}' by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Book '{Title}' by {Author} is not available for borrowing.");
            }
        }
    }
}
