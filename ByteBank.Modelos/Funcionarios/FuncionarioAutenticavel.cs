using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;

namespace ByteBank.Modelos.Funcionarios {
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel {

        public string Senha { get; set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario) : base(nome, cpf, salario) {

        }
        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
