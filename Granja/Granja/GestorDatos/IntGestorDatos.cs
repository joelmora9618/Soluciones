using Granja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.GestorDatos
{
    interface IntGestorDatos
    {
        void IngresarAnimal(string path);
        List<clsAbsAnimal> GetAnimales(string path);
        clsAbsAnimal GetAnimal(string path);
        void ModificarAnimal(clsAbsAnimal animal, string path);
    }
}
