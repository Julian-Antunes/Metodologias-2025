using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Funciones
    {
        private static Random rnd = new Random();

        public static void Llenar(IColeccionable coleccion)
        {
            for (int i = 0; i < 20; i++)
            {
                int valor = rnd.Next(1, 101);
                Numero n = new Numero(valor);
                coleccion.agregar(n);
            }
        }

        public static void Informar(IColeccionable coleccion)
        {
            Console.WriteLine($"Cantidad de elementos: {coleccion.cuantos()}");

            IComparable minimo = coleccion.minimo();
            IComparable maximo = coleccion.maximo();

            Console.WriteLine($"Mínimo: {minimo}");
            Console.WriteLine($"Máximo: {maximo}");

            Console.Write("Ingrese un valor para buscar: ");
            string entrada = Console.ReadLine();

            IComparable buscado;

            if (coleccion.minimo() is Numero)
            {
                int valor = int.Parse(entrada);
                buscado = new Numero(valor);
            }
            else if (coleccion.minimo() is Alumno)
            {
                decimal promedio = decimal.Parse(entrada);
                buscado = new Alumno("X", 0, 0, promedio);
            }
            else
            {
                Console.WriteLine("Tipo no soportado.");
                return;
            }

            Console.WriteLine(coleccion.contiene(buscado)
                ? "El elemento está en la colección."
                : "El elemento NO está en la colección.");
        }


        public static void LlenarAlumnos(IColeccionable coleccion)
        {
            string[] nombres = {"Julian", "Nicolas", "Lautaro", "Matias", "Joaquin", "David", "Agustin", "Sofia", "Karina", "Hugo", "Manuel", "Ignacio", "Carolina", };

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[rnd.Next(nombres.Length)];
                int dni = rnd.Next(25000000, 50000000);   
                int legajo = rnd.Next(100, 999);
                decimal promedio = Math.Round((decimal)rnd.NextDouble() * 10,2);

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccion.agregar(alumno);
            }
        }
    }

}
