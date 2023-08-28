using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Employee Factory class that implement the IEmployeeFactory
    /// Interface that is top-level factory interface and provides
    /// the function implementation for the Employee Creation. 
    /// </summary>
    internal class EmployeeFactory : IEmployeeFactory
    {
        private static EmployeeFactory factory;
        
        /// <summary>
        /// Restrict the object create by declaring private Constructor
        /// </summary>
        private EmployeeFactory()
        {
            //factory = new EmployeeFactory(); // StackOverFLow
        }

        /// <summary>
        /// Provide a Global Access Point to the Singleton Instance of this Factory. 
        /// </summary>
        /// <returns></returns>
        public static EmployeeFactory GetFactory()
        { 
            // Check if factory is null
            if(factory == null)
            {
                factory = new EmployeeFactory();
            }

            return factory; 
        }

        /// <summary>
        /// Function to create a Commission based Employee Object. 
        /// </summary>
        /// <param name="commission"></param>
        /// <returns></returns>
        public IEmployee CreateCommissionEmployee(double commission)
        {
            return new CommissionEmployee(commission);
        }


        /// <summary>
        /// Function to create an Hourly Employee
        /// </summary>
        /// <param name="hourlyWage"></param>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        public IEmployee CreateHourlyEmployee(double hourlyWage, double hoursWorked)
        {
            return new HourlyEmployee(hourlyWage, hoursWorked);
        }

        /// <summary>
        /// Create an Employee with Salary
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        public IEmployee CreateSalariedEmployee(double salary)
        {
            return new SalariedEmployee(salary);
        }

        /// <summary>
        /// Create an Employee with Base Salary and Commission. 
        /// </summary>
        /// <param name="baseSalary"></param>
        /// <param name="commission"></param>
        /// <returns></returns>
        public IEmployee CreateBaseCommissionEmployee(double baseSalary, double commission)
        {
            return new BaseCommissionEmployee(baseSalary, commission);
        }
    }
}
