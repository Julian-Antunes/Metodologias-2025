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
            ColeccionMultiple multiple = new ColeccionMultiple(pila, cola);

            // Funciones.Llenar(pila);
            // Funciones.Llenar(cola);
            //Funciones.LlenarAlumnos(cola);
            // Funciones.LlenarAlumnos(pila);

            //IColeccionable alumnos = new Pila();  
            //Funciones.LlenarAlumnos(alumnos);
            // Funciones.Informar(alumnos);

            // Console.WriteLine("Informando Pila");
            // Funciones.Informar(pila);

            // Console.WriteLine("Informando Cola");
            // Funciones.Informar(cola);

            // Console.WriteLine("Informando Multiple");
            // Funciones.Informar(multiple);
          

            Funciones.LlenarAlumnos(pila);
            Funciones.LlenarAlumnos(cola);

            Funciones.Informar(multiple);

            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
