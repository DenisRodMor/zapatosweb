using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace accesodatos.implementacion
{
    public class ClientesAD : IclientesAD
    {
        private zapatoswebEntidades gobjContextoZW;

        public ClientesAD(zapatoswebEntidades _gobjContextoZW)
        {
            gobjContextoZW = _gobjContextoZW;

        }

        public List<PA_Clientes_MostrarDetalle_Result> mostrarclientes()
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Clientes_MostrarDetalle().ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_Clientes_MostrarDetallexid_Result mostrarclientesxid(int pidclientes)
        {
            PA_Clientes_MostrarDetallexid_Result lobjRespuesta = new PA_Clientes_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Clientes_MostrarDetallexid(pidclientes).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertarcliente(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
               if(gobjContextoZW.PA_Clientes_insertar(pClientes.Nombre, pClientes.Ap1, pClientes.Ap2, pClientes.telefono, pClientes.email) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool actualizarcliente(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Clientes_Actualizar(pClientes.IdCliente, pClientes.Nombre, pClientes.Ap1, pClientes.Ap2, pClientes.telefono, pClientes.email) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool eliminarcliente(Clientes pClientes)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Clientes_Eliminar(pClientes.IdCliente) == 1)
                {
                    lobjRespuesta = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
    }
}
