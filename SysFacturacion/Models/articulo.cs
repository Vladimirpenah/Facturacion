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

    public partial class articulo
    {
        [DisplayName("ID del Articulo")]
        [Key]
        public int IdArticulo { get; set; }

        [DisplayName("Descripci�n")]
        [Required(ErrorMessage = "Description es requerido.")]
        public string DescripcionArticulo { get; set; }

        [DisplayName("Precio Unitario")]
        [Required(ErrorMessage = "Precio Unitario es requerido.")]
        public Nullable<decimal> PrecioUnitario { get; set; }
        
        public string Estado { get; set; }
    }
}