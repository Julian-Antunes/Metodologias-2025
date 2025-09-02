using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class IteradorLista : IIterator
    {
        private List<IComparable> elementos;
        private int i;

        public IteradorLista(List<IComparable> elementos)
        {
            this.elementos = elementos;
            Primero();
        }

        public void Primero()
        {
            i = 0;
        }

        public void Siguiente()
        {
            i++;
        }

        public bool Fin()
        {
            return i >= elementos.Count;
        }

        public IComparable Actual()
        {
            return !Fin() ? elementos[i] : null;
        }
    }
}
