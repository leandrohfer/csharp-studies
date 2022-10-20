using ExpressoesLambda_Delegates_LINQ.Services;

internal class Program
{
    delegate double BinaryNumericOperation(double n1, double n2);
    private static void Main(string[] args)
    {
        double a = 10;
        double b = 12;
        // BinaryNumericOperation op = CalculationService.Sum;
        BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
        // double result = op(a, b);
        double result = op.Invoke(a, b);
        Console.WriteLine(result);
    }
}