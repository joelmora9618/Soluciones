﻿using Granja.Model.animales;
using Granja.Operaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Model
{
    public abstract class clsAbsAnimal
    {
        protected static int RECUPERACION_MAXIMA = 100;
        protected static int RECUPERACION_MINIMA = 0;
        protected int hambre = 0;
        protected int energia = 100;
        protected TipoAnimal tipoAnimal = new TipoAnimal();

        public abstract String Nombre { get; set; }
        public TipoAnimal Tipo { get => tipoAnimal; set => tipoAnimal = value; }
        public int Hambre { get => hambre; set => hambre = value; }
        public int Energia { get => energia; set => energia = value; }

        public abstract clsAbsAnimal alimentar();
        public abstract bool puedeJugar();
        public abstract clsAbsAnimal jugar();

        public clsAbsAnimal descansar()
        {
            energia = RECUPERACION_MAXIMA;
            AumentarHambre(35);
            return this;
        }

        protected void AumentarHambre(int hambre)
        {
            Unarios.aumentar(Hambre,hambre, RECUPERACION_MAXIMA);
        }

        protected void DisminuirHambre(int hambre)
        {
            Unarios.disminuir(Hambre,hambre, RECUPERACION_MINIMA);
        }

        protected void AumentarEnergia(int energia)
        {
            Unarios.aumentar(Energia,energia, RECUPERACION_MAXIMA);
        }

        protected void DisminuirEnergia(int energia)
        {
            Unarios.disminuir(Energia,energia, RECUPERACION_MINIMA);
        }

        public int getEspecie(string especie)
        {
            int codigo = 0;
            if (especie.Equals("caballo"))
            {
                codigo = 1;
            }else if (especie.Equals("gallina"))
            {
                codigo = 2;
            }else if (especie.Equals("vaca"))
            {
                codigo = 3;
            }
            return codigo;
        }

        public clsAbsAnimal getEspecie(clsAbsAnimal animal, int codigoEspecie)
        {
            clsAbsAnimal animalDefinido = null;
            switch (codigoEspecie)
            {
                case 1:
                    animalDefinido = new Caballo(animal);
                    break;
                case 2:
                    animalDefinido = new Gallina(animal);
                    break;
                case 3:
                    animalDefinido = new Vaca(animal);
                    break;
                default:
                    animalDefinido = new Desconocido(animal);
                    break;
            }
            return animalDefinido;
        }

    }
}
