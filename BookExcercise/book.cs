using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookExcercise
{
    internal class book
    {
        string title, author, id;
        double price;

        public book()
        {
            this.id = "00000";
            this.title = "";
            this.author = "";
            this.price = 20;

            this.PrintData();
        }

        public book(string id, string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.id = SetId(id);
            this.price = price;

            this.PrintData();
        }
        public void PrintData()
        {
            Console.WriteLine("id: {0}\nTitle: {1}\nAuthor: {2}\nPrice: {3}\n",
                this.id, this.title, this.author, this.price);
        }
        public string SetId(string id)
        {
            if (id.Length == 5)
            {
                this.id = id;
            }
            else Console.WriteLine("404 id not found");
            return this.id;

        }

        public void CompareBook(book other)
        {
            if (other.price < this.price)
                Console.WriteLine(this.title + " is more expensive than " + other.title);
            else
                Console.WriteLine(this.title + " is cheaper than " + other.title);
        }

    }
}
