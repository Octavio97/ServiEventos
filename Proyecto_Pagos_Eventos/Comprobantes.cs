//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Pagos_Eventos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comprobantes
    {
        public System.Guid idComprobante { get; set; }
        public Nullable<System.Guid> idCliente { get; set; }
        public Nullable<System.Guid> idUsuario { get; set; }
        public Nullable<System.Guid> idServicio { get; set; }
        public Nullable<decimal> monto { get; set; }
        public Nullable<bool> pagado { get; set; }
        public Nullable<bool> activo { get; set; }
        public Nullable<System.DateTime> fechaInicio { get; set; }
        public Nullable<System.DateTime> fechaFinal { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Servicio Servicio { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
