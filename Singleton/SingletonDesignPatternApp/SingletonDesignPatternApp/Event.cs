using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternApp
{
    /// <summary>
    /// Simple entity class to represent an Event 
    /// 
    /// Programmer: CodingHelpLine
    /// Web: https://codinghelpline.org 
    /// </summary>
    internal class Event
    {
        // Properties
        public string EventId { get; set; }

        public string EventName { get; set; }   
        
        public string EventDescription { get; set; }
    }
}
