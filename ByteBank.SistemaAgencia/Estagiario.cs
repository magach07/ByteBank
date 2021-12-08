using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia {
    public class Estagiario : Funcionario{

        public Estagiario (string nome, string cpf, double salario) : base (nome, cpf, salario) {

        }
        public override void AumentarSalario() {
            throw new NotImplementedException();
        }

        protected override void GetBonificacao() {
            throw new NotImplementedException ();
        }
    }
}
