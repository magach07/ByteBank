using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.Modelos.Sistemas;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main (string[] args)
        {
            string url = "https://www.bytebank.com.br/cambio&moedaorigem=real&moedadestino=dolar";
            string nome = "Jonathan Magacho Demetrio";

            int primeiro = nome.IndexOf("Jonatha");
            int segundo = nome.IndexOf("Magac");
            Console.WriteLine("Pimeiro: " + primeiro + "\nSegundo: " + segundo);
            Console.WriteLine(nome.Remove(primeiro, segundo + 1));
            Console.WriteLine("agacho Demetrio");

            //StartsWith
            //EndsWith
            //Contains

            /*Console.WriteLine(url);

            string argumento = "moedaorigem";
            int index = url.IndexOf("moedaorigem");
            int tamanho = argumento.Length;

            string result = url.Substring(index, tamanho);

            Console.WriteLine(index);

            Console.WriteLine("tamanho: " + tamanho);

            Console.WriteLine(url.IndexOf("moedaorigem"));

            Console.WriteLine(result);*/
        }
    }
}