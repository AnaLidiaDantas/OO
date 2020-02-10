using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
   class Banco
    {
        private List<Conta> contas;

        public Banco()
        {
            contas = new List<Conta>();
        }

        public void CriarConta(Pessoa p)
        {
            contas.Add(p.Money);
        }

        public void depositarValorNaConta(Pessoa pessoa, double valor)
        {
            for(int i = 0; i < contas.Count; i++)
            {
                if (contas[i].ID == pessoa.Money.ID)
                {
                    contas[i].Valor += valor;
                }
            }
        }

        public void sacarValorDaConta(Pessoa pessoa, double valor)
        {
            for(int i = 0; i < contas.Count; i++)
            {
                if (contas[i].ID == pessoa.Money.ID)
                {
                    contas[i].Valor -= valor;
                }
            }
        }

        public double Saldo(Pessoa p)
        {
            double saldo=0.0;
            for(int i=0;i<contas.Count; i++)
            {
                if (contas[i].ID == p.Money.ID)
                {
                    saldo = contas[i].Valor;
                }
            }
            return saldo;
        }
    }
}
