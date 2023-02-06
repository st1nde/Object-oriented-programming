using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExcercise
{
    internal class Customer: ICustomer
    {
        public string name;
        public double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }

        public Customer()
        {
          this.name=string.Empty;
            this.purchases=0;
        }

        public override string? ToString()
        {
            return this.name + " " + this.purchases + " \n";
        }

        public Customer GetCustomer(string name)
        {
            if (name.Equals(this.name))
            {
                return this;
            }
            else
            {
                return null;
            }
        }

         public double GetBonus()
        {
          
            if (this.purchases<=1000)
            {
                double bonus1 = 0.02*this.purchases;
                return bonus1;
            }
            if (this.purchases>=1000 && this.purchases<=2000)
            {
                double bonus2 = 0.03*this.purchases;
                return bonus2;
            }
            else
            {
                double bonus3 = 0.05 * this.purchases;
                return bonus3;
            }    
        }

    }
}
