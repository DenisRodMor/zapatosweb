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
    public class tipozapatoLN : ItipozapatoLN
    {

        public static zapatoswebEntidades gobjContextoZW = new zapatoswebEntidades();
        private readonly ItipozapatoAD objtipozapatoAD = new tipozapatoAD(gobjContextoZW);

        public List<PA_TipoZapato_MostrarDetalle_Result> mostrartipozapato()
        {
            List<PA_TipoZapato_MostrarDetalle_Result> lobjRespuesta = new List<PA_TipoZapato_MostrarDetalle_Result>();
            try
            {
                lobjRespuesta = objtipozapatoAD.mostrartipozapato();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }

        public PA_TipoZapato_MostrarDetallexid_Result mostrartipozapaotoxid(int pidtipozapato)
        {
            PA_TipoZapato_MostrarDetallexid_Result lobjRespuesta = new PA_TipoZapato_MostrarDetallexid_Result();
            try
            {
                lobjRespuesta = objtipozapatoAD.mostrartipozapatoxid(pidtipozapato);
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
                lobjRespuesta = objtipozapatoAD.insertartipozapato(ptipozapato);

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
                lobjRespuesta = objtipozapatoAD.actualizartipozapato(ptipozapato);

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
                lobjRespuesta = objtipozapatoAD.eliminartipozapato(ptipozapato);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lobjRespuesta;
        }
    }
}
