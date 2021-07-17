using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SO.Models
{
    public class DetalleCompra
    {
        [Key]

        public int IdDetalleCompra { get; set; }
        [Required]                
        public int Codigo { get; set; }

        [Required]
        public double PrecioUnitario { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public double Importe { get; set; }

        public double Descuento { get; set; }

        

        public virtual Producto Producto { get; set; }
    }
}