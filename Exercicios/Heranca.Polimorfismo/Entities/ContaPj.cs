using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Polimorfismo.Entities
{
    public class ContaPj : Conta
    {
        public string Cnpj { get; set; }

        public ContaPj() { }

        public ContaPj(string nome, double saldo, string cnpj) 
            : base(nome, saldo)
        {
            Cnpj = cnpj;
        }
    }
}
