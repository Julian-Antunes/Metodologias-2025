using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public interface IIterator
    {
        void Primero();
        void Siguiente();
        bool Fin();
        IComparable Actual();
    }
}
