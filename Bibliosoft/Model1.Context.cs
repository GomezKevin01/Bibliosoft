﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliosoft
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class biblioteca1Entities : DbContext
    {
        public biblioteca1Entities()
            : base("name=biblioteca1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<libross> libross { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<socioss> socioss { get; set; }
        public virtual DbSet<autores> autores { get; set; }
        public virtual DbSet<empleados> empleados { get; set; }
        public virtual DbSet<prestamos> prestamos { get; set; }
        public virtual DbSet<detallePrestamo> detallePrestamo { get; set; }
        public virtual DbSet<prestamosPorSocio> prestamosPorSocio { get; set; }
        public virtual DbSet<verPrestamos> verPrestamos { get; set; }
        public virtual DbSet<vistaLibros> vistaLibros { get; set; }
        public virtual DbSet<vistaEmpleados> vistaEmpleados { get; set; }
        public virtual DbSet<vistaSocios> vistaSocios { get; set; }
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<prestamosPersistente> prestamosPersistente { get; set; }
    }
}