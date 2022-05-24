using entidades;
using System.Collections.Generic;

namespace logicanegocios.interfaces
{
    public interface IClientesLN
    {
        List<PA_Clientes_MostrarDetalle_Result> mostrarclientes();
        PA_Clientes_MostrarDetallexid_Result mostrarclientesxid(int pidclientes);
        bool insertarcliente(Clientes pClientes);
        bool actualizarcliente(Clientes pClientes);
        bool eliminarcliente(Clientes pClientes);

    }
}
