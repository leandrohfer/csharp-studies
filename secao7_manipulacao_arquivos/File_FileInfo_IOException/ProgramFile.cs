using System.IO;
internal class ProgramFile
{
    private static void Teste(string[] args)
    {
        // string sourcePath = "c:\\laragon\\www\\csharp-studies\\Manipulacao_Arquivos\\Manipulacao_Arquivos\\arquivos";
        string sourcePath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file1.txt";

        string targetPath = @"c:\laragon\www\csharp-studies\Manipulacao_Arquivos\Manipulacao_Arquivos\arquivos\file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);

            // Método copiar para
            fileInfo.CopyTo(targetPath);

            // Método para ler todas as linhas de um arquivo e salvar como valor em um vetor
            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
        }
    }
}