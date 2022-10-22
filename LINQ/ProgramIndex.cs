internal class ProgramIndex
{
    private static void Teste(string[] args)
    {
        /*
         * LINQ significa Language Integrated Query (Consulta Integrada
         * a Linguagem). Basicamente são consultas realizadas diretamente
         * na Linguagem C# baseadas na integração de funcionalidades
         * 
         * O fluxo para se utilizar o LINQ é: Especificar uma fonte de 
         * dados, desenvolver a consulta e executar a consulta
         */

        /*
         * Especificando a base de dados
         */
        int[] numbers = new int[] { 2, 3, 4, 5 };

        /*
         * Defininindo a expressão/consulta/query
         */
        IEnumerable<int> result = numbers.Where(x => x % 2 == 0).Select(x => 10 * x);

        /*
         * O Where serve para filtrar a fonte de dados e gerar uma nova 
         * de acordo com o filtro inserido, no caso abaixo ele está filtrando
         * na variável result uma nova collection apenas com os número pares
         * 
         * Nota: O Where recebe um delegate do tipo predicate
         */


        /*
         * Executando a query/consulta
         */
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }
}