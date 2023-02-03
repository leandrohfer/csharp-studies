using System.IO;
internal class ProgramFileStream
{
    private static void Teste(string[] args)
    {
        string sourcePath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file1.txt";
        //FileStream fs = null;
        StreamReader sr = null;

		try
		{
            //fs = new FileStream(sourcePath, FileMode.Open);
            //sr = new StreamReader(fs);
            sr = File.OpenText(sourcePath);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
		}
		catch (IOException e)
		{
            Console.WriteLine("An error accured: ");
            Console.WriteLine(e.Message);
		}
        finally
        {
            //if (fs != null) fs.Close();
            if (sr != null) sr.Close();
        }
    }
}