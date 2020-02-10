using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaCorrente
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public decimal Valor { get; set; }
        public ContaCorrente()
        {

        }
        public ContaCorrente(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }

        public void depositarValorNaConta(decimal valor)
        {
            Saldo += valor;
        }
    }
}
