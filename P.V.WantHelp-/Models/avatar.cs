//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace P.V.WantHelp_.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class avatar
    {
        public int id_avatar { get; set; }
        public string direccion { get; set; }
        public string urlBase { get; set; }
        public string urlHost { get; set; }
        public int Id_Usu { get; set; }
    
        public virtual Usuario Usuario { get; set; }
    }
}