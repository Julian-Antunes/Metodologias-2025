using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public abstract class Persona : IComparable
    {
        private string nombre;
        private int dni;

        public Persona(string n, int d)
        {
            this.nombre = n;
            this.dni = d;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public int getDNI()
        {
            return this.dni;
        }

      
        public virtual bool sosIgual(IComparable comparable)
        {
            return this.dni == ((Persona)comparable).dni;
        }

        public virtual bool sosMenor(IComparable comparable)
        {

            return this.dni < ((Persona)comparable).dni;
        }

        public virtual bool sosMayor(IComparable comparable)
        {
            return this.dni > ((Persona)comparable).dni;
        }

    }
}
