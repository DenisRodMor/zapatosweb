using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace accesodatos.implementacion
{
    public class tipozapatoAD : ItipozapatoAD
    {
        private zapatoswebEntidades gobjContextoZW;

        public tipozapatoAD(zapatoswebEntidades _gobjContextoZ)
        {
            gobjContextoZW = _gobjContextoZ;
        }

        public List<PA_TipoZapato_MostrarDetalle_Result> mostrartipozapato()
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_TipoZapato_MostrarDetalle().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;

        }

        public PA_TipoZapato_MostrarDetallexid_Result mostrartipozapatoxid(int pidtipozapato)
        {
            PA_TipoZapato_MostrarDetallexid_Result lobjRespuesta = new PA_TipoZapato_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_TipoZapato_MostrarDetallexid(pidtipozapato).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertartipozapato(TipoZapato ptipozapato)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_TipoZapato_insertar(ptipozapato.DscTipoZapato) == 1)
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

        public bool actualizartipozapato(TipoZapato ptipozapato)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_TipoZapato_actualizar(ptipozapato.IdTipoZapato, ptipozapato.DscTipoZapato) == 1)
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

        public bool eliminartipozapato(TipoZapato ptipozapato)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_TipoZapato_eliminar(ptipozapato.IdTipoZapato) == 1)
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
