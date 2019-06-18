using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projPilha1_Transporte_nTktTna
{
    class Viagens
    {

        public List<Viagem> viagens;


        public Viagens()
        {
            this.viagens = new List<Viagem>();
        }


        public bool incluir(Viagem viagem)
        {
            this.viagens.Add(viagem);
            return true;
        }

    }
}