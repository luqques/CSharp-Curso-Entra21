using Heranca.Polimorfismo.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            ContaPj contaPj = new ContaPj("Loja LTDA", 132414.89, "132165000165");
            ContaPf contaPf = new ContaPf();

            Conta conta1 = new ContaPf("Lucas", 10.50, "5642132654");

            Console.WriteLine(conta1);
            Console.WriteLine(contaPj);
        }
    }

}