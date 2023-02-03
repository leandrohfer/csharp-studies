using System;
using System.Collections.Generic;
using System.Globalization;

namespace Orientacao_a_Objetos
{
    class Empregado
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Empregado (int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AumentoSalario(double porcentagem)
        {
            Salario += Salario * (porcentagem/100);
        }
    }
    internal class ExercicioFixacaoListas
    {
        static void Teste(String[] args)
        {
            Console.Write("Quantos empregados serão registrados: ");
            int n = int.Parse(Console.ReadLine());

            List<Empregado> lista = new List<Empregado>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nEmpregado #" + (i + 1) + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Empregado (id, nome, salario));
            }

            Console.Write("\nDigite o ID do funcionário que receberá aumento: ");
            int id2 = int.Parse(Console.ReadLine());

            Empregado teste = null;
            foreach (Empregado obj in lista)
            {
                if (obj.Id == id2) teste = obj;
            }

            if (teste != null)
            {
                Console.Write("Entre com a porcentagem de aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                teste.AumentoSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Este ID de funcionário não existe!");
            }


            Console.WriteLine("\nLista atulizada de Empregados: ");
            foreach (Empregado obj in lista)
            {
                Console.WriteLine($"{obj.Id}, {obj.Nome}, {obj.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
