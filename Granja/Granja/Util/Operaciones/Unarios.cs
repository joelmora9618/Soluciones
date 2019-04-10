using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Operaciones
{
    public class Unarios
    {
        public static void aumentar(int value, int cantidad, int limite)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (value <= limite)
                {
                    value++;
                }
                else
                {
                    break;
                }
            }
        }
        public static void disminuir(int value, int cantidad, int limite)
        {
            for (int i = 0; i < cantidad; i++)
             {
                if (value >= limite)
                {
                    value--;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
