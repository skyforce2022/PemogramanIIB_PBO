using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714220017
{
    class ProductTest_714220017
    {
        static void Main(string[] args)
        {
            Book_714220017 myBook = new Book_714220017("Book", "C# Object Oriented Solution", "300");


            Console.WriteLine("\" the book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);
        }
    }
}

