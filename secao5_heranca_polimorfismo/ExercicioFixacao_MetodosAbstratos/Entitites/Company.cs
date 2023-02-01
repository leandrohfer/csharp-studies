using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_MetodosAbstratos.Entitites
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees{ get; set; }

        public Company (string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double subTotal = 0;
            if (NumberOfEmployees > 10)
            {
                subTotal = AnualIncome * 0.14;
            }
            else
            {
                subTotal = AnualIncome * 0.16;
            }

            return subTotal;
        }
    }
}
