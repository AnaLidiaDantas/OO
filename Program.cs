using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco contaCorrente = new Banco();

            //Criar Conta A
            Movimentacao a= new Movimentacao("A", new ContaCorrente(1, 1200));
            contaCorrente.criarConta(a);
            Console.WriteLine("Conta: " + a.Descricao + " Saldo: R$ " + a.Valor.Saldo);

            //Depositar na Conta A
            contaCorrente.depositarValorNaConta(a, 500);
            Console.WriteLine("Conta: " + a.Descricao + " Saldo: R$ " + a.Valor.Saldo);

            //Sacar da Conta A
            contaCorrente.sacarValorDaConta(a, 1000);
            Console.WriteLine("Conta: " + a.Descricao + " Saldo: R$ " + a.Valor.Saldo);

            //Criar Conta B
            Movimentacao b = new Movimentacao("B", new ContaCorrente(2, 2000));
            contaCorrente.criarConta(b);
            Console.WriteLine("Conta: " + b.Descricao + " Saldo: R$ " + b.Valor.Saldo);

            //Depositar na Conta B
            contaCorrente.depositarValorNaConta(b, 1000);
            Console.WriteLine("Conta: " + b.Descricao + " Saldo: R$ " + b.Valor.Saldo);

            //Sacar da Conta B
            contaCorrente.sacarValorDaConta(b, 500);
            Console.WriteLine("Conta: " + b.Descricao + " Saldo: R$ " + b.Valor.Saldo);

            Console.ReadKey();
        }
    }
}
