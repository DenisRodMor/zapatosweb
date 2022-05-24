using accesodatos;
using accesodatos.implementacion;
using entidades;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.implementacion
{
   public  class pedidoencabezadoLN : IpedidoencabezadoLN
    {
        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly pedidoencabezadoAD objpedidoencabezadoAD = new pedidoencabezadoAD(gobjContextoZW);

        public List<PA_Pedidoencabezado_MostrarDetalle_Result> mostrarpedidoencabezado()
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objpedidoencabezadoAD.mostrarpedidoencabezado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_Pedidoencabezado_MostrarDetallexid_Result mostrarpedidoencabezadoxid(int pidpencabezado)
        {
            PA_Pedidoencabezado_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidoencabezado_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = objpedidoencabezadoAD.mostrarpedidoencabezadoxid(pidpencabezado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objpedidoencabezadoAD.insertarpedidoencabezado(ppedidoencabezado);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool actualizarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objpedidoencabezadoAD.actualizarpedidoencabezado(ppedidoencabezado);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool eliminarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objpedidoencabezadoAD.eliminarpedidoencabezado(ppedidoencabezado);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
    }
}
