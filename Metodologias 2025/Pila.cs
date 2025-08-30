using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Pila : IColeccionable
    {
        private List<IComparable> elementos;
        public Pila() { this.elementos = new List<IComparable>(); }
        public void apilar(IComparable c) { this.elementos.Add(c); }
        public IComparable desapilar()
        {
            IComparable e = this.elementos[this.elementos.Count - 1];
            this.elementos.RemoveAt(this.elementos.Count - 1);
            return e;
        }

        public int cuantos() { return this.elementos.Count; }
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
            this.apilar(c);
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

    }
}
