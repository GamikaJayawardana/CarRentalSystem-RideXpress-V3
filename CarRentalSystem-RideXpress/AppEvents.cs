using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem_RideXpress
{
    internal class AppEvents
    {
        // Static event to notify that the car list was updated
        public static event Action CarListUpdated;

        // Method to raise the event
        public static void RaiseCarListUpdated()
        {
            CarListUpdated?.Invoke(); // Invoke the event if there are subscribers
        }
    }
}
