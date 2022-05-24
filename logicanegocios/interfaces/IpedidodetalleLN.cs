using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.interfaces
{
    interface IpedidodetalleLN
    {
        List<PA_Pedidodetalle_MostrarDetalle_Result> mostrarpedidodetalle();

        PA_Pedidodetalle_MostrarDetallexid_Result mostrarpedidodetallexid(int pidpdetalle);

        bool insertarpedidodetalle(PedidoDet ppedidodetalle);

        bool actualizarpedidodetalle(PedidoDet ppedidodetalle);

        bool eliminarpedidodetalle(PedidoDet ppedidodetalle);


    }
}
