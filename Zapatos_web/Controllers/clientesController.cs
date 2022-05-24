using entidades;
using logicanegocios.implementacion;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Zapatos_web.Controllers
{

    public class clientesController : Controller
    {
        private IClientesLN objclientesLN = new ClientesLN();

        public ActionResult listarclientes()
        {

            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objclientesLN.mostrarclientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(lobjRespuesta);
        }

        public ActionResult agregaclientes()
        {

            return View();
        }

        public ActionResult actualizaclientes(int id)
        {
            PA_Clientes_MostrarDetallexid_Result lobjRespuesta = new PA_Clientes_MostrarDetallexid_Result();
            Clientes objclientes = new Clientes();
            try
            {
                lobjRespuesta = objclientesLN.mostrarclientesxid(id);
                objclientes.IdCliente =id;
                objclientes.Nombre = lobjRespuesta.Nombre;
                objclientes.Ap1 = lobjRespuesta.Ap1;
                objclientes.Ap2 = lobjRespuesta.Ap2;
                objclientes.telefono = lobjRespuesta.telefono;
                objclientes.email = lobjRespuesta.email;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objclientes);
        }

        public ActionResult eliminaclientes(int id)
        {
            PA_Clientes_MostrarDetallexid_Result lobjRespuesta = new PA_Clientes_MostrarDetallexid_Result();
            Clientes objclientes = new Clientes();
            try
            {
                lobjRespuesta = objclientesLN.mostrarclientesxid(id);
                objclientes.IdCliente = id;
                objclientes.Nombre = lobjRespuesta.Nombre;
                objclientes.Ap1 = lobjRespuesta.Ap1;
                objclientes.Ap2 = lobjRespuesta.Ap2;
                objclientes.telefono = lobjRespuesta.telefono;
                objclientes.email = lobjRespuesta.email;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objclientes);
        }

        public ActionResult detalleclientes(int id)
        {
            PA_Clientes_MostrarDetallexid_Result lobjRespuesta = new PA_Clientes_MostrarDetallexid_Result();
            Clientes objclientes = new Clientes();
            try
            {
                lobjRespuesta = objclientesLN.mostrarclientesxid(id);
                objclientes.IdCliente = id;
                objclientes.Nombre = lobjRespuesta.Nombre;
                objclientes.Ap1 = lobjRespuesta.Ap1;
                objclientes.Ap2 = lobjRespuesta.Ap2;
                objclientes.telefono = lobjRespuesta.telefono;
                objclientes.email = lobjRespuesta.email;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View(objclientes);
        }


        [HttpPost]
        public ActionResult acciones(string submitbutton, Clientes pclientes)
        {
            try
            {
                switch (submitbutton)
                {
                    case "Agregar":
                        return ingresaclientes(pclientes);

                    case "Modificar":
                        return actualizarclientes(pclientes);

                    case "Eliminar":
                        return eliminarclientes(pclientes);

                    default:
                        return RedirectToAction("listarclientes");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
              
        }

        public ActionResult ingresaclientes(Clientes pclientes)
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
               if(objclientesLN.insertarcliente(pclientes))
                {
                    lobjRespuesta = objclientesLN.mostrarclientes();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarclientes", lobjRespuesta);
        }

        public ActionResult actualizarclientes(Clientes pclientes)
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                if (objclientesLN.actualizarcliente(pclientes))
                {
                    lobjRespuesta = objclientesLN.mostrarclientes();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarclientes", lobjRespuesta);
        }

        public ActionResult eliminarclientes(Clientes pclientes)
        {
            List<PA_Clientes_MostrarDetalle_Result> lobjRespuesta = new List<PA_Clientes_MostrarDetalle_Result>();
            try
            {
                if (objclientesLN.eliminarcliente(pclientes))
                {
                    lobjRespuesta = objclientesLN.mostrarclientes();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarclientes", lobjRespuesta);
        }
    }
}