using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model.animales
{
    class Desconocido : clsAbsAnimal
    {
        private string nombre;

        public Desconocido(clsAbsAnimal animal)
        {
            this.Hambre = animal.Hambre;
            this.Energia = animal.Energia;
            this.nombre = animal.Nombre;
        }

        public Desconocido()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }

        public override clsAbsAnimal alimentar()
        {
            return this;
        }

        public override clsAbsAnimal jugar()
        {
            return this;
        }

        public override bool puedeJugar()
        {
            return false;
        }
    }
}

