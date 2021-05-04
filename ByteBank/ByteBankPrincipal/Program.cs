using System;

namespace ByteBankPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cliente joao = new Cliente();
            Cliente maria = new Cliente();

            ContaCorrente contaJoao = new ContaCorrente(joao, 007, 19854, 700);
            ContaCorrente contaMaria = new ContaCorrente(maria, 007, 642543, 820);
            
            Console.WriteLine(contaJoao.NumeroAgencia);


            contaJoao.Sacar(15);
            contaJoao.Depositar(99);

            Console.WriteLine("\n");

            contaJoao.Tranferir(70, contaMaria);

            Console.WriteLine("\n");


            Cliente nick = new Cliente();
            nick.Nome = "Super Nick";
            nick.Cpf = "123-456-789.98";
            nick.Profissao = "Jogador";


            Cliente superNick = new Cliente();
            ContaCorrente contaNick = new ContaCorrente(superNick, 007, 9429642, 740);
            contaNick.Titular = nick;

            Console.WriteLine(nick); // Retorna o _nome da classe (caminho)
            Console.WriteLine(contaNick.Titular); // Retorna o _nome da classe (caminho)
            Console.WriteLine(nick.Nome); // Retorna o _nome declarado
            Console.WriteLine(contaNick.titular.Nome); // Retorna o valro declarado
            Console.WriteLine(contaNick.titular.Cpf); // Retorna o valro declarado

            Console.WriteLine("\nNúmero total de contas criadas: " + ContaCorrente.TotalContas);


        }
    }
}
