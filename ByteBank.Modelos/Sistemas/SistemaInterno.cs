using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;

namespace ByteBank.Modelos.Sistemas {
    public class SistemaInterno {
        public bool Logar (IAutenticavel funcionario, string senha) {
            bool funcionarioAutenticado = funcionario.Autenticar(senha);

            if (funcionarioAutenticado)
            {
                Console.WriteLine("Seja bem-vindo");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha incorretos");
                return false;
            }
        }
    }
}
