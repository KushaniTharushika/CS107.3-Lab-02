using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet_2_Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book mybook = new Book();
            mybook.Title = "Village by the sea";
            mybook.Author = "Anita Desai";

            Console.WriteLine("Title: "+ mybook.Title);
            Console.WriteLine("Author: "+ mybook.Author);

            Console.ReadLine();
        }
    }
}
