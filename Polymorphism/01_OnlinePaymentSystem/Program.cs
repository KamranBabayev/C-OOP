using _01_OnlinePaymentSystem.Models;


namespace OnlinePaymentSystem.Models;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Online Ödəniş Sistemi
        //Bir e-ticarət saytında müştəri ödəniş etməlidir. Payment adlı bir base class yarat, içində ProcessPayment() adlı virtual metod olsun.
        //Sonra bu sinifdən 3 fərqli ödəniş növü inheritance ilə miras alsın:
        //CreditCardPayment
        //PayPalPayment
        //CryptoPayment
        //Hər biri ProcessPayment() metodunu override edib fərqli mesajlar versin, məsələn:
        //“Kredit kartı ilə ödəniş təsdiqləndi.”
        //“PayPal balansından ödəniş uğurla alındı.”
        //“Blockchain üzərindən kripto ödəniş həyata keçirildi.”
        //Main() methodunda List<Payment> içərisinə bu 3 növdən obyektlər əlavə et və hamısının ProcessPayment() metodunu çağır.
        //Hər ödəniş növünə Amount property-si əlavə et və ümumi məbləği hesabla.

        List<Payment> payments = new List<Payment>();
        payments.Add(new CreditCardPayment { Amount = 100 });
        payments.Add(new PayPalPayment { Amount = 200 });
        payments.Add(new CryptoPayment { Amount = 300 });
        foreach (Payment payment in payments)
        {
            payment.ProcessPayment();
            
        }

        decimal totalAmount = 0;
        foreach (Payment payment in payments)
        {
            totalAmount += payment.Amount;

        }

        Console.WriteLine($"Total amount: {totalAmount}");
    }
}