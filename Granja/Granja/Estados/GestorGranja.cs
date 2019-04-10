using Granja.Bussines;
using Granja.Model;
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
            if(animalesBussines.getAnimal() != null)
            {
                animalesBussines.modificarAnimal(animalesBussines.getAnimal().descansar());                
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
            return animalesBussines.getAnimal();
        }
        public List<clsAbsAnimal> buscarAnimales()
        {
            return animalesBussines.getAnimales();
        }
    }
}
