using _03_BankSystem.Models;
namespace BankSystem;

internal class Program
{
    static void Main(string[] args)
    {

        //Task 3.“BankAccount” adlı bir class yaradılır. 
        //İçində accountNumber, balance adlı private field-lər olsun.Deposit() və Withdraw() adlı metodlar yaradılır:
        //Deposit() balansı artırır.
        //Withdraw() balansı azaldır(balans mənfi olmasın).
        //GetBalance() adlı bir metodla balans göstərilsin.
        //Main() methodunda bir hesab yaradılıb, pul yatırılıb və çıxarılıb, nəticələr ekrana çıxarılsın.


        BankAccount account = new BankAccount(12345,300);

        account.Deposit(300);
        Console.WriteLine();
        account.WithDraw(100);
        Console.WriteLine();
        account.GetBalance();

    }
}