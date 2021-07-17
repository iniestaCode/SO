using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SO.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(60, MinimumLength = 10)]
        public String NombreCategoria { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 10)]
        public String DescripcionCategoria { get; set; }

        [Required]
        public Boolean EstadoCategoria { get; set; } 
                

    }
}