using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace java_basics
{
    internal class Book
    {

        public string title;
        public string author;
        public int pages;





        public void GetBook()
        {
            Book Book1 = new Book();

            Book1.title = "Harry Potter";

            Book1.author = "JK Rowling";

            Book1.pages = 400;

            Console.WriteLine(Book1.author);

            Console.ReadLine();
        }
    }
}

