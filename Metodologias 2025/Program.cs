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
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);
            
           Funciones.Llenar(pila);
            Funciones.Llenar(cola);
            Funciones.LlenarAlumnos(cola);
            Funciones.LlenarAlumnos(pila);

            // Console.WriteLine("Informando Pila");
            // Funciones.Informar(pila);

            // Console.WriteLine("Informando Cola");
            // Funciones.Informar(cola);

            // Console.WriteLine("Informando Multiple");
            // Funciones.Informar(multiple);


            // Funciones.LlenarAlumnos(pila);
            Funciones.LlenarAlumnos(cola);
            Funciones.LlenarAlumnos(pila, new ComparacionPorDNI());
            //Funciones.Informar(multiple);

            Console.ReadKey();
            Alumno a1 = new Alumno("Julian", 123, 101, 8.5m);
            Alumno a2 = new Alumno("Nicolas", 123, 20, 7.0m);

            a1.setEstrategia(new ComparacionPorDNI());
            a2.setEstrategia(new ComparacionPorLegajo());

            Console.WriteLine(a1.sosIgual(a2));  
            Console.WriteLine(a2.sosMayor(a2));  
            Console.WriteLine("\n");

            Console.WriteLine("PILA");
            Funciones.ImprimirElementos(pila);

            Console.WriteLine("\nCOLA");
            Funciones.ImprimirElementos(cola);

            Funciones.Informar(multiple);

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
