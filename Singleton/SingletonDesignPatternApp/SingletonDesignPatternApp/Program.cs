using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternApp
{
    internal class Program
    {
        /// <summary>
        /// Client Code to test the Functionality of Singleton Design Pattern. 
        /// 
        /// Programmer: CodingHelpLine
        /// Web: https://codinghelpline.org 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Create singleton object
            EventService service = EventService.GetInstance();

            Event e1 = new Event();
            e1.EventId = "E1";
            e1.EventName = "Dinner";
            e1.EventDescription = "Family Dinner";

            Event e2 = new Event();
            e2.EventId = "Ee";
            e2.EventName = "Meeting";
            e2.EventDescription = "Business Meeting";

            // Add elements
            service.AddEvent(e1);
            service.AddEvent(e2);

            // Print
            service.Print();

            // Remove one element
            service.RemoveEvent("E1");

            // Print again
            Console.WriteLine("Event Servics: ");
            service.Print();


            // Create new Instance
            EventService svc2 = EventService.GetInstance();
            Console.WriteLine("\n\nSecond Instance of Event Service:");
            svc2.Print();

            Console.ReadKey();
        }
    }
}
