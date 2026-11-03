using System;
using System.Collections.Generic;
using System.Text;

namespace _03_BankSystem.Models
{
    internal class BankAccount
    {
        private int _accountNumber;
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }
        }

        private double _balance;
        public double Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance menfi ola bilmez!");
                }
                else
                {
                    _balance = value;
                }

            }
        }



        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;

            Balance = balance;
        }

        public double Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Daxil etdiyiniz mebleg 0-dan boyuk olmalidir!");
            }
            else
            {
                Balance += amount;


            }
            Console.WriteLine($"Balance:{Balance}");
            return Balance;


        }

        public double WithDraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Daxil etdiyiniz mebleg 0-dan boyuk olmalidir!");
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Cixarmaq istediyiniz mebleg Balancdan boyuk ola bilmez!");
            }

            else
            {

                Balance -= amount;


            }
            Console.WriteLine($"Balance:{Balance}");
            return Balance;
        }


        public void GetBalance()
        {
            Console.WriteLine($"Balance:{Balance}");
            Console.WriteLine($"AccountNumber:{AccountNumber}");
        }
    }
}
