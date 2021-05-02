using System;

namespace ByteBankPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            ContaCorrente joao = new ContaCorrente();
            joao.saldo = 10;

            Console.WriteLine(joao.saldo);
            Console.WriteLine(joao.numeroConta);
        }
    }
}
