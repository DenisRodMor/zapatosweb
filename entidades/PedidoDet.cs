//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class PedidoDet
    {
        public int IdPedido { get; set; }
        public Nullable<int> IdZapato { get; set; }
        public Nullable<int> Cantidad { get; set; }
    
        public virtual PedidoEnCab PedidoEnCab { get; set; }
        public virtual Zapatos Zapatos { get; set; }
    }
}