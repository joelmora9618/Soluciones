using Granja.Bussines;
using Granja.Model;
using Granja.Model.animales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Estados
{
    class GestorGranja
    {
        private AnimalesBussines animalesBussines;

        public GestorGranja()
        {
            this.animalesBussines = new AnimalesBussines();
        }

        public void descansarAnimal()
        {
            clsAbsAnimal animal = animalesBussines.getAnimal();
            if (animal != null)
            {
                animalesBussines.modificarAnimal(animal.descansar());                
            }
        }
        public void descansarAnimales()
        {          
             foreach(clsAbsAnimal animal in animalesBussines.getAnimales())
            {
                animalesBussines.modificarAnimal(animal.descansar());
            }
        }
        public void alimentarAnimal()
        {
            clsAbsAnimal animal = animalesBussines.getAnimal();
            if (animal != null)
            {
                animalesBussines.modificarAnimal(animal.alimentar());
            }
        }
        public void alimentarAnimales()
        {
            foreach (clsAbsAnimal animal in animalesBussines.getAnimales())
            {
                animalesBussines.modificarAnimal(animal.alimentar());
            }
        }
        public void jugarConAnimal()
        {
            clsAbsAnimal animal = animalesBussines.getAnimal();
            if (animal != null)
            {
                animalesBussines.modificarAnimal(animal.jugar());
            }
        }
        public void jugarConAnimales()
        {
            foreach (clsAbsAnimal animal in animalesBussines.getAnimales())
            {
                animalesBussines.modificarAnimal(animal.jugar());
            }
        }
        public void ingresarAnimal()
        {
            animalesBussines.insertAnimal();
        }
        public clsAbsAnimal buscarAnimal()
        {
            clsAbsAnimal animal = animalesBussines.getAnimal();
            Console.Write("nombre: " + animal.Nombre + "\n");
            Console.Write("especie: " + animal.Tipo.NombreTipo + "\n");
            Console.Write("hambre: " + animal.Hambre + "\n");
            Console.Write("energia: " + animal.Energia + "\n");
            return animal;
        }
        public List<clsAbsAnimal> buscarAnimales()
        {
            List <clsAbsAnimal> listAnimal = animalesBussines.getAnimales();
            foreach(clsAbsAnimal animal in listAnimal)
            {
                Console.Write("nombre: " + animal.Nombre + "\n");
                Console.Write("especie: " + animal.Tipo.NombreTipo + "\n");
                Console.Write("hambre: " + animal.Hambre + "\n");
                Console.Write("energia: " + animal.Energia + "\n\n");
            }
            return listAnimal;
        }
    }
}
