using entidades;
using logicanegocios.implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zapatos_web.Controllers
{
    public class pedidoencabezadoController : Controller
    {

        private pedidoencabezadoLN objpedidoencabezadoLN = new pedidoencabezadoLN();
        // GET: pedidoencabezado
        public ActionResult listarpedidoencabezado()
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregapedidoencabezado()
        {

            return View();
        }


        public ActionResult actualizapedidoencabezado(int id)
        {
            PA_Pedidoencabezado_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidoencabezado_MostrarDetallexid_Result();
            PedidoEnCab objpedidoencabezado = new PedidoEnCab();
            try
            {
                lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezadoxid(id);
                objpedidoencabezado.IdPedido = id;
                objpedidoencabezado.idCliente = lobjRespuesta.IdCliente;
                objpedidoencabezado.FecPedido = lobjRespuesta.FecPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidoencabezado);
        }

        public ActionResult eliminapedidoencabezado(int id)
        {
            PA_Pedidoencabezado_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidoencabezado_MostrarDetallexid_Result();
            PedidoEnCab objpedidoencabezado = new PedidoEnCab();
            try
            {
                lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezadoxid(id);
                objpedidoencabezado.IdPedido = id;
                objpedidoencabezado.idCliente = lobjRespuesta.IdCliente;
                objpedidoencabezado.FecPedido = lobjRespuesta.FecPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidoencabezado);
        }

        public ActionResult detallepedidoencabezado(int id)
        {
            PA_Pedidoencabezado_MostrarDetallexid_Result lobjRespuesta = new PA_Pedidoencabezado_MostrarDetallexid_Result();
            PedidoEnCab objpedidoencabezado = new PedidoEnCab();
            try
            {
                lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezadoxid(id);
                objpedidoencabezado.IdPedido = id;
                objpedidoencabezado.idCliente = lobjRespuesta.IdCliente;
                objpedidoencabezado.FecPedido = lobjRespuesta.FecPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objpedidoencabezado);
        }

        [HttpPost]
        public ActionResult acciones(string submitbutton, PedidoEnCab ppedidoencabezado)
        {
            try
            {
                switch (submitbutton)
                {
                    case "Agregar":
                        return ingresapedidoencabezado(ppedidoencabezado);

                    case "Modificar":
                        return actualizarpedidoencabezado(ppedidoencabezado);

                    case "Eliminar":
                        return eliminarpedidoencabezado(ppedidoencabezado);

                    default:
                        return RedirectToAction("listarpedidoencabezado");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult ingresapedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                if (objpedidoencabezadoLN.insertarpedidoencabezado(ppedidoencabezado))
                {
                    lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezado();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidoencabezado", lobjRespuesta);
        }

        public ActionResult actualizarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                if (objpedidoencabezadoLN.actualizarpedidoencabezado(ppedidoencabezado))
                {
                    lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezado();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidoencabezado", lobjRespuesta);
        }

        public ActionResult eliminarpedidoencabezado(PedidoEnCab ppedidoencabezado)
        {
            List<PA_Pedidoencabezado_MostrarDetalle_Result> lobjRespuesta = new List<PA_Pedidoencabezado_MostrarDetalle_Result>();
            try
            {
                if (objpedidoencabezadoLN.eliminarpedidoencabezado(ppedidoencabezado))
                {
                    lobjRespuesta = objpedidoencabezadoLN.mostrarpedidoencabezado();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarpedidoencabezado", lobjRespuesta);
        }
    }
}