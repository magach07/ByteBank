using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main (string[] args)
        {
           

            SistemaInterno sis = new SistemaInterno();
            Desenvolvedor dev = new Desenvolvedor("Jonathan Magacho", "111.222.333-44", "string");

            sis.Logar(dev, "string");

            ContaCorrente cc = new ContaCorrente(5248895, 248, 5000);
        }
    }
}