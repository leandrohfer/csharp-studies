class Var_SwitchCase_ExpTernaria
{
    static void Teste(string[] args)
    {
        /*
         * Existe inferência de tipos de C#, utilizando
         * "var" o tipo de variável será definido após
         * a inicialização da mesma.
         */
        var x = int.Parse(Console.ReadLine());

        string dia;

        /*
         * Sintaxe para o Switch Case
         */
        switch (x)
        {
            case 1:
                dia = "Domingo";
                break;
            case 2:
                dia = "Segunda";
                break;
            default:
                dia = "Valor inválido!";
                break;
        }
        Console.WriteLine("Dia: " + dia);

        /*
         * A expressão condicional ternária obedece a seguinte sintaxe:
         * 
         * (condição) ? valor_se_verdadeiro : valor_se_falso
         */
        string teste = (x == 1 || x == 2) ? "Dia da semana" : "Dia inválido!";

        Console.WriteLine(teste);
    }
}