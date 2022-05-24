using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.interfaces
{
    public interface ItipozapatoLN
    {
        List<PA_TipoZapato_MostrarDetalle_Result> mostrartipozapato();
        PA_TipoZapato_MostrarDetallexid_Result mostrartipozapaotoxid(int pidtipozapato);
        bool insertartipozapato(TipoZapato ptipozapato);
        bool actualizartipozapato(TipoZapato ptipozapato);
        bool eliminartipozapato(TipoZapato ptipozapato);


        }
}
