using accesodatos;
using accesodatos.implementacion;
using accesodatos.interfaces;
using entidades;
using logicanegocios.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.implementacion
{
   public class TallasLN : ItallasLN
    {
        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly ItallasAD objtallasAD = new TallasAD(gobjContextoZW);

        public List<PA_Tallas_MostrarDetalle_Result> mostrartallas()
        {
            List<PA_Tallas_MostrarDetalle_Result> lobjRespuesta = new List<PA_Tallas_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objtallasAD.mostrartallas();
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
                lobjRespuesta = objtallasAD.mostrartallasxid(pidtallas);
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
                lobjRespuesta = objtallasAD.insertartallas(ptallas);

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
                lobjRespuesta = objtallasAD.actualizartallas(ptallas);

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
                lobjRespuesta = objtallasAD.eliminartallas(ptallas);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

    }
}
