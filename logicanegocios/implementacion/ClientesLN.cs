using accesodatos;
using accesodatos.implementacion;
using accesodatos.interfaces;
using entidades;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;

namespace logicanegocios.implementacion
{
    public class ClientesLN : IClientesLN
    {

        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly IclientesAD objclientesAD = new ClientesAD(gobjContextoZW);


        public List<PA_Clientes_MostrarDetalle_Result> mostrarclientes()
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objclientesAD.mostrarclientes();
            }
            catch (Exception ex)
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
                lobjRespuesta = objclientesAD.mostrarclientesxid(pidclientes);
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
                lobjRespuesta = objclientesAD.insertarcliente(pClientes);
                
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
                lobjRespuesta = objclientesAD.actualizarcliente(pClientes);

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
                lobjRespuesta = objclientesAD.eliminarcliente(pClientes);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

    }
}
