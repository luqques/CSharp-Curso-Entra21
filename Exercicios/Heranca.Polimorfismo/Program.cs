using Heranca.Polimorfismo.Entities;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta("Lucas", 10);
            ContaPf contaPf = new ContaPf("Lucas PF", 10, "05870211956");
            ContaPj contaPj = new ContaPj("Loja LTDA", 10, "132165000165");

            // UPCASTING
            Conta conta1 = new ContaPf("Lucas", 10, "5642132654");

            conta.Saque(2);
            contaPf.Saque(2);
            contaPj.Saque(2);
            conta1.Saque(2);

            Console.WriteLine(conta);
            Console.WriteLine(contaPf);
            Console.WriteLine(contaPj);
            Console.WriteLine(conta1);

        }
    }

}