using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public abstract class ContaBancaria
    {
        public ContaBancaria(Cliente cliente)
        {
            Random random = new Random();
            NumeroConta = random.Next(20000,99999);
            DigitoVerificador = random.Next(0, 9);

            Situacao = SituacaoConta.Criada;
            Cliente = cliente ?? throw new Exception("Cliente dever ser informado!");
        }
        public void AbrirConta(string senha)
        {
            ValidaSenha(senha);//Seta e valida a senha.

            Situacao = SituacaoConta.Aberta;
            DataAbertura = DateTime.Now;
        }
        public void ValidaSenha(string senha)
        {
            senha = senha.ValidaStringVazia();
            if (!Regex.IsMatch(senha, @"^(?=.*?[a-z])(?=.*?[0-9]).{8,}$"))//Valisa se senha tem no minimo 8 caracteres, uma letra e um numero
            {
                throw new Exception("Senha Inválida!");
            }
        }

        public int NumeroConta { get; init; }//init = só pode setar o valor na inicializacao
        public int DigitoVerificador { get; init; }
        public decimal Saldo { get; protected set; }
        public DateTime? DataAbertura { get; private set; }// ? serve para permiitr o campo nulo
        public DateTime? DataEncerramento { get; private set; }
        public SituacaoConta Situacao{ get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; init; }



    }
}
