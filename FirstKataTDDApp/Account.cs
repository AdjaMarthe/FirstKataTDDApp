using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace FirstKataTDDApp
{
    public class Account
    {
        public int Balance { get; set; }
        public string Amount { get; set; }
        public string StatementDate { get; set; }
        public StringCollection Statement { get; set; }

        public Account(int val)
        {
            Balance = val;
            Statement = new StringCollection();
        }

        public void Deposit(int dpt)
        {
            if (dpt < 0)
            {
                Console.WriteLine("Veuillez indiquer un nombre positif");
            }
            else
            {
                Amount = "+" + dpt;
                Balance += dpt;
                StatementDate = DateTime.Now.ToShortDateString();
                var line = StatementDate + " " + Amount + " " + Balance + "\n";
                Statement.Add(line);
            }
        }
        public void Withdraw(int wd)
        {
            if (wd < 0)
            {
                Console.WriteLine("Veuillez indiquer un nombre positif");
            }
            else if (Balance < wd)
            {
                Console.WriteLine("Votre solde ne vous permet pas de retirer cette somme");
            }
            else
            {
                Amount = "-" + wd;
                Balance -= wd;
                StatementDate = DateTime.Now.ToShortDateString();
                var line = StatementDate + " " + Amount + " " + Balance + "\n";
                Statement.Add(line);
            }
        }

        public void PrintStatement()
        {
            Console.WriteLine("Date Amount Balance \n");
            for (int i = 0; i < Statement.Count; i++)
            {
                Console.WriteLine(Statement[i]);
            }
        }
    }
}
