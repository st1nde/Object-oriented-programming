using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerExcercise
{
    internal class Book
    {
        string title;
        string author;
        double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public override string? ToString()
        {
            return this.title + " " + this.author + " " + this.price + "\n\n";
        }
    }
}
