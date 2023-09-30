using System;

namespace Projeto2
{
    class Projeto2
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a idade do usuário: ");

            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Usuário é maior de idade.");
            }
            else
            {
                Console.WriteLine("Usuário é menor de idade.");
            }
        }
    }
}