using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SO.Models
{
    public class Producto
    {

        [Key]
        public int Codigo { get; set; }

        [Required]
        [StringLength(100,MinimumLength =5)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 5)]
        public string Descripcion { get; set; }

        [Required]      
        public double Precio { get; set; }

        [Required]        
        public double Alto { get; set; }

        [Required]
        public double Ancho { get; set; }

        [Required]
        public double Largo { get; set; }

        [Required]
        [Url]
        public string Imagen { get; set; }

        [Required]
        public DateTime FechaIngreso{ get; set; }

        

    }
}