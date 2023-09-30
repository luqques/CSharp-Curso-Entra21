using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    internal class Aluno
    {
        public string nome;
        public int idade;

        public void dizerOi()
        {
            Console.WriteLine($"{nome} disse oi");
        }
    }
}
