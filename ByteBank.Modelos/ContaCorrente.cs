using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public int Agencia { get; set;}
        public double Saldo { get; set; }

        public Cliente Titular { get; set; }
        public static int taxaOperacao;
        public static int totalContas;

        public ContaCorrente (int numero, int agencia)
        {
            Numero = numero;
            Agencia = agencia;
        }


        public void Sacar (double valorSaque)
        {
            if (valorSaque > Saldo)
            {
                Console.WriteLine("Impossivel sacar R$" + valorSaque + " em uma conta com R$" + Saldo + " de saldo");
            }

            Saldo -= valorSaque;
        }

        public void Depositar (double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Transferir (ContaCorrente destinatario, double valorTrasferencia)
        {
            Sacar (valorTrasferencia);

            destinatario.Saldo += valorTrasferencia;
        }
    }
}
