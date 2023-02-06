using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Literature;
namespace BookExcercise3
{

        internal class Author
        {
            public string name;
            public string birthday;
            private Book? book;

        public Author(string name, string birthday, Book book)
            {
                this.name = name;
                this.birthday = birthday;
                this.Book = book;
            }
        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        internal Book? Book
        {
            get => book;

            set
            {
                if (value != null && value.Author == this.name)
                {
                    book = value;
                }
                
            }
        }

        public void PrintInformation()
            {
            if (this.Book != null)
            {
                Console.WriteLine("Author " + this.name + "\ndate of birth " + this.birthday + "\nBook information " + this.Book.Name + "\n" + this.Book.Price + "\n" + this.Book.Isbn + "\n");
            }
            else Console.WriteLine("404 Data not found");
            }


        }
}
