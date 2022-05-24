using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesodatos.implementacion
{
  public  class pedidoencabezadoAD  : IpedidoencabezadoAD
    {
        private zapatoswebEntidades gobjContextoZW;

        public pedidoencabezadoAD(zapatoswebEntidades _gobjContextoZW)
        {
            gobjContextoZW = _gobjContextoZW;

        }


        public List<PA_Pedidoencabezado_MostrarDetalle_Result> mostrarpedidoencabezado()
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Pedidoencabezado_MostrarDetalle().ToList();
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
                lobjRespuesta = gobjContextoZW.PA_Pedidoencabezado_MostrarDetallexid(pidpencabezado).FirstOrDefault();
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
                if (gobjContextoZW.PA_Pedidoencabezado_insertar(ppedidoencabezado.idCliente, ppedidoencabezado.FecPedido) == 1)
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

        public bool actualizarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Pedidoencabezado_actualizar( ppedidoencabezado.IdPedido ,ppedidoencabezado.idCliente, ppedidoencabezado.FecPedido) == 1)
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

        public bool eliminarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Pedidoencabezado_eliminar(ppedidoencabezado.IdPedido) == 1)
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
