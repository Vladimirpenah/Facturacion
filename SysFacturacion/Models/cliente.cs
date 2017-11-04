//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SysFacturacion.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class cliente
    {

         [Key] 
         [DisplayName("Id del Cliente")]
        public int IdCliente { get; set; }

        [DisplayName("Nombre Comercial")]
        [Required(ErrorMessage = "Nombre Comercial es requerido.")]
        public string NombreComercial { get; set; }

        [DisplayName("Documento de Identificación")]
        [Required(ErrorMessage = "Documento de Identificación requerido.")]
        [StringLength(11, MinimumLength = 10)]
        public string DocIdentificacion { get; set; }
        public string Estado { get; set; }
    }
}
