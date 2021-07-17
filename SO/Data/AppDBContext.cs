using SO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SO.Data
{
    public class AppDBContext : DbContext
    {
        //Esto es para tener acceso a los modelos de las clases, es como el 
        public AppDBContext() : base("DefaultConnection")
        {

        }

        public DbSet<ProductoCategoria> ProductoCategorias { get; set; }
        public DbSet<DetalleCompra> DetalleCompras { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}