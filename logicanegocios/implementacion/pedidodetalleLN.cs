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
   public  class pedidodetalleLN : IpedidodetalleLN
    {

        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly pedidodetalleAD objpedidodetalleAD = new pedidodetalleAD(gobjContextoZW);


        public List<PA_Pedidodetalle_MostrarDetalle_Result> mostrarpedidodetalle()
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objpedidodetalleAD.mostrarpedidodetalle();
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
                lobjRespuesta = objpedidodetalleAD.mostrarpedidodetallexid(pidpdetalle);
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
                lobjRespuesta = objpedidodetalleAD.insertarpedidodetalle(ppedidodetalle);

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
                lobjRespuesta = objpedidodetalleAD.actualizarpedidodetalle(ppedidodetalle);

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
                lobjRespuesta = objpedidodetalleAD.eliminarpedidodetalle(ppedidodetalle);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }


    }
}
