using Granja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Datos.Repositories
{
    interface IntTipoAnimalRepository
    {
        void insertTipoAnimal(TipoAnimal tipo);

        void deleteTipoAnimal();

        List<TipoAnimal> getTiposAnimal();

        TipoAnimal getTipoAnimal(string tipo);

        TipoAnimal getTipoAnimal(int codigo);
    }
}
