using System;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            Pessoa a = new Pessoa("Paulo", new Conta(1, 1200.00));
            banco.CriarConta(a);

            Console.WriteLine("Pessoa: " + a.Nome + " tem " + a.Money.Valor);
            
            banco.depositarValorNaConta(a, 369.56);
            Console.WriteLine("Pessoa: " + a.Nome + " tem " + a.Money.Valor);

            banco.sacarValorDaConta(a, 1369.56);
            Console.WriteLine("Pessoa: " + a.Nome + " tem " + a.Money.Valor);
            
            Console.ReadKey();
        }
    }
}
  