using Granja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Datos.Repositories
{
    interface IntAnimalRepository
    {
        void insertAnimal();

        void deleteAnimal();

        void ModificarAnimal(clsAbsAnimal animal);

        List<clsAbsAnimal> getAnimals();

        clsAbsAnimal getAnimal();

    }
}
