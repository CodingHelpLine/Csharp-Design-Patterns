using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// This employee object only takes Salary. Also implements the IEmployee
    /// Interface.
    /// </summary>
    internal class SalariedEmployee : IEmployee
    {
        private double wage; 

        /// <summary>
        /// Create a Salaried Employee
        /// </summary>
        /// <param name="wage"></param>
        public SalariedEmployee(double wage)
        {
            this.wage = wage; 
        }

        /// <summary>
        /// Function to calculate the Salary of the Employee
        /// </summary>
        /// <returns></returns>
        public double salary()
        {
            return wage; 
        }

        /// <summary>
        /// Get the String representation of Employee object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Salaried Employee: ${salary()}";
        }
    }
}
