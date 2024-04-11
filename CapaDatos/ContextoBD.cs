using CapaEntidades;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CapaDatos
{
    public partial class ContextoBD : DbContext
    {
        public ContextoBD()
            : base(ConfigurationMannager.Connection)
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Ventas> Ventas { get; set; }   
        public virtual DbSet<Producto> Productos { get; set; }     
        public virtual DbSet<DetalleVenta> DetalleVentas { get; set; }

    }
}
