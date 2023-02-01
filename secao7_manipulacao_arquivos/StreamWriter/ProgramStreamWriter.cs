using System.IO;
internal class ProgramStreamWriter
{
    private static void Main(string[] args)
    {
        string sourcePath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file1.txt";
        string targetPath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file2.txt";
        try
        {
            string[] lines = File.ReadAllLines(sourcePath);
            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(e.Message);
        }
    }
}