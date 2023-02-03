using System;
using System.Collections.Generic;

namespace Orientacao_a_Objetos
{
    internal class OperacoesComListas
    {
        static void Teste(String[] args)
        {
            /*
             * Forma de se declarar e instanciar uma lista definindo o tipo dela.
             */
            List<string> list = new List<string>() { "Alex", "Leandro"};

            /*
             * O método Add() adiciona um novo elemento na última posição de uma lista.
             */
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Augusto");
            list.Add("Eugustino");
            list.Add("Victória");
            list.Add("Emerson");
            list.Add("Bob");
            list.Add("Anna");

            /*
             * O método Insert() insere um novo elemento em uma posição definida de
             * uma lista. Por exemplo, abaixo estamos inserindo um novo elemento na
             * posição 2 da lista.
             */
            list.Insert(2, "Marco");

            Console.WriteLine("Lista original:");
            int contador = 0;
            foreach (string obj in list)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }

            /*
             * O método Count retorna a quantidade de elementos, como se fosse o
             * método Lenght dos vetores.
             */
            Console.WriteLine("\nQuantidade de Elementos da Lista: " + list.Count);

            /*
             * O método Find() procura a primeira ocorrência do resultado de uma
             * função (lambda) na lista.
             * 
             * O exemplo abaixo está procurando na lista inteira a primeira ocorrência
             * em que um elemento da lista comece com a letra 'A'.
             * 
             * Também poderia chamar um outro método desta classe, ao invés desta 
             * função lambda.
             */
            string string1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("\nPrimeiro Elemento que começa com 'A': " + string1);

            /*
             * O método FindIndex() realiza praticamente o mesmo que o método Find(),
             * porém, ao invés de retornar o conteúdo do elemento, ele retorna a posição
             * deste elemento.
             */
            int posicao1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do Elemento acima: " + posicao1);

            /*
             * O método FindLast() executa o mesmo que o Find(), porém retorna a
             * última ocorrência de um método ou função lambda.
             */
            string string2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("\nÚltimo Elemento que começa com 'A': " + string2);

            /*
             * O método FindIndex() realiza praticamente o mesmo que o método FindLast(),
             * porém, ao invés de retornar o conteúdo do elemento, ele retorna a posição
             * deste elemento.
             */
            int posicao2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Posição do Elemento acima: " + posicao2);

            /*
             * O método FindAll(), por sua vez, retorna uma nova lista parametrizada a 
             * partir de uma função lambda ou método.
             * 
             * O exemplo abaixo está criando uma nova lista, a partir da lista antiga,
             * que contém apenas os elementos desta lista que contenham mais que 5 
             * caracteres.
             * 
             * É como se fosse a criação de uma nova lista, a partir de um filtro exe-
             * cutado em outra lista.
             */
            List<string> list2 = list.FindAll(x => x.Length >= 5);

            Console.WriteLine("\n########################################\n\nNova Lista criada: ");
            contador = 0;
            foreach (string obj in list2)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }

            /*
             * O método Remove() remove o primeiro elemento que corresponda exatamente ao que
             * foi descrito no parâmetro do método. 
             * 
             * O exemplo abaixo está removendo da lista o primeiro elemento que tem como valor 
             * exatamente a palavra "Alex".
             */
            list.Remove("Alex");

            Console.WriteLine("\n\nApós excluir o elemento Alex com remove(): ");
            contador = 0;
            foreach (string obj in list)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }

            /*
             * O método RemoveAll() remove todos os elementos que atendam aos requisitos definidos
             * no método ou função lambda no parâmetro do RemoveAll().
             * 
             * Logo, o exemplo abaixo está removendo da lista TODOS os elementos que iniciam com o 
             * caractere 'M'.
             */
            list.RemoveAll(x => x[0] == 'M');

            Console.WriteLine("\n\nApós excluir todos os elementos que começam com M: ");
            contador = 0;
            foreach (string obj in list)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }

            /*
             * O método RemoveAt() remove o elemento que está no índice indicado no parâmetro.
             * 
             * O exemplo abaixo está removendo o elemento da lista que está na posição 1.
             */
            list.RemoveAt(1);

            Console.WriteLine("\n\nApós excluir o elemento na posição 1: ");
            contador = 0;
            foreach (string obj in list)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }

            /*
             * O método RemoveRange() remove os elementos a partir de uma faixa indicada nos parâmetros
             * do método.
             * 
             * O exemplo abaixo está removendo 2 elementos a partir do elemento localizado na posição 3.
             */
            list.RemoveRange(3, 2);

            Console.WriteLine("\n\nApós excluir o elemento na posição 3 e o próximo elemento a partir dele: ");
            contador = 0;
            foreach (string obj in list)
            {
                Console.WriteLine(contador + " " + obj);
                contador++;
            }
        }
    }
}
