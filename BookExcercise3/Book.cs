using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Literature
{
    internal class Book
    {
        private string author, publisher;
        private string name = string.Empty;
        private string isbn = string.Empty;
        private double price;
        private static string theme = "";
        private const int MaxLength = 13;
        private const string Prefix = "978";

        public double Price
        {
            get => price;
            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }
                else
                    price = value;
            }
        }

        public string Isbn
        {

            get => isbn;

            set
            {
                if (value != null && value.StartsWith(Prefix) && value.Length == MaxLength)
                {
                    isbn = value;
                }
                else
                    Console.WriteLine("Error ISBN not found");
            }
        }

        public string Author
        {
            get
            {
                return string.Format(author);
            }
        }

        public string Name { get => name; set => name = value; }

        public Book(string name, string author, string publisher, string isbn, double price)
        {
            this.Name = name;
            this.author = author;
            this.publisher = publisher;
            this.Isbn = isbn;
            this.Price = price;
        }



        //public Book()
        //{
        //}

        public void GetBookDetails(string isbn)
        {
            if (isbn == this.Isbn)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3,5:F2}\n{4}\n", this.Name, this.author, this.publisher, this.isbn, this.Price, theme);
            }
            else Console.WriteLine("ISBN codes do not match");
        }

        public static void ChangeTheme(string newTheme)
        {
            theme = newTheme;

        }

        public override string? ToString()
        {
            return $"{this.name}, {this.author}, {this.isbn}, {this.publisher}, {this.price}";
        }
    }
}
