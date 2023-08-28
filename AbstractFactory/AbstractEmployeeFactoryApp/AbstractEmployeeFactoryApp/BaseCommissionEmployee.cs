using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Base Commission Employee that will take Base Salary
    /// and The commission on Sales. Also implements the IEmployee
    /// Interface. 
    /// </summary>
    internal class BaseCommissionEmployee : IEmployee
    {
        private double baseSalary;
        private double commission; 

        /// <summary>
        /// constructor to create BaseCommissionEmployee object. 
        /// </summary>
        /// <param name="baseSalary"></param>
        /// <param name="commission"></param>
        public BaseCommissionEmployee(double baseSalary, double commission)
        {
            this.baseSalary = baseSalary;
            this.commission = commission;
        }

        /// <summary>
        /// Function to calculate the Salary of the Employee
        /// </summary>
        /// <returns></returns>
        public double salary()
        {
            return baseSalary + commission;
        }

        /// <summary>
        /// Get the String representation of Employee object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"BaseCommission Employee: ${salary()}";
        }
    }
}
