using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos {
    public class SaldoInsuficienteException : OperacaoFinanceiraException {

        public double Saldo { get; }
        public double ValorSaque { get; }

        public SaldoInsuficienteException() {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Imposivel sacar R$" + valorSaque + " numa conta com R$" + saldo + " de saldo") {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem) {
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) {
        }
    }
}
