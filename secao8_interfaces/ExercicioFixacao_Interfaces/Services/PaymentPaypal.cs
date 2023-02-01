using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Interfaces.Services
{
    internal class PaymentPaypal : IPaymentService
    {
        public double Tax (double amount, int month)
        {
            amount += amount * 0.01 * month;
            return amount += amount * 0.02;
        }
    }
}
