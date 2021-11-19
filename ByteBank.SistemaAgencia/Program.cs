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
            Desenvolvedor dev = new Desenvolvedor("Jonathan Magacho", "364.131.098-90");

            dev.Senha = "senha";

            Console.WriteLine(dev.Autenticar("senha"));
            Console.WriteLine(sis.Logar(dev, "senha"));
        }
    }
}