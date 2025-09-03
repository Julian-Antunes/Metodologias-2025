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

            //Console.Write("Ingrese un valor para buscar: ");
           //string entrada = Console.ReadLine();

            Numero buscado = new Numero(valor);

            if (coleccion.minimo() is Numero)
            {
                string entrada = Console.ReadLine();
                int valor = int.Parse(entrada);
                buscado = new Numero(valor);
            }
            else if (coleccion.minimo() is Alumno)
            {
                Alumno alumnoActual = (Alumno)coleccion.minimo();
                Alumno buscadoAlumno = new Alumno("X", 0, 0, 0);
                buscadoAlumno.setEstrategia(alumnoActual.getEstrategia());

                if (alumnoActual.getEstrategia() is ComparacionPorNombre)
                {
                    Console.Write("Ingrese NOMBRE a buscar: ");
                    string nombre = Console.ReadLine().Trim();

                    buscadoAlumno = new Alumno(nombre, 0, 0, 0, alumnoActual.getEstrategia());
                }
                else if (alumnoActual.getEstrategia() is ComparacionPorDNI)
                {
                    Console.Write("Ingrese DNI a buscar: ");
                    string leerDNI = Console.ReadLine().Trim();

                    if (!int.TryParse(leerDNI, out int dni))
                    {
                        Console.WriteLine("DNI inválido, debe ser un numero.");
                        return;
                    }

                    buscadoAlumno = new Alumno("X", dni, 0, 0, alumnoActual.getEstrategia());
                }
                else if (alumnoActual.getEstrategia() is ComparacionPorLegajo)
                {
                    Console.Write("Ingrese LEGAJO a buscar: ");
                    string leerLegajo = Console.ReadLine().Trim();

                    if (!int.TryParse(leerLegajo, out int legajo))
                    {
                        Console.WriteLine("Legajo inválido, debe ser un numero.");
                        return;
                    }

                    buscadoAlumno = new Alumno("X", 0, legajo, 0, alumnoActual.getEstrategia());
                }
                else if (alumnoActual.getEstrategia() is ComparacionPorPromedio)
                {
                    Console.Write("Ingrese PROMEDIO a buscar: ");
                    string leerPromedio = Console.ReadLine().Trim();

                    if (!decimal.TryParse(leerPromedio, out decimal promedio))
                    {
                        Console.WriteLine("Promedio invalido, debe ser un numero EJEMPLO 7,50");
                        return;
                    }

                    buscadoAlumno = new Alumno("X", 0, 0, promedio, alumnoActual.getEstrategia());
                }

                buscado = buscadoAlumno;

            }
            else
                Console.WriteLine("El elemento esta en la coleccion.");
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
