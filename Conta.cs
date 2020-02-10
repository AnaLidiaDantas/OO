using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Conta
    {
        public int ID { get; set; }
        public double Valor { get; set; }
        public string numeroConta { get; set; }
        public Conta Money { get; set; }

        public Conta()
        {

        }

        public Conta (int id, double valor)
        {
            ID = id;
            Valor = valor;
        }

        public void depositarValorNaConta(double valor)
        {
            Valor += valor;
        }
    }
}
