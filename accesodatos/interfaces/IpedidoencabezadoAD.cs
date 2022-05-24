using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesodatos.interfaces
{
    interface IpedidoencabezadoAD
    {

        List<PA_Pedidoencabezado_MostrarDetalle_Result> mostrarpedidoencabezado();

        PA_Pedidoencabezado_MostrarDetallexid_Result mostrarpedidoencabezadoxid(int pidpencabezado);

        bool insertarpedidoencabezado(PedidoEnCab ppedidoencabezado);

        bool actualizarpedidoencabezado(PedidoEnCab ppedidoencabezado);

        bool eliminarpedidoencabezado(PedidoEnCab ppedidoencabezado);


    }
}
