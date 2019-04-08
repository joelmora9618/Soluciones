using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model
{
    public class Vaca : clsAbsAnimal
    {
        private String nombre;

        public Vaca(clsAbsAnimal animal)
        {
            this.Hambre = animal.Hambre;
            this.Energia = animal.Energia;
            this.nombre = animal.Nombre;
            this.tipo = animal.Tipo;
        }

        public Vaca()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }

        public override clsAbsAnimal alimentar()
        {
            DisminuirHambre(23);
            return this;
        }

        public override clsAbsAnimal jugar()
        {
            if (puedeJugar())
            {
                DisminuirEnergia(15);
                AumentarHambre(20);
            }
            else
            {
                Console.WriteLine("\nEl animal no puede jugar\n");
            }
            return this;
        }

        public override bool puedeJugar()
        {
            if (Energia >= 30 && Hambre <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
      
}
