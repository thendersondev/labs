using System;

namespace QABank
{
    class BankAccount
    {
        private static int currentAccountNumber = 100000;
        
        public BankAccount()
        {
            number = currentAccountNumber++;
            balance = 1000;
        }
            
        public Customer name { get; set; }
        public int number { get; set; }
        private double balance { get; set; }

        public double Deposit(double amount)
        {
            return balance + amount;
        }

        public double Withdraw(double amount)
        {
            return balance - amount;
        }
    }

    internal class Customer
    {
    }
}