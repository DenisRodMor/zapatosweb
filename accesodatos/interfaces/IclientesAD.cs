using entidades;
using System.Collections.Generic;

namespace accesodatos.interfaces
{
    public interface IclientesAD
    {
        List<PA_Clientes_MostrarDetalle_Result> mostrarclientes();
        PA_Clientes_MostrarDetallexid_Result mostrarclientesxid(int pidclientes);
        bool actualizarcliente(Clientes pClientes);

        bool eliminarcliente(Clientes pClientes);
        bool insertarcliente(Clientes pClientes);
    }
}
