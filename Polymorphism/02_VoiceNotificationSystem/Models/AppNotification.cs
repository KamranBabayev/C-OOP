using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VoiceNotificationSystem.Models
{
    internal class AppNotification:Notification
    {
        public override void Send()
        {
            Console.WriteLine($"{Receiver}:“Mobil bildiriş: Yeni mesajınız var!”");
        }
    }
}
