using Granja.Datos.Repositories;
using Granja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Bussines
{
    class AnimalesBussines
    {
        private CreatorRepositoryAnimal repositoryAnimal;

        public AnimalesBussines()
        {
            repositoryAnimal = new CreatorRepositoryAnimal();
            repositoryAnimal.consultarFile();
        }

        public void consultarDB()
        {
            repositoryAnimal.consultarBD();
        }

        public void consultarFile()
        {
            repositoryAnimal.consultarFile();
        }

        public clsAbsAnimal getAnimal()
        {
            clsAbsAnimal animal = repositoryAnimal._repositoryAnimal.getAnimal();
            if (animal != null)
            {
                return animal;
            }
            else
            {
                Console.Write("no se ah encontrado el animal");
                return null;
            } 
            
        }

        public List<clsAbsAnimal> getAnimales()
        {
            return repositoryAnimal._repositoryAnimal.getAnimals();
        }

        public void insertAnimal()
        {
            repositoryAnimal._repositoryAnimal.insertAnimal();
        }

        public void modificarAnimal(clsAbsAnimal animal)
        {
            repositoryAnimal._repositoryAnimal.ModificarAnimal(animal);
        }
    }
}
