using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(String[] Args)
        {
            Account acc = new Account(1001, "Leandro Henrique", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Gomes Carlos", 0.0, 500.00);

            // UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "André", 0.0, 300.00);
            Account acc3 = new SavingsAccount(1004, "Augusto", 0.0, 0.01);

            // DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount) acc2;
            acc4.Loan(100.00);


            /*
             * O CÓDIGO ABAIXO GERA ERRO DE DOWNCASTING (SUBCLASSES INCOMPATÍVEIS)
             * 
             * BusinessAccount acc5 = (BusinessAccount) acc3;
             */
            
            // SE ACC3 É UM BUSINESS ACCOUNT FAÇA
            if (acc3 is BusinessAccount)
            {
                // BusinessAccount acc5 = (BusinessAccount) acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;

                acc5.Loan(200.00);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                // SavingsAccount acc6 = (SavingsAccount)acc3;
                SavingsAccount acc6 = acc3 as SavingsAccount;

                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}