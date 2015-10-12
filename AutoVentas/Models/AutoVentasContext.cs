namespace AutoVentas.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutoVentasContext : DbContext
    {
        public AutoVentasContext()
            : base("name=BD_Auto_Ventas")
        {
        }

        public virtual DbSet<Color> Colores { get; set; }
        public virtual DbSet<Combustible> Combustibles { get; set; }
        public virtual DbSet<Equipamiento> Equipamientos { get; set; }
        public virtual DbSet<Estilo> Estilos { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Modelo> Modelos { get; set; }
        public virtual DbSet<Moneda> Monedas { get; set; }
        public virtual DbSet<Provincia> Provincias { get; set; }
        public virtual DbSet<Tipo_Cuenta> Tipos_Cuentas { get; set; }
        public virtual DbSet<Transmision> Transmisiones { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Codigo_Html)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Colores)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combustible>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Combustible>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Combustibles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equipamiento>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Equipamiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Equipamiento>()
                .HasMany(e => e.Vehiculos)
                .WithMany(e => e.Equipamientos)
                .Map(m => m.ToTable("VEHICULOS_EQUIPAMIENTOS").MapLeftKey("Codigo_Equipamiento").MapRightKey("Codigo_Vehiculo"));

            modelBuilder.Entity<Estilo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estilo>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Estilos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.Modelos)
                .WithRequired(e => e.Marcas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Modelos)
                .HasForeignKey(e => new { e.Codigo_Marca, e.Codigo_Modelo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Monedas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Provincias)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Cuenta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Cuenta>()
                .HasMany(e => e.Usuarios)
                .WithRequired(e => e.Tipos_Cuentas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transmision>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Transmision>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Transmision>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Transmisiones)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono_Casa)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono_Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono_Celular)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .HasMany(e => e.Vehiculos)
                .WithRequired(e => e.Usuarios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Placa)
                .IsUnicode(false);

            modelBuilder.Entity<Vehiculo>()
                .Property(e => e.Comentario)
                .IsUnicode(false);
        }
    }
}
