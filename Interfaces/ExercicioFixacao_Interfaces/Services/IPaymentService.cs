using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Interfaces.Services
{
    interface IPaymentService
    {
        double Tax (double amount, int month);
    }
}
