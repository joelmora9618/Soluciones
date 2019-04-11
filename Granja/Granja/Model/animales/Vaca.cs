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
        }

        public Vaca()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }

        public override clsAbsAnimal alimentar()
        {
            Hambre = DisminuirHambre(Hambre, 23);
            return this;
        }

        public override clsAbsAnimal jugar()
        {
            if (puedeJugar())
            {
                Energia = DisminuirEnergia(Energia,15);
                Hambre = AumentarHambre(Hambre,20);
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
