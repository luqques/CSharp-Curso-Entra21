using System;

namespace Projeto4
{
    class Projeto4
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota do aluno: ");

            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota >= 60)
            {
                Console.WriteLine("O aluno passou de ano!");
            }
            else
            {
                Console.WriteLine("O aluno reprovou!");
            }
        }
    }
}