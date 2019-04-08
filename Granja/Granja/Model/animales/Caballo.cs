﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model
{
    public class Caballo : clsAbsAnimal
    {
        private string nombre;

        public Caballo(clsAbsAnimal animal)
        {
            this.Hambre = animal.Hambre;
            this.Energia = animal.Energia;
            this.nombre = animal.Nombre;
            this.tipo = animal.Tipo;
        }

        public Caballo()
        {
        }

        public override string Nombre { get => nombre; set => nombre = value; }

        public override clsAbsAnimal alimentar()
        {
            Random random = new Random();
            if (random.Next(0, 100) > 50)
            {
                AumentarHambre(40);
            }
            return this;
        }

        public override clsAbsAnimal jugar()
        {
            if (puedeJugar())
            {
                DisminuirEnergia(12);
                AumentarHambre(33);
            }
            else
            {
                Console.WriteLine("\nEl animal no puede jugar\n");
            }
            return this;
        }

        public override bool puedeJugar()
        {
            if(Energia>=50 && Hambre <= 25)
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
