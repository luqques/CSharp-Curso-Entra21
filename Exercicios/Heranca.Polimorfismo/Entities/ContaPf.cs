using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Polimorfismo.Entities
{
    public class ContaPf : Conta
    {
        public string Cpf { get; set; }

        public ContaPf() { }

        public ContaPf(string nome, double saldo, string cpf) 
            : base(nome, saldo)
        {
            Cpf = cpf;
        }
    }
}
