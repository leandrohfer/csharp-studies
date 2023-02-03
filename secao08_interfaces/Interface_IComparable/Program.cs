using Interface_IComparable.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = @"C:\laragon\www\csharp-studies\Interfaces\Interface_IComparable\test.txt";

		try
		{
			using (StreamReader sr = File.OpenText(path))
			{
				List<Employee> list = new List<Employee>();
				while (!sr.EndOfStream)
				{
					list.Add(new Employee(sr.ReadLine()));
				}
				list.Sort();
				foreach (Employee emp in list)
				{
					Console.WriteLine(emp);
				}
			}
		}
		catch (IOException e)
		{
			Console.WriteLine("An error occurred " + e.Message);
		}
    }
}