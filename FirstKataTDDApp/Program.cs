using System;
using FirstKataTDDApp;

namespace FirstKataTDDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(0);
            acc.Deposit(500);
            acc.Withdraw(100);
            acc.PrintStatement();

            Console.Read();
        }
    }
}
