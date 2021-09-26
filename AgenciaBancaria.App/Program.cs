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
                ContaCorrente conta = new ContaCorrente(cliente);
                Console.WriteLine("Conta: "+ conta.Situacao + " " + conta.NumeroConta +"-"+ conta.DigitoVerificador);
                conta.AbrirConta("12345678j");
                Console.WriteLine("Conta: " + conta.Situacao + " " + conta.NumeroConta + "-" + conta.DigitoVerificador);


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
