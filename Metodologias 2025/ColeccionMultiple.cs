using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class ColeccionMultiple : IColeccionable   
    {
        public Pila pila;  
        public Cola cola;  
        public ColeccionMultiple(Pila p,Cola c)
        {
            pila = p;
            cola = c;
        }

        public void agregar(IComparable c)
        {
        }

        public bool contiene(IComparable c)
        {
            return pila.contiene(c) || cola.contiene(c);
        }

        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        public IComparable maximo()
        {
            IComparable maxPila = pila.maximo();
            IComparable maxCola = cola.maximo();

            if (maxPila.sosMayor(maxCola))
                return maxPila;
            else
                return maxCola;
        }

        public IComparable minimo()
        {
            IComparable minPila = pila.minimo();
            IComparable minCola = cola.minimo();

            if (minPila.sosMenor(minCola))
                return minPila;
            else
                return minCola;
        }
    }
}
