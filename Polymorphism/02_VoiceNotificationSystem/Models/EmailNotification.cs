using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VoiceNotificationSystem.Models
{
    internal class EmailNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine($"{Receiver}:“E-poçt göndərildi: Yeni kampaniya var!”");
        }
    }
}
