 internal class Program
{
    private static void Main(string[] args)
    {
        DateTime dt = new DateTime(2021, 11, 16, 8, 10, 45);
        Console.WriteLine(dt.ElapsedTime() + "\n");

        String s1 = "Good morning dear students!";
        Console.WriteLine(s1.Cut(15));
    }
}