using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Employee that only Take Commission on Sales. Also implements 
    /// the IEmployee Interface.
    /// </summary>
    internal class CommissionEmployee : IEmployee
    {
        private double commission; 

        /// <summary>
        /// Create a Commission Employee with a given Commission. 
        /// </summary>
        /// <param name="commission"></param>
        public CommissionEmployee(double commission)
        {
            this.commission = commission;
        }


        /// <summary>
        /// Function to calculate the Salary of the Employee
        /// </summary>
        /// <returns></returns>
        public double salary()
        {
            return commission;
        }

        /// <summary>
        /// Get the String representation of Employee object. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Commission Employee: ${salary()}";
        }
    }
}
