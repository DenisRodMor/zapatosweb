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
    
    public partial class Zapatos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zapatos()
        {
            this.PedidoDet = new HashSet<PedidoDet>();
        }
    
        public int IdZapato { get; set; }
        public string DscZapato { get; set; }
        public Nullable<int> idTipoZapato { get; set; }
        public string color { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> cantExistencia { get; set; }
        public Nullable<int> IdTalla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PedidoDet> PedidoDet { get; set; }
        public virtual Tallas Tallas { get; set; }
        public virtual TipoZapato TipoZapato { get; set; }
    }
}