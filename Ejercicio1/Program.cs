using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //args = parametros desde consola
            var nombre = args.SingleOrDefault();
            if (nombre == null)
            {
                Console.WriteLine("Escribe tu nombre y presiona enter al finalizar");
                //se lee el parametro ingresado
                nombre = Console.ReadLine();
            }
            //imprime Hola y el nombre ingresado
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
    }
}
