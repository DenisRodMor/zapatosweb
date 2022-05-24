using entidades;
using logicanegocios.implementacion;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Zapatos_web.Controllers
{
    public class zapatosController : Controller
    {
        private IzapatosLN objzapatosLN = new zapatosLN();


        public ActionResult listarzapatos()
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {
               lobjRespuesta= objzapatosLN.mostrarzapatos();
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return View(lobjRespuesta);
        }

        public ActionResult agregazapato()
        {
            return View();
        }

        public ActionResult modificazapato(int id)
        {

            PA_Zapatos_MostrarDetallexid_Result lobjRespuesta = new PA_Zapatos_MostrarDetallexid_Result();
            Zapatos objzapato = new Zapatos();

            try
            {
                lobjRespuesta = objzapatosLN.mostrarzapatosxid(id);
                objzapato.idTipoZapato = id;
                objzapato.DscZapato = lobjRespuesta.DscZapato;
                objzapato.idTipoZapato = lobjRespuesta.IdTipoZapato;
                objzapato.color = lobjRespuesta.Color;
                objzapato.precio = lobjRespuesta.Precio;
                objzapato.cantExistencia = lobjRespuesta.CantExistencia;
                objzapato.IdTalla = lobjRespuesta.IdTalla;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objzapato);
        }

        public ActionResult eliminazapato(int id)
        {

            PA_Zapatos_MostrarDetallexid_Result lobjRespuesta = new PA_Zapatos_MostrarDetallexid_Result();
            Zapatos objzapato = new Zapatos();

            try
            {
                lobjRespuesta = objzapatosLN.mostrarzapatosxid(id);
                objzapato.idTipoZapato = id;
                objzapato.DscZapato = lobjRespuesta.DscZapato;
                objzapato.idTipoZapato = lobjRespuesta.IdTipoZapato;
                objzapato.color = lobjRespuesta.Color;
                objzapato.precio = lobjRespuesta.Precio;
                objzapato.cantExistencia = lobjRespuesta.CantExistencia;
                objzapato.IdTalla = lobjRespuesta.IdTalla;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objzapato);
        }

        public ActionResult detallezapato(int id)
        {

            PA_Zapatos_MostrarDetallexid_Result lobjRespuesta = new PA_Zapatos_MostrarDetallexid_Result();
            Zapatos objzapato = new Zapatos();

            try
            {
                lobjRespuesta = objzapatosLN.mostrarzapatosxid(id);
                objzapato.idTipoZapato = id;
                objzapato.DscZapato = lobjRespuesta.DscZapato;
                objzapato.idTipoZapato = lobjRespuesta.IdTipoZapato;
                objzapato.color = lobjRespuesta.Color;
                objzapato.precio = lobjRespuesta.Precio;
                objzapato.cantExistencia = lobjRespuesta.CantExistencia;
                objzapato.IdTalla = lobjRespuesta.IdTalla;
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return View(objzapato);
        }

        [HttpPost]
        public ActionResult acciones(string submitButton, Zapatos pzapatos)
        {

            try
            {
                switch (submitButton)
                {

                    case "Agregar":
                        return ingresarzapato(pzapatos);

                    case "Modificar":
                        return actualizarzapato(pzapatos);

                    case "Eliminar":
                        return eliminarzapato(pzapatos);
                    default:
                        return RedirectToAction("listarzapatos");

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public ActionResult ingresarzapato(Zapatos pzapatos)
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {

                if (objzapatosLN.insertarzapatos(pzapatos))
                {
                    lobjRespuesta = objzapatosLN.mostrarzapatos();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarzapatos", lobjRespuesta);
        }

        public ActionResult actualizarzapato(Zapatos pzapatos)
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {

                if (objzapatosLN.actualizarzapatos(pzapatos))
                {
                    lobjRespuesta = objzapatosLN.mostrarzapatos();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarzapatos", lobjRespuesta);
        }

        public ActionResult eliminarzapato(Zapatos pzapatos)
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {

                if (objzapatosLN.eliminarzapatos(pzapatos))
                {
                    lobjRespuesta = objzapatosLN.mostrarzapatos();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return View("listarzapatos", lobjRespuesta);
        }
    }
}