using LINQ.LINQ_Lambda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.LINQ_Lambda
{
    internal class ProgramOld
    {
        static void Print<T> (string message, IEnumerable<T> collection)
        {
            Console.WriteLine (message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(String[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };
            Category c4 = new Category() { Id = 4, Name = "Category Test", Tier = 1 };

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 },
                new Product() { Id = 12, Name = "Test Product", Price = 300.0, Category = c4 }
            };

            /* Criação uma nova lista filtrada da lista principal */
            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("TIER 1 AND PRICE < 900:", r1);

            /* Criação de uma nova lista filtrada da lista principal retornando apenas o atributo Name do objeto */
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            /* Forma de retornar apenas 3 atributos do objeto Product por meio de um objeto anônimo */
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            /* Ordenando a consulta primeiramente pelo preço e segundamente pelo nome */
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            /*
             * A consulta abaixo está pulando os dois primeiros elementos e retornando os próximos 4 elementos da
             * fonte de dados, a partir do terceiro elemento. Portando em uma lista do tipo [ 1, 2, 3, 4, 5, 6, 7]
             * o retorno da consulta seria [3, 4, 5, 6]
             * 
             * É um recurso muito utilizado para fazer a paginação de tabelas, por exemplo
             */
            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            /* A função abaixo retorna o primeiro ou nulo da lista em questão */
            var r6 = products.FirstOrDefault();
            Console.WriteLine("First or default test1: " + r6);
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or default test2: " + r7);
            Console.WriteLine();

            /*
             * A função abaixo retorna um elemento ou nulo da lista em questão, geralmente utilizado em casos
             * em que temos a certeza que será retornado apenas um elemento ou nenhum, como a consulta por ID
             * em bases de dados
             */
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);
            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            /*
             * A função Max retorna o valor máximo a partir de uma função de comparação (implemente o Icomparable) 
             * 
             * No exemplo abaixo está retornando o valor máximo com o atributo Price (double) como parâmetro
             */
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10);

            /* O mesmo que a função Max, porém retorna o valor Mínimo */
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11);

            /* Retorna a soma do parâmetro inserido na função */
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum prices: " + r12);

            /* Retorna a média de valores a partir do parâmetro inserido na função */
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13);

            /*
             * O exemplo é uma tratativa para driblar a exceção para o caso de uma lista nula usando Average.
             * 
             * Basicamente, a consulta abaixo retorna apenas o preço de uma consulta nula e o método DefaultifEmpty
             * é responsável por tratar a nulidade da lista, portanto se a lista for nula, o DefaultifEmpty retornará
             * zero e o Average não irá ativar a exceção
             */
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 Average prices: " + r14);

            /*
             * O método Aggregate, por sua vez, seria a forma personalizada de fazer uma função dentro de uma
             * consulta específica, ele recebe uma Func personalizada, o caso abaixo recebe dois objetos de tipo T
             * e realiza a soma deles de forma similar a função Sum
             */
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);

            /*
             * O exemplo abaixo é a função Aggregate sem o parâmetro default. Caso a lista em que o Aggregate seja
             * chamado seja nula, o mesmo deve ter um parâmetro default para corrigir a exceção que será gerada
             */
            //var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate sum: " + r15);
            Console.WriteLine();

            /*
             * A função abaixo realiza um agrupamento a partir de um parâmetro específico, o exemplo abaixo está
             * retornando cada elemento agrupando eles por categorias. Esse retorno é um objeto IEnumerable que 
             * tem como elementos vários IGrouping chave/valor, isto é, dentro de cada elemento do IEnumerable
             * você tem uma chave (Categoria) e os valores relacionados a ela (Produtos que foram agrupados por
             * esta categoria)
             */
            var r16 = products.GroupBy(p => p.Category).OrderBy(p => p.Key.Tier);

            /*
             * Portanto para varrer todos os elementos e exibí-los de acordo, deve-se realizar dois foreach:
             * 
             * O primeiro irá varrer o IEnumerable para termos os IGrouping.
             * 
             * O segundo foreach será para exibir cada objeto ou valor presente nesse agrupamento
             */
            Print("Teste", r16);
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
