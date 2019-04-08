using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Granja.Archivos;
using Granja.GestorDatos;
using Granja.Model;

namespace Granja.Datos.Repositories
{
    class AnimalRepositoryFile : IntAnimalRepository
    {
        private IntGestorDatos intGestorDatos;

        public AnimalRepositoryFile()
        {
            intGestorDatos = new GestorDeArchivos();
        }

        public void deleteAnimal()
        {
            throw new NotImplementedException();
        }

        public clsAbsAnimal getAnimal()
        {
            return intGestorDatos.GetAnimal(DataConection.PATH_FILE_DATA);
        }

        public List<clsAbsAnimal> getAnimals()
        {
            return intGestorDatos.GetAnimales(DataConection.PATH_FILE_DATA);
        }

        public void insertAnimal()
        {
            intGestorDatos.IngresarAnimal(DataConection.PATH_FILE_DATA);
        }

        public void ModificarAnimal(clsAbsAnimal animal)
        {
            intGestorDatos.ModificarAnimal(animal, DataConection.PATH_FILE_DATA);
        }
    }
}
