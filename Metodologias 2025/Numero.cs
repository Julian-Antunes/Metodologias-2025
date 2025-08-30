using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    internal class Numero : IComparable
    {
        public int valor;

        public Numero( int valor) { this.valor = valor; }
        public int getValor() {  return this.valor; }
  
        public bool sosIgual(IComparable comparable)
        {
            
            return this.valor == ((Numero)comparable).getValor();
        }

        public bool sosMayor(IComparable comparable)
        {
            return this.valor > ((Numero)comparable).getValor();
        }

        public bool sosMenor(IComparable comparable)
        {
            return this.valor < ((Numero)comparable).getValor();
        }

        public override string ToString()
        {
            return $"Numero: {valor}";
        }



    }

}
