using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Top-Level Employee Factory Interface that exposes the functions
    /// to the client code to create different types of Employees. This
    /// top-level Abstract Factory Contract will be implemented by the
    /// EmployeeFactory concrete singleton factory class. 
    /// </summary>
    internal interface IEmployeeFactory
    {

        /// <summary>
        /// Function to create a Commission based Employee Object. 
        /// </summary>
        /// <param name="commission"></param>
        /// <returns></returns>
        IEmployee CreateCommissionEmployee(double commission);


        /// <summary>
        /// Function to create an Hourly Employee
        /// </summary>
        /// <param name="hourlyWage"></param>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        IEmployee CreateHourlyEmployee(double hourlyWage, double hoursWorked);

        /// <summary>
        /// Create an Employee with Salary
        /// </summary>
        /// <param name="salary"></param>
        /// <returns></returns>
        IEmployee CreateSalariedEmployee(double salary);

        /// <summary>
        /// Create an Employee with Base Salary and Commission. 
        /// </summary>
        /// <param name="baseSalary"></param>
        /// <param name="commission"></param>
        /// <returns></returns>
        IEmployee CreateBaseCommissionEmployee(double baseSalary, double commission); 
    }
}
