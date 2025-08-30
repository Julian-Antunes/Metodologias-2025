using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Alumno : Persona
    {
        public int legajo;
        public decimal promedio;

        public Alumno(string n, int d, int l, decimal p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }

        public int getLegajo()
        {
            return legajo;
        }
      
        public decimal getPromedio()
        {
            return promedio;
        }
        public override string ToString()
        {
            return $"{getNombre()} – DNI: {getDNI()}, Legajo: {getLegajo()}, Promedio: {getPromedio():F2}";
        }

        public override bool sosIgual(IComparable comparable)
        {
            return this.promedio == ((Alumno)comparable).promedio;
        }

        public override bool sosMenor(IComparable comparable)
        {
            return this.promedio < ((Alumno)comparable).promedio;
        }

        public override bool sosMayor(IComparable comparable)
        {
            return this.promedio > ((Alumno)comparable).promedio;
        }

    }
}
