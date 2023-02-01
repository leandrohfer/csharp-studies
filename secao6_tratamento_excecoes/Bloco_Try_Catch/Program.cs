using System;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
		FileStream fs = null;
		try
		{
			int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

			int result = n1 / n2;
			Console.WriteLine(result);

			fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
			StreamReader sr = new StreamReader(fs);
			string line = sr.ReadLine();

			Console.WriteLine(line);
        }
		catch (DivideByZeroException)
		{
			Console.WriteLine("Division by zero is not allowed"); ;
		}
		catch (FormatException e)
		{
			Console.WriteLine("Format error!" + e.Message);
		}
		catch (FileNotFoundException e)
		{
			Console.WriteLine(e.Message);
		}
		catch (DirectoryNotFoundException e)
		{
			Console.WriteLine(e.Message);
		}
		/*
		 * O bloco finally executa qualquer instrução independente do tryCatch.
		 * 
		 * Geralmente utilizado para fechar arquivos ou conexão com o banco.
		 */
		finally
		{
			if (fs != null) fs.Close();
		}
    }
}