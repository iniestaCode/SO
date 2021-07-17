using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SO.Models
{
    public class Venta
    {
        [Key]
        public int FolioVenta { get; set; }

        [Required]
        public double Subtotal { get; set; }

        [Required]
        public double Descuento { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public DateTime FechaCompra  { get; set; }

        [Required]
        [StringLength(1)]
        public char Status { get; set; }

        public int IdDetalleCompra { get; set; }

        
        public int IdCliente { get; set; }

        public virtual Cliente Cliente { get; set; }

        public virtual DetalleCompra DetalleCompra { get; set; }
    }
}