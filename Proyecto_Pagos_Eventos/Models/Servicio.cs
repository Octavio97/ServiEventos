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
    
    public partial class Servicio
    {
        public int idG { get; set; }
        public Nullable<System.Guid> idServicio { get; set; }
        public Nullable<System.Guid> idEquipo { get; set; }
    
        public virtual Equipo Equipo { get; set; }
    }
}
