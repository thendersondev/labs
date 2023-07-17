using System;

namespace QABank
{
    class Program
    {
        static void Main(string[] args)
        {
            var one = new BankAccount();
            var two = new BankAccount();
            
            Console.WriteLine(one.number);
            Console.WriteLine(two.number);
            
            Console.WriteLine(one.Deposit(100));
            Console.WriteLine(one.Withdraw(1000));
        }
    }
}
