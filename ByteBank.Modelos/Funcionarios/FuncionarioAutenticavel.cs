using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Funcionarios {
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel {

        public string Senha { get; set; }

        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario) {
            Senha = senha;

        }

       AutenticacaoHelper help = new AutenticacaoHelper();

        public bool Autenticar(string senha) {
            return help.Helper(Senha, senha) ;
        }
    }
}
