using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_MetodosAbstratos.Entitites
{
    internal class Individual : TaxPayer
    {
        public double HealthSpending { get; set; }

        public Individual (string name, double anualIncome,double healthSpending)
            : base(name, anualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double subTotal = 0;
            if (AnualIncome <= 20000.00)
            {
                subTotal = AnualIncome * 0.15;
            } 
            else
            {
                subTotal = AnualIncome * 0.25;
            }

            return subTotal - (HealthSpending * 0.5);
        }
    }
}
