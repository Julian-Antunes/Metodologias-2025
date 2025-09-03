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

            var min = coleccion.minimo();
            var max = coleccion.maximo();

            Console.WriteLine($"Mínimo: {min}");
            Console.WriteLine($"Máximo: {max}");

            IComparable buscado;

            if (min is Numero)
            {
                Console.Write("Ingrese un número a buscar: ");
                var entrada = Console.ReadLine()?.Trim();
                if (!int.TryParse(entrada, out int n)) { Console.WriteLine("Número inválido."); return; }
                buscado = new Numero(n);
            }
            else if (min is Alumno)
            {
                var alumnoActual = (Alumno)min;
                var estrategia = alumnoActual.getEstrategia();
                Console.WriteLine($"(Comparando por {estrategia.GetType().Name.Replace("ComparacionPor", "")})");

                if (estrategia is ComparacionPorNombre)
                {
                    Console.Write("Ingrese NOMBRE a buscar: ");
                    string nombre = Console.ReadLine()?.Trim();
                    buscado = new Alumno(nombre, 0, 0, 0, estrategia);
                }
                else if (estrategia is ComparacionPorDNI)
                {
                    Console.Write("Ingrese DNI a buscar: ");
                    var entrada = Console.ReadLine()?.Trim();
                    if (!int.TryParse(entrada, out int dni)) { Console.WriteLine("DNI inválido (solo números)."); return; }
                    buscado = new Alumno("X", dni, 0, 0, estrategia);
                }
                else if (estrategia is ComparacionPorLegajo)
                {
                    Console.Write("Ingrese LEGAJO a buscar: ");
                    var entrada = Console.ReadLine()?.Trim();
                    if (!int.TryParse(entrada, out int legajo)) { Console.WriteLine("Legajo inválido (solo números)."); return; }
                    buscado = new Alumno("X", 0, legajo, 0, estrategia);
                }
                else // Promedio
                {
                    Console.Write("Ingrese PROMEDIO a buscar (ej: 7,50): ");
                    var entrada = Console.ReadLine()?.Trim()?.Replace(',', '.');
                    if (!decimal.TryParse(entrada, System.Globalization.NumberStyles.Number,
                                          System.Globalization.CultureInfo.InvariantCulture, out decimal prom))
                    { Console.WriteLine("Promedio inválido."); return; }
                    buscado = new Alumno("X", 0, 0, prom, estrategia);
                }
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

        public static void LlenarAlumnos(IColeccionable coleccion, IEstrategia estrategia = null)
        {
            string[] nombres = {
        "Julian", "Nicolas", "Lautaro", "Matias", "Joaquin",
        "David", "Agustin", "Sofia", "Karina", "Hugo",
        "Manuel", "Ignacio", "Carolina"
    };

            IEstrategia comp = estrategia ?? new ComparacionPorDNI();

            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[rnd.Next(nombres.Length)];
                int dni = rnd.Next(25000000, 50000000);
                int legajo = rnd.Next(100, 999);
                decimal promedio = Math.Round((decimal)rnd.NextDouble() * 10, 2);

                Alumno alumno = new Alumno(nombre, dni, legajo, promedio);
                alumno.setEstrategia(comp);

                coleccion.agregar(alumno);
            }
        }

        public static void ImprimirElementos(IColeccionable coleccion)
        {
            if (!(coleccion is IIterable iterable))
            {
                Console.WriteLine("No es iterable");
                return;
            }

            IIterator iterador = iterable.CrearIterador();

            Console.WriteLine("los elementos son los siguintes");
            for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
            {
                Console.WriteLine(iterador.Actual());
            }
        }
        public static void CambiarEstrategia(IColeccionable coleccion, IEstrategia estrategia)
        {
            if (!(coleccion is IIterable iterable))
            {
                Console.WriteLine("No es iterable");
                return;
            }

            IIterator iterador = iterable.CrearIterador();

            for (iterador.Primero(); !iterador.Fin(); iterador.Siguiente())
            {
                if (iterador.Actual() is Alumno alumno)
                {
                    alumno.setEstrategia(estrategia);
                }
            }

            Console.WriteLine($"Estrategia cambiada a: {estrategia.GetType().Name}");
        }



    }
}
