using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Datos.Repositories
{
    class CreatorRepositoryAnimal
    {
        public IntAnimalRepository _repositoryAnimal{ get; set;}

        public CreatorRepositoryAnimal()
        {
            _repositoryAnimal = new AnimalRepositoryFile();
        }

        public void consultarBD()
        {
            _repositoryAnimal = new AnimalRepositoryBD();
        }
        public void consultarFile()
        {
            _repositoryAnimal = new AnimalRepositoryFile();
        }

    }
}
