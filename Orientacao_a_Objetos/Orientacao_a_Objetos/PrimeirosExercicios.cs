using System;
using System.Globalization;
class Pessoa
{
    private string nome;
    private int idade;
    private double salario;
    static double somaSalario = 0;
    static int contadorPessoas = 0;


    public Pessoa (string nome, int idade, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.salario = salario;

        Pessoa.somaSalario += salario;
        Pessoa.contadorPessoas++;
    }

    public static double retornaMediaSalarial()
    {
        double media = Pessoa.somaSalario / Pessoa.contadorPessoas;
        return media;
    }

    public string retornaMaisVelho(Pessoa pessoa)
    {
        if (this.idade >= pessoa.idade)
        {
            return nome;
        }
        return pessoa.nome;
    }

    public override string ToString()
    {
        return 
            nome + 
            " tem " + 
            idade + 
            " anos de idade e recebe R$" 
            + salario.ToString("F2", CultureInfo.InvariantCulture);
    }
}

namespace Orientacao_a_Objetos
{
    class PrimeirosExercicios
    {
        static void Exercicio1(String[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            String nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa pessoa1 = new Pessoa(nome1, idade1, salario1);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            String nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());
            Console.Write("Salário: ");
            double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa pessoa2 = new Pessoa(nome2, idade2, salario2);

            Console.WriteLine("Pessoa mais velha: " + pessoa1.retornaMaisVelho(pessoa2));
            Console.WriteLine("Salário Médio das Pessoas: " + Pessoa.retornaMediaSalarial());

            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
        }
    }
}