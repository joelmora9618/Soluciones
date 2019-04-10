using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model
{
    public class TipoAnimal
    {
        public TipoAnimal()
        {

        }

        public TipoAnimal(int codigoTipoAnimal, string nombreTipo)
        {
            this.CodigoTipoAnimal = codigoTipoAnimal;
            this.NombreTipo = nombreTipo;
        }

        public int CodigoTipoAnimal { get; set; }

        public string NombreTipo { get; set; }

    }
}
