using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Movimentacao
    {
        public string Descricao { get; set; }
        public ContaCorrente Valor { get; set; }
        enum Tipos { credito=0, debito=1}

        public Movimentacao(string descricao)
        {
            Descricao = descricao;
        }

        public Movimentacao(string descricao,ContaCorrente c)
        {
            Descricao = descricao;
            Valor = c;
        }

    }
}
