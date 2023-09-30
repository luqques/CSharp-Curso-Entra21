//Pares e Ímpares: Implemente um programa que divide um vetor de inteiros em dois vetores: um contendo os números pares e outro os números ímpares.
using System;
using System.Net.NetworkInformation;
using System.Threading.Channels;

class Program
{
    static (List<int>, List<int>) RetornarListas(List<int> numeros)
    {
        List<int> pares = new List<int>();
        List<int> impares = new List<int>();

        foreach (int i in numeros)
        {
            if (i % 2 == 0)
            {
                pares.Add(i);
            }
            else
            {
                impares.Add(i);
            }
        }

        return (pares, impares);
    }

    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        while (true)
        {
            Console.Write("Digite um número para ser adicionado à lista: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 0)
            {
                numeros.Add(numero);
            }
            else
            {
                break;
            }
        }
        (List<int> pares, List<int> impares) = RetornarListas(numeros);

        Console.Write("\nPares: ");
        foreach (int i in pares)
        {
            Console.Write($"{i} ");
        }

        Console.Write("\nÍmpares: ");
        foreach (int i in impares)
        {
            Console.Write($"{i} ");
        }
    }
}