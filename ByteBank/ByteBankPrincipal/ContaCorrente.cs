using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankPrincipal
{
    public class ContaCorrente {

        public Cliente titular;
        public int numeroAgencia = 007;
        public int numeroConta;
        public double saldo = 100;
        private static int _totalContas = 0;

        public ContaCorrente(Cliente titular, int numeroAgencia, int numeroConta, double saldo)
        {
            this.titular = titular;
            this.numeroAgencia = numeroAgencia;
            this.numeroConta = numeroConta;
            this.saldo = saldo;

            TotalContas++;
        }

        public double Saldo { get => saldo; set => saldo = value; }
        public Cliente Titular { get => titular; set => titular = value; }
        public int NumeroAgencia { get => numeroAgencia; set => numeroAgencia = value; }
        public int NumeroConta { get => numeroConta; set => numeroConta = value; }
        public static int TotalContas { get => _totalContas; set => _totalContas = value; }

        public void Sacar(double valor) {

            if (valor <= Saldo) {
                this.Saldo -= valor;
                Console.WriteLine("Iniciando solicitação de saque...");
                Console.WriteLine("Saque efetuado com sucesso \nSeu novo saldo é de R$" + Saldo);

            }
            else {
                Console.WriteLine("Solicitação Invalida \nTenta de novo aí");
            }
        }

        public void Depositar(double valor) {

            if (valor >= 0) {
                this.Saldo += valor;
                Console.WriteLine("Deposito realizado com sucesso.");
            }
        }

        public bool Tranferir(double valor, ContaCorrente contaDestino) {

            if (this.Saldo < valor) {
                Console.WriteLine("Transferencia negada, saldo insuficiente.");
                return false;
            }
            else {
                Console.WriteLine("Tranferencia aceita!");
                this.Saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }


        }

    }


}
