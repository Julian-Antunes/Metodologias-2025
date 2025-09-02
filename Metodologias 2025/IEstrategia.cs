using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodologias_2025
{
    public interface IEstrategia
    {
        bool sosIgual(IComparable a1, IComparable a2);
        bool sosMenor(IComparable a1, IComparable a2);
        bool sosMayor(IComparable a1, IComparable a2);
    }
}
