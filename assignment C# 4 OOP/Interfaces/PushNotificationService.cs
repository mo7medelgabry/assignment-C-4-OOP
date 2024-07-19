using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        { 
            Console.WriteLine($"Using Push Notficition: {recipient} {message}");

        }
    }
}
