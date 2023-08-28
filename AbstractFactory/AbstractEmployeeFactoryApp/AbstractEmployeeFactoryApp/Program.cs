using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    internal class Program
    {
        /// <summary>
        /// Client Code that uses the IEmployeeFactory Interface
        /// object and create Employees using it and display the 
        /// Employee details. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create Instance of EmployeeFactor
            IEmployeeFactory factory = EmployeeFactory.GetFactory();  //singleton Design Pattern

            // Create Employees - Salaried
            IEmployee emp = factory.CreateSalariedEmployee(25000);
            Console.WriteLine("{0}", emp.ToString());

            // Hourly Employee
            emp = factory.CreateHourlyEmployee(13.5, 42);
            Console.WriteLine("{0}", emp.ToString());

            // Create Commission Employee
            emp = factory.CreateCommissionEmployee(19000);
            Console.WriteLine("{0}", emp.ToString());

            emp = factory.CreateBaseCommissionEmployee(5000, 12900);
            Console.WriteLine("{0}", emp.ToString());

            Console.ReadKey();
        }
    }
}
