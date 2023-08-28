using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractEmployeeFactoryApp
{
    /// <summary>
    /// Top Level Abstract Employee Interface that provides a contract
    /// to calculate the salary of any Employee in the Sysetm that 
    /// will implement this Interface. This Abstract Employee is used
    /// to create specialized Employee Objects. 
    /// </summary>
    internal interface IEmployee
    {
        /// <summary>
        /// Function to calculate the Salary of the Employee
        /// </summary>
        /// <returns></returns>
        double salary(); 
    }
}
