using System;
using System.Globalization;

namespace Orientacao_a_Objetos
{
    class Triangulo
    {
        private double largura;
        private double altura;

        public Triangulo (double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double Area()
        {
            double area = largura * altura;
            return area;
        }
        public double Perimetro()
        {
            double perimetro = 2 * (largura + altura);
            return perimetro;
        }
        public double Diagonal()
        {
            double diagonal = Math.Sqrt(largura * largura + altura * altura);
            return diagonal;
        }
    }

    class Funcionario
    {
        private string Nome;
        private double SalarioBruto;
        private double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido()
        {
            double Liquido = this.SalarioBruto - this.Imposto;
            return Liquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            double NovoSalario = this.SalarioBruto + (this.SalarioBruto * (porcentagem/100.0));
            this.SalarioBruto = NovoSalario;
        }

        public override string ToString()
        {
            return 
                "Funcionário: "
                + Nome +
                ", $ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    class ExerciciosFixacao
    {
        static void Exercicios2(String[] args)
        {
            int exercicio = 2;

            if (exercicio == 1)
            {
                // Para o exercício 1 foi utilizado a classe Triângulo
                Console.WriteLine("Entre com a altura e a largura do triângulo:");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Triangulo triangulo = new Triangulo(altura, largura);

                Console.WriteLine("AREA = " + triangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("PERÍMETRO = " + triangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("DIAGONAL = " + triangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (exercicio == 2)
            {
                // Para o exercício 2 foi utilizado a classe Funcionario
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Imposto: ");
                double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario(nome, salario, imposto);
                Console.WriteLine(funcionario);

                Console.Write("\nDigite a porcentagem para aumentar o salário: ");
                funcionario.AumentarSalario(double.Parse(Console.ReadLine()));

                Console.WriteLine("\n"+funcionario);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        
    }
}