using ExpressoesLambda_Delegates_LINQ.Services;

internal class ProgramOld
{
    delegate double BinaryNumericOperation(double n1, double n2);
    private static void Teste(string[] args)
    {
        double a = 10;
        double b = 12;
        // BinaryNumericOperation op = CalculationService.Sum;
        BinaryNumericOperation op = new BinaryNumericOperation(CalculationServiceOld.Sum);

        // double result = op(a, b);
        double result = op.Invoke(a, b);
        Console.WriteLine(result);
    }
}