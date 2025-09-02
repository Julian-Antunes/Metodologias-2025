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
                int valor = rnd.Next(1, 101); // números aleatorios
                Numero n = new Numero(valor);
                coleccion.agregar(n);
            }
        }

        public static void Informar(IColeccionable coleccion)
        {
            Console.WriteLine($"Cantidad de elementos: {coleccion.cuantos()}");

            Numero minimo = (Numero)coleccion.minimo();
            Numero maximo = (Numero)coleccion.maximo();

            Console.WriteLine($"Minimo: {minimo.getValor()}");
            Console.WriteLine($"Maximo: {maximo.getValor()}");

            Console.Write("Ingrese un valor para buscar: ");
            int valor = int.Parse(Console.ReadLine());

            Numero buscado = new Numero(valor);

            if (coleccion.contiene(buscado))
                Console.WriteLine("El elemento esta en la coleccion.");
            else
                Console.WriteLine("El elemento esta en la coleccion.");
        }

        public static void LlenarAlumnos(IColeccionable coleccion)
        {
            string[] nombres = {"Julian", "Nicolas", "Lautaro", "Matias", "Joaquin", "David", "Agustin", "Sofia", "Karina", "Hugo", "Manuel", "Ignacio", "Carolina", };

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[rnd.Next(nombres.Length)];
                int dni = rnd.Next(10000000, 50000000);   
                int legajo = rnd.Next(100, 999);       
                double promedio = Math.Round(rnd.NextDouble() * 10, 2);

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                coleccion.agregar(alumno);
            }
        }
    }

}
