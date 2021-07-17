namespace SO.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        IdCategoria = c.Int(nullable: false, identity: true),
                        NombreCategoria = c.String(nullable: false, maxLength: 60),
                        DescripcionCategoria = c.String(nullable: false, maxLength: 60),
                        EstadoCategoria = c.Boolean(nullable: false, defaultValue:true),
                    })
                .PrimaryKey(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        IdCliente = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        ApellidoUno = c.String(nullable: false, maxLength: 50),
                        ApellidoDos = c.String(nullable: false, maxLength: 50),
                        Direccion = c.String(nullable: false, maxLength: 100),
                        Ciudad = c.String(nullable: false, maxLength: 70),
                        Estado = c.String(nullable: false, maxLength: 70),
                        Telefono = c.String(nullable: false, maxLength: 10),
                        Correo = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.IdCliente);
            
            CreateTable(
                "dbo.DetalleCompras",
                c => new
                    {
                        IdDetalleCompra = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        PrecioUnitario = c.Double(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Importe = c.Double(nullable: false),
                        Descuento = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IdDetalleCompra)
                .ForeignKey("dbo.Producto", t => t.Codigo, cascadeDelete: true)
                .Index(t => t.Codigo);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 200),
                        Precio = c.Double(nullable: false),
                        Alto = c.Double(nullable: false),
                        Ancho = c.Double(nullable: false),
                        Largo = c.Double(nullable: false),
                        Imagen = c.String(nullable: false),
                        FechaIngreso = c.DateTime(nullable: false, defaultValue: DateTime.Now),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.ProductoCategorias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Int(nullable: false),
                        IdCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.IdCategoria, cascadeDelete: true)
                .ForeignKey("dbo.Producto", t => t.Codigo, cascadeDelete: true)
                .Index(t => t.Codigo)
                .Index(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        FolioVenta = c.Int(nullable: false, identity: true),
                        Subtotal = c.Double(nullable: false),
                        Descuento = c.Double(nullable: false, defaultValue: 0.0),
                        Total = c.Double(nullable: false),
                        FechaCompra = c.DateTime(nullable: false),
                        IdDetalleCompra = c.Int(nullable: false),
                        IdCliente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FolioVenta)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.DetalleCompras", t => t.IdDetalleCompra, cascadeDelete: true)
                .Index(t => t.IdDetalleCompra)
                .Index(t => t.IdCliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "IdDetalleCompra", "dbo.DetalleCompras");
            DropForeignKey("dbo.Ventas", "IdCliente", "dbo.Clientes");
            DropForeignKey("dbo.ProductoCategorias", "Codigo", "dbo.Productoes");
            DropForeignKey("dbo.ProductoCategorias", "IdCategoria", "dbo.Categorias");
            DropForeignKey("dbo.DetalleCompras", "Codigo", "dbo.Productoes");
            DropIndex("dbo.Ventas", new[] { "IdCliente" });
            DropIndex("dbo.Ventas", new[] { "IdDetalleCompra" });
            DropIndex("dbo.ProductoCategorias", new[] { "IdCategoria" });
            DropIndex("dbo.ProductoCategorias", new[] { "Codigo" });
            DropIndex("dbo.DetalleCompras", new[] { "Codigo" });
            DropTable("dbo.Ventas");
            DropTable("dbo.ProductoCategorias");
            DropTable("dbo.Productoes");
            DropTable("dbo.DetalleCompras");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
