using System;
using System.Collections.Generic;
using System.Text;

namespace Banco
{
    class Pessoa
    {
        public string Nome { get; set; }
        public Conta Money { get; set; }
        	
	public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, Conta c)
        {
            Nome = nome;
            Money = c;
        }
    }
}
