using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
   public class Endereco
    {
        public Endereco(string rua, string cep,string bairro, string cidade, string estado)
        {
            Rua = rua.ValidaStringVazia();
            CEP = cep.ValidaStringVazia();
            Bairro = bairro.ValidaStringVazia();
            Cidade = cidade.ValidaStringVazia();
            Estado = estado.ValidaStringVazia();
        }
        public string Rua { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
