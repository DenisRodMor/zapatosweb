using entidades;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using logicanegocios.implementacion;

namespace Zapatos_web.Controllers
{
    public class tallasController : Controller
    {

        private ItallasLN objtallasLN = new TallasLN();
        // GET: tallas
        public ActionResult listartallas()
        {

            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();

            try
            {
                lobjRespuesta = objtallasLN.mostrartallas();
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(lobjRespuesta);
        }

        public ActionResult agregatallas()
        {
            return View();
        }

        public ActionResult modificatallas(int id)
        {

            PA_Tallas_MostrarDetallexid_Result lobjRespuesta = new PA_Tallas_MostrarDetallexid_Result();
            Tallas objtallas = new Tallas();

            try
            {
                lobjRespuesta = objtallasLN.mostrartallasxid(id);
                objtallas.IdTalla = id;
                objtallas.DscTalla = lobjRespuesta.DscTalla;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtallas);
        }

        public ActionResult eliminatallas(int id)
        {

            PA_Tallas_MostrarDetallexid_Result lobjRespuesta = new PA_Tallas_MostrarDetallexid_Result();
            Tallas objtallas = new Tallas();

            try
            {
                lobjRespuesta = objtallasLN.mostrartallasxid(id);
                objtallas.IdTalla = id;
                objtallas.DscTalla = lobjRespuesta.DscTalla;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtallas);
        }

        public ActionResult detalletallas(int id)
        {

            PA_Tallas_MostrarDetallexid_Result lobjRespuesta = new PA_Tallas_MostrarDetallexid_Result();
            Tallas objtallas = new Tallas();

            try
            {
                lobjRespuesta = objtallasLN.mostrartallasxid(id);
                objtallas.IdTalla = id;
                objtallas.DscTalla = lobjRespuesta.DscTalla;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtallas);
        }

        [HttpPost]
        public ActionResult acciones(string submitButton, Tallas ptallas)
        {

            try
            {
                switch (submitButton)
                {

                    case "Agregar":
                        return ingresartallas(ptallas);

                    case "Modificar":
                        return actualizartallas(ptallas);

                    case "Eliminar":
                        return eliminartallas(ptallas);
                    default:
                        return RedirectToAction("listartallas");

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult ingresartallas(Tallas ptallas)
        {
            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();
            try
            {

                if (objtallasLN.insertartallas(ptallas))
                {
                    lobjRespuesta = objtallasLN.mostrartallas();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartallas", lobjRespuesta);
        }

        public ActionResult actualizartallas(Tallas ptallas)
        {
            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();
            try
            {

                if (objtallasLN.actualizartallas(ptallas))
                {
                    lobjRespuesta = objtallasLN.mostrartallas();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartallas", lobjRespuesta);
        }

        public ActionResult eliminartallas(Tallas ptallas)
        {
            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();
            try
            {

                if (objtallasLN.eliminartallas(ptallas))
                {
                    lobjRespuesta = objtallasLN.mostrartallas();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartallas", lobjRespuesta);
        }
    }
}