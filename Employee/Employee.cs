using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExcercise
{
    internal class Employee
    {
        string name, id, position;
        double salary;

        public Employee()
        {
            this.name = "";
            this.id = "";
            this.position = "";
            this.salary = 0;
        }

        public Employee(string name, string id, string position, double salary)
        {
            this.name = name;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }

        public void CompareSalary(Employee employee)
        {
            if (employee.salary < this.salary)
            {
                Console.WriteLine(this.name + "'s salary is larger than " + employee.name + "'s salary.");
            }
            else
            {
                Console.WriteLine(employee.name + "'s salary is larger than " + this.name);
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.Write(this.name + "\n" + this.id + "\n" + this.position + "\n" + this.salary + "'s salary");
        }

        public override string ToString()
        {
            return "Employee " + this.name + " " + this.id + " " + this.position + " " + this.salary; 
        }
    }
}
