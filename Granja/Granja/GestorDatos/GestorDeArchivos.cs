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
            Console.WriteLine("Mostrando todos los registros:\n\n");


            string[] lineas = File.ReadAllLines(path);
            if (lineas.Length > 0)
            {
                for (int i = 0; i < lineas.Length; i++)
                {
                    if (!string.IsNullOrEmpty(lineas[i]))
                    {
                        clsAbsAnimal animal = new Desconocido();
                        if (lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("nombre"))
                        {
                            animal.Nombre = lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1);
                        }
                        if (lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("hambre"))
                        {
                            animal.Hambre = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1));
                        }
                        if (lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("energia"))
                        {
                            animal.Energia = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1));
                        }
                        Console.WriteLine(lineas[i]);
                        listaAnimales.Add(animal);
                    }
                    else
                    {
                        Console.WriteLine("\n");
                    }

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
            clsAbsAnimal animal = new Desconocido();
            string Linea;
            int contador = 0;
            string result_s;
            Console.Clear();
            Console.WriteLine("Buscar registro por medio del nombre:\n\n");
            Console.Write("Ingresa el nombre del animal: ");
            result_s = Console.ReadLine();

            string[] lineas = File.ReadAllLines(path);
            string nombre = "";
            for (int i = 0; i < lineas.Length; i++)
            {
                if (!string.IsNullOrEmpty(lineas[i]))
                {
                    
                    if (lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("nombre"))
                    {
                        nombre = lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1);
                    }
                    if (nombre.Equals(result_s))
                    {
                        animal.Nombre = nombre;
                    }
                    if (nombre.Equals(result_s) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("especie"))
                    {
                        animal.Tipo.NombreTipo = lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1);
                    }
                    if (nombre.Equals(result_s) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("codigo de especie"))
                    {
                        animal.Tipo.CodigoTipoAnimal = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1));
                    }
                    if (nombre.Equals(result_s) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("hambre"))
                    {
                        animal.Hambre = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1));
                    }
                    if (nombre.Equals(result_s) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("energia"))
                    {
                        animal.Energia = Convert.ToInt32(lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1));
                    }
                }
            }
            Console.Write("nombre: "+animal.Nombre+"\n");
            Console.Write("especie: " + animal.Tipo.NombreTipo + "\n");
            Console.Write("hambre: " + animal.Hambre + "\n");
            Console.Write("energia: " + animal.Energia + "\n");

            return animal.getEspecie(animal, animal.Tipo.CodigoTipoAnimal);
        }

        public void ModificarAnimal(clsAbsAnimal animal,string path)
        {           
            string[] lineas = File.ReadAllLines(path);
            string nombre = "";
            for (int i = 0; i < lineas.Length; i++)
            {
                if (!string.IsNullOrEmpty(lineas[i]))
                {
                    if (lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("nombre"))
                    {
                        nombre = lineas[i].Substring(lineas[i].IndexOf(":") + 1, lineas[i].Length - lineas[i].IndexOf(":") - 1);
                    }
                    if (nombre.Equals(animal.Nombre) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("hambre"))
                    {
                        lineas[i] = "hambre:" + animal.Hambre;
                    }
                    if (nombre.Equals(animal.Nombre) && lineas[i].Substring(0, lineas[i].IndexOf(":")).Equals("energia"))
                    {
                        lineas[i] = "energia:" + animal.Energia;
                    }
                }
            }
            File.WriteAllLines(path, lineas);

            Console.WriteLine("\nEl animal se alimento exitosamente.");
                animal = animal.getEspecie(animal, animal.Tipo.CodigoTipoAnimal);           
       
        }

    }
}
