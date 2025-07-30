using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q03
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine($"This Email Send From : {Recipient} , His Message : {Message}");
        }
    }
}
