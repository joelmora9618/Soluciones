using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Granja.Datos
{
    public class DataConection
    {
        public static String PATH_DATA_BASE = "";
        public static String PATH_FILE_DATA = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)+ "animales.log";
    }
}
