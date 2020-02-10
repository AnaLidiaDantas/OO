using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Banco
    {
        private List<ContaCorrente> contasCorrente;
        //public int numeroDeContas;

        public Banco()
        {
            contasCorrente = new List<ContaCorrente>();
        }
        public void criarConta(Movimentacao novaConta) {
            contasCorrente.Add(novaConta.Valor);
        }

        public void depositarValorNaConta(Movimentacao movimentacao, decimal valor)
        {
            for (int i = 0; i< contasCorrente.Count; i++)
            {
                if (contasCorrente[i].Numero == movimentacao.Valor.Numero)
                {
                    contasCorrente[i].Saldo += valor;
                }
            }
        }

        public void sacarValorDaConta(Movimentacao movimentacao, decimal valor)
        {
            for (int i = 0; i < contasCorrente.Count; i++)
            {
                if (contasCorrente[i].Numero == movimentacao.Valor.Numero)
                {
                    contasCorrente[i].Saldo -= valor;
                }
            }
        }
    }
}
