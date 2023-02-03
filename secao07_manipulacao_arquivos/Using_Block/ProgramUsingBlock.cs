using System.IO;
internal class ProgramUsingBlock
{
    private static void Teste(string[] args)
    {
        /**
         * Using Block é uma sintaxe simplificada que garante que objetos
         * IDisposable serão fechados. 
         * 
         * Objetos IDisposable não são gerenciados pelo CLR. Eles precisam ser
         * manualmente fechados. São objetos externos. É utilizado para 
         * minimizar o código evitando por exemplo o FileStream.Close().
         * 
         * Ex.: Font, FileStream, StreamReader, StreamWriter.
         */
        string sourcePath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file1.txt";
        try
        {
            using (StreamReader sr = File.OpenText(sourcePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
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