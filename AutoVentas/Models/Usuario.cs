namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Usuario
    {
        public Usuario()
        {
            VEHICULOS = new HashSet<Vehiculo>();
        }

        [Key]
        public long Codigo_Usuario { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public byte Tipo_Usuario { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        [StringLength(300)]
        public string Contrasena { get; set; }

        [StringLength(30)]
        public string Telefono_Casa { get; set; }

        [StringLength(30)]
        public string Telefono_Oficina { get; set; }

        [StringLength(30)]
        public string Telefono_Celular { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        public byte Codigo_Cuenta { get; set; }

        public DateTime? Fecha_Expira_Cuenta { get; set; }

        public DateTime Fecha_Registro { get; set; }

        public virtual Tipo_Cuenta TIPOS_CUENTAS { get; set; }

        public virtual ICollection<Vehiculo> VEHICULOS { get; set; }
    }
}
