using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Product :IProduct
    {
        public string name;
        public double price;
        public double count;

        public Product(string name, double price, double count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public double CalculateTotal()
        {
            //throw new NotImplementedException();
            return this.price * this.count;
        }

        public Product GetProduct(string name)
        {
            //throw new NotImplementedException();

            if (name.Equals(this.name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return this.name + " product\n" + this.price + "e\n" + this.count + " amount\n";
        }
    }
}
