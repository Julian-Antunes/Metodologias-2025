using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class ComparacionPorNombre : IEstrategia
    {
        public bool sosIgual(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre().ToLower() == ((Alumno)a2).getNombre().ToLower();
        }

        public bool sosMenor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre().ToLower()
                .CompareTo(((Alumno)a2).getNombre().ToLower()) < 0;
        }

        public bool sosMayor(IComparable a1, IComparable a2)
        {
            return ((Alumno)a1).getNombre().ToLower()
                .CompareTo(((Alumno)a2).getNombre().ToLower()) > 0;
        }
    }
}

