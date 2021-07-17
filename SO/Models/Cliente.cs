using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SO.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required]    
        [StringLength(50,MinimumLength =1)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string ApellidoUno { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string ApellidoDos { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(70, MinimumLength = 1)]
        public string Estado { get; set; }

        [Required]
        [Phone]
        [StringLength(10, MinimumLength = 10)]
        public string Telefono { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }


    }
}