using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Funcionarios {
    public class Desenvolvedor : FuncionarioAutenticavel {
     

        public Desenvolvedor(string nome, string cpf) : base(nome, cpf, 5000) {

        }

        public override void AumentarSalario() {
            Salario *= 0.20;
        }
    }
}
