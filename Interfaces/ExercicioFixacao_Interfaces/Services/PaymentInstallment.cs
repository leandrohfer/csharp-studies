using ExercicioFixacao_Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Interfaces.Services
{
    internal class PaymentInstallment
    {
        public int NumberInstallment { get; set; }

        public IPaymentService _paymentService { get; set; }

        public PaymentInstallment(int numberInstallment, IPaymentService paymentService)
        {
            NumberInstallment = numberInstallment;
            _paymentService = paymentService;
        }

        public void ProcessPayment (Contract contract)
        {
            double amount = contract.TotalValue / NumberInstallment;

            double valueInstallment;
            DateTime dueDate;
            int i = 1;
            while (i <= NumberInstallment)
            {
                valueInstallment = _paymentService.Tax(amount, i);
                dueDate = contract.Date.AddMonths(i);

                contract.Installments.Add(new Installment(dueDate, valueInstallment));
                
                i++;
            }
        }
    }
}
