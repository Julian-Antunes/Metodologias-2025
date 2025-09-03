using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Conjunto : IColeccionable, IIterable

    {
        private List<IComparable> elementos = new List<IComparable>();
        
        public bool pertenece (IComparable c)
        {
            foreach (IComparable elemento in this.elementos)
            {
                if (elemento.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public void agregar (IComparable c)
            {
            if (!pertenece(c))
            {
                elementos.Add(c);
            }
        }

        public bool contiene(IComparable c)
        {
            return pertenece(c);
        }

        public int cuantos()
        {
            return elementos.Count;
        }

        public IComparable maximo()
        {
            if (elementos.Count == 0) return null;

            IComparable max = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.sosMayor(max)) max = e;
            }
            return max;
        }

        public IComparable minimo()
        {
            if (elementos.Count == 0) return null;

            IComparable min = elementos[0];
            foreach (IComparable e in elementos)
            {
                if (e.sosMenor(min)) min = e;
            }
            return min;
        }

        public IIterator CrearIterador()
        {
            return new IteradorLista(elementos);
        }
    }
    
}
