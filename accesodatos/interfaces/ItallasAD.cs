using entidades;
using System.Collections.Generic;

namespace accesodatos.interfaces
{
    public interface ItallasAD
    {
        List<PA_Tallas_MostrarDetalle_Result> mostrartallas();
        PA_Tallas_MostrarDetallexid_Result mostrartallasxid(int pidtallas);
        bool insertartallas(Tallas ptallas);
        bool actualizartallas(Tallas ptallas);
        bool eliminartallas(Tallas ptallas);

    }
}
