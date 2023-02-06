using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal interface ICustomers
    {
        public void AddCustomer(Customer customer);

        public void PrintCustomers();
    }
}
