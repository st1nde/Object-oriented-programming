using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Store : IProducts, ICustomers
    {
        private string name;
        private double revenue;
        private List<Product> storeProducts = new List<Product>();
        private List<Customer> storeCustomers = new List<Customer>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddProduct(Product product)
        {
            this.storeProducts.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine("Tuotteiden lukumäärä " + this.storeProducts.Count);

            foreach (Product product in this.storeProducts)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Storage value " + product.CalculateTotal());
            }
        }

        public override string? ToString()
        {
            return "Strore name " + this.name + " revenue " + this.revenue + " Amount of cutomers " + " Num of customers 3 & num of products 3";
        }

        public void AddCustomer(Customer customer)
        {
            this.storeCustomers.Add(customer);
        }

        public void PrintCustomer()
        {

        }

        public void PrintCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
