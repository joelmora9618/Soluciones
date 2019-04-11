using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model
{
    public class Gallina : clsAbsAnimal
    {
        private String nombre;

        public Gallina(clsAbsAnimal animal)
        {
            this.Hambre = animal.Hambre;
            this.Energia = animal.Energia;
            this.nombre = animal.Nombre;
        }

        public Gallina()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }

        public override clsAbsAnimal alimentar() {
            Hambre = DisminuirHambre(Hambre, 30);
            return this;
        }

        public override clsAbsAnimal jugar()
        {
            if (puedeJugar())
            {
                Random random = new Random();
                Energia = DisminuirEnergia(Energia,random.Next(20, 50));
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
            if (Energia >= 20 && Hambre <= 40)
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
