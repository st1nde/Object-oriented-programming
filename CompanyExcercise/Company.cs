using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExcercise
{
    internal class Company
    {
        string title, address, phone;
        double outcome, expense;

        public Company()
        {
            this.title = "";
            this.address = "";
            this.phone = "000000";
            this.outcome = 00000;
            this.expense = 0000;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }
        public Company(Company other)
        {
            this.title = other.title;
            this.phone=other.phone;
            this.address=other.address;
            this.outcome=other.outcome;
            this.expense=other.expense;
        }

        public override string ToString()
        {
            return "Title " + this.title + "\nAddress" + this.address + "\nPhone" + this.phone + "\n";
        }

        public void ProfitCheck()
        {
            double profitPercent = (this.outcome - this.expense)/ this.expense * 100;
            if (profitPercent < 100)
            {
                Console.WriteLine(this.title + " is doing poorly");
            }
            else if (profitPercent <= 200)
            {
                Console.WriteLine(this.title + " is doing tolerably");
            }
            else if (profitPercent >= 200)
            {
                Console.WriteLine(this.title + " is doing satisfyingly");
            }
            else if (profitPercent <= 300)
            {
                Console.WriteLine(this.title + " is doing well");
            }
        }
    }
}
