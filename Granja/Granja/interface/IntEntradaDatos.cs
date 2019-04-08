using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Estados
{
    interface IntEntradaDatos
    {
        void cargarDatos();
        string cargarDato(string dato);
        string cargarDato();
    }
}
