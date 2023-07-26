using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("stella", 98);
            Console.WriteLine("*******First Account**********");

            Console.WriteLine($"details of account 1 :\nAccount holder name :{account.Accname}\nAccount number : {account.Accnumber}");
            Console.WriteLine("Enter the Amount you want to deposit ");
            account.Deposit(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Enter how much amount you want to with draw");
            account.Withdraw(decimal.Parse(Console.ReadLine()));

            BankAccount account2 = new BankAccount("senj", 234);
            Console.WriteLine("*******Second Account**********");


            Console.WriteLine($"\n\n\n\ndetails of account 2 :\nAccount holder name :{account2.Accname}\nAccount number : {account2.Accnumber}");
            Console.WriteLine("Enter the Amount you want to deposit ");
            account2.Deposit(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Enter how much amount you want to with draw");
            account2.Withdraw(decimal.Parse(Console.ReadLine()));
            Console.ReadKey();


        }
    }
}
