using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SO.Models
{
    public class ProductoCategoria
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Codigo { get; set; }

        [Required]
        public int IdCategoria { get; set; }

        //Se usarán para navegación
        public virtual Producto Producto { get; set; }

        public virtual Categoria Categoria { get; set; }
    }
}