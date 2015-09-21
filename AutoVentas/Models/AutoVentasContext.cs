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

        public virtual DbSet<Color> COLORES { get; set; }
        public virtual DbSet<Combustible> COMBUSTIBLES { get; set; }
        public virtual DbSet<Equipamientos> EQUIPAMIENTOS { get; set; }
        public virtual DbSet<Estilo> ESTILOS { get; set; }
        public virtual DbSet<Marca> MARCAS { get; set; }
        public virtual DbSet<Modelo> MODELOS { get; set; }
        public virtual DbSet<Moneda> MONEDAS { get; set; }
        public virtual DbSet<Provincia> PROVINCIAS { get; set; }
        public virtual DbSet<Tipo_Cuenta> TIPOS_CUENTAS { get; set; }
        public virtual DbSet<Transmision> TRANSMISIONES { get; set; }
        public virtual DbSet<Usuario> USUARIOS { get; set; }
        public virtual DbSet<Vehiculo> VEHICULOS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Color>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .Property(e => e.Codigo_Html)
                .IsUnicode(false);

            modelBuilder.Entity<Color>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.COLORES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Combustible>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Combustible>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.COMBUSTIBLES)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Equipamientos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Equipamientos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Equipamientos>()
                .HasMany(e => e.VEHICULOS)
                .WithMany(e => e.EQUIPAMIENTOS)
                .Map(m => m.ToTable("VEHICULOS_EQUIPAMIENTOS").MapLeftKey("Codigo_Equipamiento").MapRightKey("Codigo_Vehiculo"));

            modelBuilder.Entity<Estilo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Estilo>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.ESTILOS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Marca>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Marca>()
                .HasMany(e => e.MODELOS)
                .WithRequired(e => e.MARCAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Modelo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Modelo>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.MODELOS)
                .HasForeignKey(e => new { e.Codigo_Marca, e.Codigo_Modelo })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.MONEDAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Provincia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Provincia>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.PROVINCIAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tipo_Cuenta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tipo_Cuenta>()
                .HasMany(e => e.USUARIOS)
                .WithRequired(e => e.TIPOS_CUENTAS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transmision>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Transmision>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Transmision>()
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.TRANSMISIONES)
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
                .HasMany(e => e.VEHICULOS)
                .WithRequired(e => e.USUARIOS)
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
