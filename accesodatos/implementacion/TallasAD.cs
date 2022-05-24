using accesodatos.interfaces;
using entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace accesodatos.implementacion
{
    public class TallasAD : ItallasAD 
    {

        private zapatoswebEntidades gobjContextoZW;

        public TallasAD(zapatoswebEntidades _gobjContextoZ)
        {
            gobjContextoZW = _gobjContextoZ;
        }

        public List<PA_Tallas_MostrarDetalle_Result> mostrartallas()
        {
            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Tallas_MostrarDetalle().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;

        }

        public PA_Tallas_MostrarDetallexid_Result mostrartallasxid(int pidtallas)
        {
            PA_Tallas_MostrarDetallexid_Result lobjRespuesta = new PA_Tallas_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = gobjContextoZW.PA_Tallas_MostrarDetallexid(pidtallas).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public bool insertartallas(Tallas ptallas)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Tallas_insertar(ptallas.DscTalla) == 1)
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

        public bool actualizartallas(Tallas ptallas)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Tallas_Actualizar(ptallas.IdTalla, ptallas.DscTalla) == 1)
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

        public bool eliminartallas(Tallas ptallas)
        {
            bool lobjRespuesta = false;
            try
            {
                if (gobjContextoZW.PA_Tallas_eliminar(ptallas.IdTalla) == 1)
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
