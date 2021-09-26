using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            TaxaManutencao = 0.05M;
        }

        public decimal TaxaManutencao { get; private set; }
    }
}
