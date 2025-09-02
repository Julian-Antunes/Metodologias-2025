using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public class ComparacionPorPromedio : IEstrategia
    {
        public bool sosIgual(IComparable a1, IComparable a2)
            => ((Alumno)a1).getPromedio() == ((Alumno)a2).getPromedio();

        public bool sosMenor(IComparable a1, IComparable a2)
            => ((Alumno)a1).getPromedio() < ((Alumno)a2).getPromedio();

        public bool sosMayor(IComparable a1, IComparable a2)
            => ((Alumno)a1).getPromedio() > ((Alumno)a2).getPromedio();
    }
}
