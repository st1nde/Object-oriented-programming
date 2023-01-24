using EmployeeExcercise;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee("Angela White", "001", "trainee", 1500);
        employees[1] = new Employee("Dana Vespoli", "002", "HR manager", 2500);
        employees[2] = new Employee("Savannah Bond", "003", "CEO", 5500);

        for (int i = 0; i < employees.Length; i++)
        {
            Console.WriteLine(employees[i].ToString());
        }
        for (int i = 0; i < employees.Length; i++)
        {
            if (i < employees.Length - 1)
                employees[i].CompareSalary(employees[i + 1]);
            else
                employees[i].CompareSalary(employees[0]);
        }    
    }
}