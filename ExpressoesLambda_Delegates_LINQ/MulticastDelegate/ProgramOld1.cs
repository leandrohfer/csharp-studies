using ExpressoesLambda_Delegates_LINQ.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressoesLambda_Delegates_LINQ.MulticastDelegate
{
    internal class ProgramOld1
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        private static void Teste1(string[] args)
        {
            double a = 10;
            double b = 12;
            // BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.ShowSum);
            op += CalculationService.ShowMax;

            // op(a, b);
            op.Invoke(a, b);
        }
    }
}
