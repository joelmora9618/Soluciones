using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granja.Exception
{
    class GestorDeArchivosException : SystemException
    {
        public GestorDeArchivosException(String message)
        {
            Console.Write(message);
        }

        public GestorDeArchivosException(String message,SystemException error)
        {
            Console.Write(message);
            Console.Write(error.Message);
        }
    }
}
