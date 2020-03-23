using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id;
        public decimal Balance;
      
        // 2//
        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Can't deposite Negative amount");
            }
            else Balance = Balance + amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Can't withdraw");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Can't withdraw negative amount");
            }
            else Balance = Balance - amount;
        }

        public override string ToString()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Balance: {0}", Balance);
            return base.ToString();
        }
    }
   /* class create
    {
        static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 12;                     
            acc.Withdraw(10);
            Console.WriteLine($"Acconut{acc.Id},Balance{acc.Balance}");
        }
        
       static void Main(string[] args)
        {
            BankAccount acc = new BankAccount();
            acc.Id = 1;
            acc.Deposit(12);
            acc.Balance = 15;
            Console.WriteLine(acc);
        }      
    }*/

    class preson
    {
               
           private string name;
           private int age;
           private List<BankAccount> account;

        public preson(string n, int a)
        {
            name = n;
            age = a;
        }
        public preson(string n, int a, List<BankAccount> acc)
        {
            name = n;
            age = a;
            account = acc;
        }
        public decimal GetBalance()
        {
            decimal sum;
            sum = account.Sum(x => x.Balance);
            return sum;
        }

    }


}
