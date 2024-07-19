using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_C__4_OOP.Interfaces
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        { 
            Console.WriteLine($"Using SMS Notficition: {recipient} {message}");
            
        }
    }
}
