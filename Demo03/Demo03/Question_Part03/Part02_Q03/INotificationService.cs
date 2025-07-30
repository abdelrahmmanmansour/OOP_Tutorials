using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_Part03.Part02_Q03
{
    internal interface INotificationService
    {
        // Signature Of Method:
        void SendNotification(string Recipient, string Message);
    }
}
