using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilha1_Transporte_nTktTna
{
    class Veiculos
    {
        public List<Veiculo> veiculos;


        public Veiculos()
        {
            this.veiculos = new List<Veiculo>();
        }


        public void incluir(Veiculo veiculo) {
            this.veiculos.Add(veiculo);
        }

    }
}
