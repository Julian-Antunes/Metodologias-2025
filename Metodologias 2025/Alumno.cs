using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class Alumno : Persona
    {
        private int legajo;
        private double promedio;

        public Alumno(string n, int d, int l, double p) : base(n, d)
        {
            legajo = l;
            promedio = p;
        }

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }
    }
}
