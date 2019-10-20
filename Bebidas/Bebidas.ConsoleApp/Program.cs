using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bebidas.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* Loja de Bebidas********");
            Console.WriteLine("Bem Vindos a Loja");
            List<string> listaClientes = new List<string>();


            for (int i = 0; i < 3; i++)
            {
                string nc = CadastrarCliente();
                listaClientes.Add(nc);
            }
           // Como fazer por ordem albatica, listaClientes = listaClientes.OrderBy(i => i).ToList();
            foreach(string item in listaClientes)

            Console.WriteLine($" Nome: {item}!");
            //Para comentar varias linhas e selecionarn juntos clicar Ctrl +K+C  e desfazer Ctrl+K+U..
           
            Console.ReadKey();
        }
        static string CadastrarCliente()
        {
            Console.Write("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = $"{ nome } { sobrenome}";

            return nomeCompleto;
        
        }
    }
}
