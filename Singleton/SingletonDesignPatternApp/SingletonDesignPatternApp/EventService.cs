using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPatternApp
{
    /// <summary>
    /// Class to implement the Singleton Design Pattern and provides a mechanism
    /// to maintain a single instance of itself. 
    /// 
    /// Programmer: CodingHelpLine
    /// Web: https://codinghelpline.org 
    /// </summary>
    internal class EventService
    {

        // Two things
        // 1. collection to store events
        // 2. Instance of this class 

        private Dictionary<String, Event> events;

        // Static reference to current class
        private static EventService instance; 

        /// <summary>
        /// Private constructor to limit creation of instances. 
        /// </summary>
        private EventService()
        {
            events = new Dictionary<String, Event>();
            instance = null; 
        }

        /// <summary>
        /// Function to maintain or provide Global Access Point to the instance 
        /// this class. 
        /// 
        /// </summary>
        /// <returns></returns>
        public static EventService GetInstance()
        {
            // Check if the instance is null
            if(instance == null)
            {
                instance = new EventService();  
            }

            return instance;
        }

        /// <summary>
        /// Function add new Event into the repository
        /// </summary>
        /// <param name="eventObject"></param>
        public void AddEvent(Event eventObject)
        {
            this.events.Add(eventObject.EventId, eventObject);
        }

        /// <summary>
        /// Remove event from the Dictionary. 
        /// </summary>
        /// <param name="eventgId"></param>
        public void RemoveEvent(string eventgId)
        {
            this.events.Remove(eventgId);
        }

        
        /// <summary>
        /// Print the events
        /// </summary>
        public void Print()
        {
            foreach (var evt in events)
            {
                Event e = evt.Value;

                Console.WriteLine($"({e.EventId}, {e.EventName}, {e.EventDescription}");
            }
        }
    }
}
