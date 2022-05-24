
using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace accesodatos.implementacion
{
    public class zapatosAD : IzapatosAD
    {

        private zapatoswebEntidades gobjContextoZW;

        public zapatosAD(zapatoswebEntidades _gobjContextoZW)
        {
            gobjContextoZW = _gobjContextoZW;

        }

        public List<PA_Zapato_MostrarDetalles_Result> mostrarzapatos()
        {
            List<PA_Zapato_MostrarDetalles_Result> lobjRespuesta = new List<PA_Zapato_MostrarDetalles_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Zapato_MostrarDetalles().ToList();
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
                lobjRespuesta = gobjContextoZW.PA_Zapatos_MostrarDetallexid(pidzapatos).FirstOrDefault();
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
                if (gobjContextoZW.PA_Zapatos_insertar(pzapatos.DscZapato, pzapatos.color, pzapatos.precio, pzapatos.cantExistencia, pzapatos.idTipoZapato, pzapatos.IdTalla) == 1)
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

       

       
        public bool actualizarzapatos(Zapatos pzapatos)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Zapatos_Actualizar(pzapatos.DscZapato, pzapatos.idTipoZapato, pzapatos.color, pzapatos.precio, pzapatos.cantExistencia, pzapatos.IdTalla, pzapatos.IdZapato) == 1)
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

        public bool eliminarzapatos(Zapatos pzapatos)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Zapatos_eliminar(pzapatos.IdZapato) == 1)
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
