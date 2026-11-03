using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VoiceNotificationSystem.Models
{
    internal class SmsNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine($"{Receiver}: “SMS göndərildi: 10% endirim qazandınız!”");
        }
    }
}
