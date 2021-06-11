using System;

namespace Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Nam", "Nguyen", "Ha Noi", 5, 250);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateTheBonus(2));            
        }
    }
}