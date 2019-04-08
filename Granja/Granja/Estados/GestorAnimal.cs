using Granja.Model;
using System;

namespace Granja.Estados
{
    class GestorAnimal
    {
        public static clsAbsAnimal validarTipoAnimal(String nombre)
        {
            clsAbsAnimal animal = null;
            if (nombre.Equals("caballo")){
                animal = new Caballo();

            } else if (nombre.Equals("gallina")){
                animal = new Gallina();

            }else if (nombre.Equals("vaca"))
            {
                animal = new Vaca();
            }

            return animal;
        }
    }
}
