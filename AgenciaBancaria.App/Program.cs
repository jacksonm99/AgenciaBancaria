using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Aluisio de azevedo", "50100090","Santo Amaro", "Recife", "Pernambuco");
                Cliente cliente = new Cliente("Jackson", "123456", "9491845",endereco);
                Console.WriteLine(cliente.Nome);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
