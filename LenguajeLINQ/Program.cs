/*
 * LINQ extiende el lenguaje C# a traves de las llamadas expresiones de consulta
 * estas consultas son muy parecidas a las realizadas por SQL
 * puede usarse LINQ para extraer datos de un Array, clases enumerables, documentos XML, base de datos relacionales y fuentes de terceros
 */

using System;
using System.Linq;

namespace LenguajeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un array de tipo string llamado nombre
            string[] nombres = { "Angel", "Alicia", "Daniel", "Pablo", "Romina", "Lucas" };
            //Consulta LINQ: Creamos lista y pasamos los elementos de nuestro array
            var lista = from n in nombres
                        where n.Contains("Daniel")
                        select n;
            //Recorremos elementos de la lista
            foreach(var l in lista)
            {
                Console.WriteLine(l);
            }

            Console.ReadKey();
        }
    }
}
