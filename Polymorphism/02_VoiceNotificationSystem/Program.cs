using _02_VoiceNotificationSystem.Models;

namespace NotificationSystem;

internal class Program
{
    static void Main(string[] args)
    {
        // Task 2 - Səsli Bildiriş Sistemi
        //Təsəvvür et ki, bir şirkətin müxtəlif platformalarda(Email, SMS, MobileApp) müştərilərə bildiriş göndərmə sistemi var.Bu sistemi polymorphism istifadə edərək qur.
        //- Notification adlı bir base class yarat.
        //İçində Receiver adlı property olsun(kimə göndərilir).
        //Send() adlı virtual metod yaz, içərisində sadəcə “Bildiriş göndərildi” mesajı çap olunsun.
        //- EmailNotification, SmsNotification və AppNotification adlı 3 alt class yarat.
        //Hər biri Notification sinifindən miras alsın.
        //Send() metodunu override edib fərqli mesaj yazsın:
        //Email  -  “E-poçt göndərildi: Yeni kampaniya var!”
        //SMS - “SMS göndərildi: 10% endirim qazandınız!”
        //App - “Mobil bildiriş: Yeni mesajınız var!”
        //- Main() methodunda müxtəlif növ bildirişlər yaradıb,
        //List<Notification> içərisində saxla.Daha sonra foreach dövrü ilə hər bir bildirişin
        //Send() metodunu çağır.Əlavə olaraq Notification sinifinə Date adlı property əlavə et
        //— bildirişin göndərildiyi vaxtı (DateTime.Now) çap et.


        List<Notification> notifications = new List<Notification>();
        notifications.Add(new SmsNotification { Receiver = "Kanan" });
        notifications.Add(new EmailNotification { Receiver = "Bayram" });
        notifications.Add(new AppNotification { Receiver = "Ilkin" });


        foreach (Notification notification in notifications)
        {
            notification.Send();

            Console.WriteLine(notification.Date);
        }

    }
}