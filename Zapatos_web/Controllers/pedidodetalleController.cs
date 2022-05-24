using entidades;
using logicanegocios.implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zapatos_web.Controllers
{
    public class pedidodetalleController : Controller
    {

        private pedidodetalleLN objpedidodetalleLN = new pedidodetalleLN();
        // GET: pedidodetalle
        public ActionResult listarpedidodetalle()
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objpedidodetalleLN.mostrarpedidodetalle();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregapedidodetalle()
        {

            return View();
        }

        public ActionResult actualizapedidodetalle(int id)
        {
            PA_Pedidodetalle_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidodetalle_MostrarDetallexid_Result();
            PedidoDet objpedidodetalle = new PedidoDet();
            try
            {
                lobjRespuesta = objpedidodetalleLN.mostrarpedidodetallexid(id);
                objpedidodetalle.IdPedido = id;
                objpedidodetalle.IdZapato = lobjRespuesta.IdZapato;
                objpedidodetalle.Cantidad = lobjRespuesta.Cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidodetalle);
        }

        public ActionResult eliminapedidodetalle(int id)
        {
            PA_Pedidodetalle_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidodetalle_MostrarDetallexid_Result();
            PedidoDet objpedidodetalle = new PedidoDet();
            try
            {
                lobjRespuesta = objpedidodetalleLN.mostrarpedidodetallexid(id);
                objpedidodetalle.IdPedido = id;
                objpedidodetalle.IdZapato = lobjRespuesta.IdZapato;
                objpedidodetalle.Cantidad = lobjRespuesta.Cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidodetalle);
        }

        public ActionResult detallepedidodetalle(int id)
        {
            PA_Pedidodetalle_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidodetalle_MostrarDetallexid_Result();
            PedidoDet objpedidodetalle = new PedidoDet();
            try
            {
                lobjRespuesta = objpedidodetalleLN.mostrarpedidodetallexid(id);
                objpedidodetalle.IdPedido = id;
                objpedidodetalle.IdZapato = lobjRespuesta.IdZapato;
                objpedidodetalle.Cantidad = lobjRespuesta.Cantidad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidodetalle);
        }

        [HttpPost]
        public ActionResult acciones(string submitbutton, PedidoDet ppedidodetalle)
        {
            try
            {
                switch (submitbutton)
                {
                    case "Agregar":
                        return ingresapedidodetalle(ppedidodetalle);

                    case "Modificar":
                        return actualizarpedidodetalle(ppedidodetalle);

                    case "Eliminar":
                        return eliminarpedidodetalle(ppedidodetalle);

                    default:
                        return RedirectToAction("listarpedidodetalle");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult ingresapedidodetalle(PedidoDet ppedidodetalle)
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                if (objpedidodetalleLN.insertarpedidodetalle(ppedidodetalle))
                {
                    lobjRespuesta = objpedidodetalleLN.mostrarpedidodetalle();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidodetalle", lobjRespuesta);
        }


        public ActionResult actualizarpedidodetalle(PedidoDet ppedidodetalle)
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                if (objpedidodetalleLN.actualizarpedidodetalle(ppedidodetalle))
                {
                    lobjRespuesta = objpedidodetalleLN.mostrarpedidodetalle();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidodetalle", lobjRespuesta);
        }

        public ActionResult eliminarpedidodetalle(PedidoDet ppedidodetalle)
        {
            List<PA_Pedidodetalle_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidodetalle_MostrarDetalle_Result>();
            try
            {
                if (objpedidodetalleLN.eliminarpedidodetalle(ppedidodetalle))
                {
                    lobjRespuesta = objpedidodetalleLN.mostrarpedidodetalle();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidodetalle", lobjRespuesta);
        }

    }
}