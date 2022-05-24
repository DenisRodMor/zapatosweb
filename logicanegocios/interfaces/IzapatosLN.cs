using entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logicanegocios.interfaces
{
   public  interface IzapatosLN
    {

        List<PA_Zapato_MostrarDetalles_Result> mostrarzapatos();

            PA_Zapatos_MostrarDetallexid_Result mostrarzapatosxid(int pidzapatos);

        bool insertarzapatos(Zapatos pzapatos);

        bool actualizarzapatos(Zapatos pzapatos);

        bool eliminarzapatos(Zapatos pzapatos);
    }
}
