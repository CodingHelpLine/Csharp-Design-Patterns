using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Hourly employee that maintains the Hours Worked and Hourly
    /// Salary. If hours worked are more than 40, the hourly wage is
    /// 50% more than regular hours. Also implements the IEmployee
    /// Interface.
    /// </summary>
    internal class HourlyEmployee : IEmployee
    {
        private double hourlyWage;
        private double hoursWorked;


        /// <summary>
        /// Create Hourly Employee with hours worked and hourly rate
        /// </summary>
        /// <param name="hourlyWage"></param>
        /// <param name="hoursWorked"></param>
        public HourlyEmployee(double hourlyWage, double hoursWorked)
        {
            this.hourlyWage = hourlyWage;
            this.hoursWorked = hoursWorked;
        }


        /// <summary>
        /// Function to calculate the Salary of the Employee
        /// </summary>
        /// <returns></returns>
        public double salary()
        {
            double wage = 0;

            double hours = hoursWorked; 

            // if they are above 40, increase wage 50%
            if(hours > 40)
            {
                wage = (hours - 40) * 1.5 * hourlyWage;
                hours = 40; 
            }

            // regular pay
            wage += hours * hourlyWage;

            // return total salary
            return wage;
        }

        /// <summary>
        /// Get the String representation of Employee object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Hourly Employee: ${salary()}";
        }
    }
}
