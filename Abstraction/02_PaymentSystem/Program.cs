using _02_PaymentSystem.Models;

namespace PaymentSytem;

internal class Program
{
    static void Main(string[] args)
    {
        //Task 2.
        //“Payment” adlı abstract class yaradılır. İçində:
        //ProcessPayment() adlı abstract metod olsun.
        //Sonra üç class yaz :
        //CreditCardPayment
        //PayPalPayment
        //CryptoPayment
        //Hər biri ProcessPayment() metodunu override edib fərqli mesaj çıxartsın.Main() metodunda bu obyektlərdən bəzilərini yaradıb ProcessPayment() çağır.

        CreditCardPayment credit = new CreditCardPayment();
        credit.ProcessPayment();
        Console.WriteLine();
        PayPalPayment payPal = new PayPalPayment();
        payPal.ProcessPayment();
        Console.WriteLine();
        CryptoPayment crypto = new CryptoPayment();
        crypto.ProcessPayment();
        Console.WriteLine();
    }
}