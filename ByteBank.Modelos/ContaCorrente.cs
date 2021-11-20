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

        public ContaCorrente (int numero, int agencia, double saldo)
        {
            if (numero == 0)
            {
                throw new ArgumentException("Valor nao pode ser igual a 0", nameof(numero));
            }
            if (agencia == 0)
            {
                throw new ArgumentException("Valor nao pode ser igual a 0", nameof(agencia));
            }

            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
        }


        public void Sacar (double valorSaque)
        {
            if (valorSaque <= 0)
            {
                throw new ArgumentException("Valor do saque nao pode ser menor ou igual a 0", nameof(valorSaque));
            }

            if (valorSaque > Saldo)
            {
                //Contador de saques nao permitidos
                throw new SaldoInsuficienteException(Saldo, valorSaque);
            }

            Saldo -= valorSaque;
        }

        public void Depositar (double valorDeposito)
        {
            if (valorDeposito <= 0)
            {
                throw new ArgumentException("Valor do deposito nao pode ser menor ou igual a 0", nameof(valorDeposito));
            }

            Saldo += valorDeposito;
        }

        public void Transferir (ContaCorrente destinatario, double valorTrasferencia)
        {
            Sacar (valorTrasferencia);

            destinatario.Saldo += valorTrasferencia;
        }
    }
}
