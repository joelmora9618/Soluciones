using Granja.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja
{
    class Program
    {
        static void Main(string[] args)
        {
            string value;
            int opcion;
            char continuar = 's';
            GestorGranja gestor = new GestorGranja();

            while (continuar == 's')
            {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("                                     MENU");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("1. Buscar Animal\n");
                Console.WriteLine("2. Listar Animales\n");
                Console.WriteLine("3. Agregar Animal\n");
                Console.WriteLine("4. Alimentar Animal\n");
                Console.WriteLine("5. Alimentar Animales\n");
                Console.WriteLine("6. Jugar con Animal\n");
                Console.WriteLine("7. Jugar con Animales\n");
                Console.WriteLine("8. Descansar Animal\n");
                Console.WriteLine("9. Descansar Animales\n");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("* Para salir ingrese : exit");
                Console.WriteLine("* Para limpiar la pantalla ingrese : clean");
                Console.WriteLine("----------------------------------------------------------------------------------");

                value = Console.ReadLine();

                if (value.Equals("1"))
                {
                    gestor.buscarAnimal();
                }
                else if (value.Equals("2"))
                {
                    gestor.buscarAnimales();
                }
                else if (value.Equals("3"))
                {
                    gestor.ingresarAnimal();
                }
                else if (value.Equals("4"))
                {
                    gestor.alimentarAnimal();
                }
                else if (value.Equals("5"))
                {
                    gestor.alimentarAnimales();
                }
                else if (value.Equals("6"))
                {
                    gestor.jugarConAnimal();
                }
                else if (value.Equals("7"))
                {
                    gestor.jugarConAnimales();
                }
                else if (value.Equals("8"))
                {
                    gestor.descansarAnimal();
                }
                else if (value.Equals("9"))
                {
                    gestor.descansarAnimales();
                }
                else if (value.Equals("exit"))
                {
                    continuar = 'n';
                }
                else if (value.Equals("clean"))
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nOpcion invalida!");
                    Console.Clear();
                }
             
                Console.ReadKey();
            }
        }
    }
}

