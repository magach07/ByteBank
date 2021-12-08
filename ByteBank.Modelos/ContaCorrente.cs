using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma Conta Corrente no Banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        public int Numero { get; set; }
        public int Agencia { get; set;}
        public double Saldo { get; set; }

        public Cliente Titular { get; set; }
        public static int taxaOperacao;
        public static int totalContas;

        /// <summary>
        /// Recebe parametros necessários para criação da Conta Corrente.
        /// </summary>
        /// <param name="numero">Representa o parametro <see cref="Numero"/> e deve ser maior que 0.</param>
        /// <param name="agencia">Representa o parâmetro <see cref="Agencia"/> e deve ser maior que 0.</param>
        /// <param name="saldo">Representa o parâmetro <see cref="Saldo"/> e deve ser maior que 0.</param>
        /// <exception cref="ArgumentException"></exception>
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

        /// <summary>
        /// Faz o saque em uma <see cref="ContaCorrente"/> previamente instanciada.
        /// </summary>
        /// <param name="valorSaque"> Valor a ser sacado.</param>
        /// <exception cref="ArgumentException">Lançada quando o <paramref name="valorSaque"/> é menor ou igual a 0.</exception>
        /// <exception cref="SaldoInsuficienteException">Lançado quando o <paramref name="valorSaque"/> é maior que o <see cref="Saldo"/></exception>
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
