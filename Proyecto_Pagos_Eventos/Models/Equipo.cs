//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Pagos_Eventos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Equipo
    {
        public Equipo()
        {
            this.Servicio = new HashSet<Servicio>();
        }
    
        public System.Guid idEquipo { get; set; }
        public string tipo { get; set; }
        public string descripcion { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<decimal> monto { get; set; }
    
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}
