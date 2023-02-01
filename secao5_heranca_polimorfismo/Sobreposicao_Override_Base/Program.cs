using System;
using Sobreposicao_Override_Base.Entities;

namespace Sobreposicao_Override_Base
{
    class Program
    {
        static void Main(String[] Args)
        {
            Account acc1 = new Account(1001, "Leandro", 500.0);
            Account acc2 = new SavingsAccount(1004, "Augusto", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}