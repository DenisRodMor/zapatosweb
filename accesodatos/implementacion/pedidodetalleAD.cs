using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesodatos.implementacion
{
   public class pedidodetalleAD : IpedidodetalleAD
    {
        private zapatoswebEntidades gobjContextoZW;

        public pedidodetalleAD(zapatoswebEntidades _gobjContextoZW)
        {
            gobjContextoZW = _gobjContextoZW;

        }

        public List<PA_Pedidodetalle_MostrarDetalle_Result> mostrarpedidodetalle()
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Pedidodetalle_MostrarDetalle().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_Pedidodetalle_MostrarDetallexid_Result mostrarpedidodetallexid(int pidpdetalle)
        {
            PA_Pedidodetalle_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidodetalle_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Pedidodetalle_MostrarDetallexid(pidpdetalle).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertarpedidodetalle(PedidoDet ppedidodetalle)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Pedidodetalle_insertar(ppedidodetalle.IdPedido, ppedidodetalle.IdZapato, ppedidodetalle.Cantidad) == 1)
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

        public bool actualizarpedidodetalle(PedidoDet ppedidodetalle)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Pedidodetalle_Actualizar(ppedidodetalle.IdPedido, ppedidodetalle.IdZapato, ppedidodetalle.Cantidad) == 1)
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

        public bool eliminarpedidodetalle(PedidoDet ppedidodetalle)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Pedidodetalle_eliminar(ppedidodetalle.IdPedido) == 1)
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
