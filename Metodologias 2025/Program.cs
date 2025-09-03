using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Pila pila = new Pila();
            Cola cola = new Cola();
            Conjunto conjunto = new Conjunto();

            Funciones.LlenarAlumnos(pila);
            Funciones.LlenarAlumnos(cola);
            Funciones.LlenarAlumnos(conjunto);

            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            Console.WriteLine("Informando Multiple");
            Funciones.Informar(multiple);

            Console.WriteLine("\nCONJUNTO");
            Funciones.ImprimirElementos(conjunto);

            Console.WriteLine("\nComparacion por Nombre");
            Funciones.CambiarEstrategia(pila, new ComparacionPorNombre());
            Funciones.Informar(pila);

            Console.WriteLine("\nComparacion por Legajo");
            Funciones.CambiarEstrategia(pila, new ComparacionPorLegajo());
            Funciones.Informar(pila);

            Console.WriteLine("\nComparacion por Promedio");
            Funciones.CambiarEstrategia(pila, new ComparacionPorPromedio());
            Funciones.Informar(pila);

            Console.WriteLine("\nComparacion por DNI");
            Funciones.CambiarEstrategia(pila, new ComparacionPorDNI());
            Funciones.Informar(pila);

            Console.ReadKey();
        }

    }
}
