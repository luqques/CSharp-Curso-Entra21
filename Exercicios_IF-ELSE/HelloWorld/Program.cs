using System;

namespace NomeDoNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            double numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double numero2 = int.Parse(Console.ReadLine());

            double soma = numero1 + numero2;
            double divisao = numero1 / numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;;

            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine("A divisão é: " + Convert.ToString(divisao));
            Console.WriteLine($"A subtração é: {subtracao}");
            Console.WriteLine($"A multiplicação é: {multiplicacao}");
        }
    }
}
