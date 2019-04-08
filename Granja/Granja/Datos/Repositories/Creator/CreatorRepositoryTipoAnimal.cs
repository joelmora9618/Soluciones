using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Datos.Repositories.Creator
{
    class CreatorRepositoryTipoAnimal
    {
        private IntTipoAnimalRepository _tipoAnimalRepository { get; set; }

        public CreatorRepositoryTipoAnimal()
        {
            _tipoAnimalRepository = new TipoAnimalRepositoryFile();
        }

        public void consultarBD()
        {
            _tipoAnimalRepository = new TipoAnimalRepositoryBD();
        }
        public void consultarFile()
        {
            _tipoAnimalRepository = new TipoAnimalRepositoryFile();
        }
    }
}
