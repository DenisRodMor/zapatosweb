using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.interfaces
{
    public interface ItallasLN
    {
        List<PA_Tallas_MostrarDetalle_Result> mostrartallas();
        PA_Tallas_MostrarDetallexid_Result mostrartallasxid(int pidtallas);
        bool insertartallas(Tallas ptallas);
        bool actualizartallas(Tallas ptallas);
        bool eliminartallas(Tallas ptallas);


    }
}
