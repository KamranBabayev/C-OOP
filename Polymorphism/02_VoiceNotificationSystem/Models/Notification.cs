using System;
using System.Collections.Generic;
using System.Text;

namespace _02_VoiceNotificationSystem.Models
{
    internal class Notification
    {
        public string Receiver { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public virtual void Send()
        {
            Console.WriteLine("“Bildiriş göndərildi”");

        }
    }
}
