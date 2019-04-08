using Granja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Estados
{
    class clsConsultarDatosAnimal : IntEntradaDatos
    {
        public string cargarDato(string dato)
        {
            throw new NotImplementedException();
        }

        public string cargarDato()
        {
            Console.WriteLine("ingrese el nombre del animal: ");
            return Console.ReadLine();
        }

        public void cargarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
