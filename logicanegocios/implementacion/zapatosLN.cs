using accesodatos;
using accesodatos.implementacion;
using accesodatos.interfaces;
using entidades;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;

namespace logicanegocios.implementacion
{
    public class zapatosLN : IzapatosLN
    {
        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly IzapatosAD objzapatosAD = new zapatosAD(gobjContextoZW);

        public List<PA_Zapato_MostrarDetalles_Result> mostrarzapatos()
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {
                lobjRespuesta = objzapatosAD.mostrarzapatos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_Zapatos_MostrarDetallexid_Result mostrarzapatosxid(int pidzapatos)
        {
            PA_Zapatos_MostrarDetallexid_Result lobjRespuesta = new PA_Zapatos_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = objzapatosAD.mostrarzapatosxid(pidzapatos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertarzapatos(Zapatos pzapatos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objzapatosAD.insertarzapatos(pzapatos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool actualizarzapatos(Zapatos pzapatos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objzapatosAD.actualizarzapatos(pzapatos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool eliminarzapatos(Zapatos pzapatos)
        {
            bool lobjRespuesta = false;
            try
            {
                lobjRespuesta = objzapatosAD.eliminarzapatos(pzapatos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

    }
}
