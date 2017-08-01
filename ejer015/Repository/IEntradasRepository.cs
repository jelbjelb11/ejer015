using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer015.Servicios
{
    public interface IEntradasRepository
    {
        Entrada Create(Entrada entrada);
    }
}
