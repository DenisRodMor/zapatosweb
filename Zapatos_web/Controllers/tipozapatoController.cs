using logicanegocios.implementacion;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using entidades;

namespace Zapatos_web.Controllers
{
    public class tipozapatoController : Controller
    {

        private ItipozapatoLN objtipozapatoLN = new tipozapatoLN();
        // GET: tipozapato
        public ActionResult listartipozapato()
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();

            try
            {
                lobjRespuesta= objtipozapatoLN.mostrartipozapato();
            }
            catch(Exception ex)
            {
                throw ex;
            }


            return View(lobjRespuesta);
        }

        public ActionResult agregatipozapato()
        {
            return View();
        }

        public ActionResult modificatipozapato(int id)
        {

          PA_TipoZapato_MostrarDetallexid_Result lobjRespuesta = new PA_TipoZapato_MostrarDetallexid_Result();
            TipoZapato objtipozapato = new TipoZapato();

            try
            {
                lobjRespuesta = objtipozapatoLN.mostrartipozapaotoxid(id);
                objtipozapato.IdTipoZapato = id;
                objtipozapato.DscTipoZapato = lobjRespuesta.DscTipoZapato;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtipozapato);
        }

        public ActionResult eliminatipozapato(int id)
        {

            PA_TipoZapato_MostrarDetallexid_Result lobjRespuesta = new PA_TipoZapato_MostrarDetallexid_Result();
            TipoZapato objtipozapato = new TipoZapato();

            try
            {
                lobjRespuesta = objtipozapatoLN.mostrartipozapaotoxid(id);
                objtipozapato.IdTipoZapato = id;
                objtipozapato.DscTipoZapato = lobjRespuesta.DscTipoZapato;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtipozapato);
        }

        public ActionResult detalletipozapato(int id)
        {

            PA_TipoZapato_MostrarDetallexid_Result lobjRespuesta = new PA_TipoZapato_MostrarDetallexid_Result();
            TipoZapato objtipozapato = new TipoZapato();

            try
            {
                lobjRespuesta = objtipozapatoLN.mostrartipozapaotoxid(id);
                objtipozapato.IdTipoZapato = id;
                objtipozapato.DscTipoZapato = lobjRespuesta.DscTipoZapato;


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objtipozapato);
        }


        [HttpPost]
        public ActionResult acciones(string submitButton, TipoZapato ptipozapato)
        {

            try
            {
              switch(submitButton)
                {

                    case "Agregar":
                        return ingresartipozapato(ptipozapato);

                    case "Modificar":
                        return actualizartipozapato(ptipozapato);

                    case "Eliminar":
                        return  eliminartipozapato(ptipozapato);
                    default:
                        return RedirectToAction("listartipozapato");

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult ingresartipozapato(TipoZapato ptipozapato)
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();
            try
            {

              if(  objtipozapatoLN.insertartipozapato(ptipozapato))
                {
                    lobjRespuesta = objtipozapatoLN.mostrartipozapato();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartipozapato", lobjRespuesta);
        }

        public ActionResult actualizartipozapato(TipoZapato ptipozapato)
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();
            try
            {

                if (objtipozapatoLN.actualizartipozapato(ptipozapato))
                {
                    lobjRespuesta = objtipozapatoLN.mostrartipozapato();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartipozapato", lobjRespuesta);
        }

        public ActionResult eliminartipozapato(TipoZapato ptipozapato)
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();
            try
            {

                if (objtipozapatoLN.eliminartipozapato(ptipozapato))
                {
                    lobjRespuesta = objtipozapatoLN.mostrartipozapato();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listartipozapato", lobjRespuesta);
        }
    }
}