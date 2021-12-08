using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios
{
    public abstract class Funcionario {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public static int TotalFuncionarios { get; private set; }

        public Funcionario (string nome, string cpf, double salario) {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
                
            TotalFuncionarios++;
        }

        public abstract void AumentarSalario();

        internal protected abstract void GetBonificacao();
    }
}
