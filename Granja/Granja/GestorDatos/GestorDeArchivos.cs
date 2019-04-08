using Granja.Exception;
using Granja.GestorDatos;
using Granja.Model;
using Granja.Model.animales;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Archivos
{
    class GestorDeArchivos : IntGestorDatos
    {

        public void GuardarArchivo(string path, string contenido)
        {
            Console.Write("Tratando de guardar el archivo en " + path);
            StreamWriter writer = null;
            if (File.Exists(path))
            {
                try
                {
                    writer = new StreamWriter(path);
                    writer.WriteLine(contenido);
                }
                catch (SystemException error)
                {
                    throw new GestorDeArchivosException("Hay un error al guardar el archivo", error);
                }
                finally
                {
                    if (writer != null)
                        writer.Close();
                }
            }
            else
            {
                throw new GestorDeArchivosException("Todo ok pero no hay archivo en el path: "
                    + path);
            }
        }

        public void IngresarAnimal(string path)
        {
            clsAbsAnimal animal = new Desconocido();
            string nombre;
            string especie;
            StreamWriter Escribir = new StreamWriter(path, true);
            //INGRESA DATOS
            Console.Write("\n* Ingresar nombre: ");
            nombre = Console.ReadLine();
            Escribir.WriteLine("nombre:"+nombre);
            Console.Write("\n* Ingresar especie: ");
            especie = Console.ReadLine();
            Escribir.WriteLine("especie:"+especie);

            Escribir.WriteLine("codigo de especie:"+animal.getEspecie(especie));
            Escribir.WriteLine("hambre:" + animal.Hambre);
            Escribir.WriteLine("energia:" + animal.Energia);
            Console.WriteLine("\n\n");
            String Cadena = Console.ReadLine();
            Escribir.WriteLine(Cadena);
            Escribir.Close();

            Console.WriteLine("El registro se ha creado exitosamente.\n\n");
        }

        public List<clsAbsAnimal> GetAnimales(string path)
        {
            List<clsAbsAnimal> listaAnimales = new List<clsAbsAnimal>();
            Console.Clear();
            StreamReader Leer = new StreamReader(path, true);
            Console.WriteLine("Mostrando todos los registros:\n\n");


            string[] lineas = File.ReadAllLines(path);
            if (lineas.Length > 0)
            {
                for (int i = 0; i < lineas.Length; i++)
                {
                    clsAbsAnimal animal = new Desconocido();
                    if (lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("nombre"))
                    {
                        animal.Nombre = lineas[i].Substring(lineas[i].IndexOf(" : ") + 1, lineas[i].Length);
                    }
                    if (lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("hambre"))
                    {
                        animal.Hambre = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(" : ") + 1, lineas[i].Length));
                    }
                    if (lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("energia"))
                    {
                        animal.Energia = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(" : ") + 1, lineas[i].Length));
                    }
                    Console.WriteLine(lineas[i]);
                    listaAnimales.Add(animal);
                }

                Console.WriteLine("\nEl registro se mostro exitosamente.\n\n");
            }
            else
            {
                Console.WriteLine("\nNo Hay Datos cargados.\n\n");
            }

            return listaAnimales;
        }

        public clsAbsAnimal GetAnimal(string path)
        {
            clsAbsAnimal animal = null;
            string Linea;
            int contador = 0;
            string result_s;
            Console.Clear();
            StreamReader Leer = new StreamReader(path, true);
            Console.WriteLine("Buscar registro por medio de clave DUI:\n\n");
            Console.Write("Ingresa la clave DUI: ");
            result_s = Console.ReadLine();
            do
            {
                Linea = Leer.ReadLine();
            } while (Linea != "nombre:"+result_s && Linea != null);

            if ((Linea == "nombre:" + result_s))
            {
                animal = new Desconocido();
                string[] nombreValue = result_s.Split(':');
                animal.Nombre = nombreValue[1];
                
                do
                {
                    string[] animalValue = Linea.Split(':');
                    if (animalValue[0].Equals("especie:"))
                    {                      
                        animal.Tipo.NombreTipo = animalValue[1];
                    }
                    else if(animalValue[0].Equals("codigo de especie:"))
                    {
                        animal.Tipo.CodigoTipoAnimal = Convert.ToInt32(animalValue[1]);
                    }
                    else if (animalValue[0].Equals("hambre:"))
                    {
                        animal.Hambre = Convert.ToInt32(animalValue[1]);
                    }
                    else if (animalValue[0].Equals("energia:"))
                    {
                        animal.Energia = Convert.ToInt32(animalValue[1]);
                    }

                    Console.WriteLine(Linea);
                    Linea = Leer.ReadLine();

                } while (Linea != " ");
                Console.WriteLine("\nEl registro se mostro exitosamente.\n\n5) Regresar al menu principal\n");
                animal = animal.getEspecie(animal, animal.Tipo.CodigoTipoAnimal);
            }
            Leer.Close();

            
            Console.Write("\nTu opcion: ");
            return animal;
        }

        public void ModificarAnimal(clsAbsAnimal animal,string path)
        {           
            string Linea;
            int contador = 0;
            string result_s;

            string[] lineas = File.ReadAllLines(path);
            for (int i = 0; i < lineas.Length; i++)
            {
                string nombre = "";
                if (lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("nombre"))
                {
                    nombre = lineas[i].Substring(lineas[i].IndexOf(" : ")+1, lineas[i].Length);
                }
                if(nombre.Equals(animal.Nombre)&& lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("hambre"))
                {
                    lineas[i] = "hambre:" + animal.Hambre;
                }
                if (nombre.Equals(animal.Nombre) && lineas[i].Substring(0, lineas[i].IndexOf(" : ")).Equals("energia"))
                {
                    lineas[i] = "energia:" + animal.Energia;
                }
            }
            File.WriteAllLines(path, lineas);

            Console.WriteLine("\nEl registro se mostro exitosamente.\n\n5) Regresar al menu principal\n");
                animal = animal.getEspecie(animal, animal.Tipo.CodigoTipoAnimal);           
       
        }

    }
}
