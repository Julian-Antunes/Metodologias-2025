using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Cola : IColeccionable , IIterable
    {
        List<IComparable> elementos;
        public Cola() { this.elementos = new List<IComparable>(); }
        public void encolar(IComparable c)
        {
            this.elementos.Add(c);
        }
        public IComparable desencolar()
        {
            IComparable e = this.elementos[0];
            this.elementos.RemoveAt(0);
            return e;
        }
        public int cuantos()
        {
            return this.elementos.Count;
        }
        public IComparable minimo()
        {
            IComparable masChico = this.elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (this.elementos[i].sosMenor(masChico))
                    masChico = this.elementos[i];
            }
            return masChico;
        }

        public IComparable maximo()
        {
            IComparable masGrande = this.elementos[0];
            for (int i = 1; i < elementos.Count; i++)
            {
                if (this.elementos[i].sosMayor(masGrande))
                    masGrande = this.elementos[i];
            }
            return masGrande;
        }
        public void agregar(IComparable c)
        {

            this.encolar(c);
        }

        public bool contiene(IComparable c)
        {
            foreach (IComparable e in this.elementos)
            {
                if (e.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public IIterator CrearIterador()
        {
            return new IteradorLista(elementos);
        }
    }
}