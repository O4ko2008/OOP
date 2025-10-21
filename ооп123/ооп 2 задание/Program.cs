using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ооп_2_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank = new BankAccount("Denis", 0);
            bank.Deposit(1500);
            bank.Withdraw(1000);
        }
    }
}
        