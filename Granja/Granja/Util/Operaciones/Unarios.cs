using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Operaciones
{
    public class Unarios
    {
        public static int aumentar(int value, int cantidad, int limite)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (value <= limite)
                {
                    value++;
                }
                else
                {
                    return value;
                }
            }
            return value;
        }
        public static int disminuir(int value, int cantidad, int limite)
        {
            for (int i = 0; i < cantidad; i++)
             {
                if (value > limite)
                {
                    value--;
                }
                else
                {
                    return value;
                }
            }
            return value;
        }
    }
}
