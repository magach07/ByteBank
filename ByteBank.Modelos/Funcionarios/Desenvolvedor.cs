using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios {
    public class Desenvolvedor : FuncionarioAutenticavel {
     

        public Desenvolvedor(string nome, string cpf, string senha) : base(nome, cpf, 5000, senha) {

        }

        public override void AumentarSalario() {
            Salario *= 0.20;
        }

        protected internal override void GetBonificacao() {
            throw new NotImplementedException();
        }
    }
}
