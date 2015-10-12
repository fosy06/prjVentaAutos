namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Equipamientos = new HashSet<Equipamiento>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Codigo_Vehiculo { get; set; }

        public byte Codigo_Marca { get; set; }

        public short Codigo_Modelo { get; set; }

        public byte Codigo_Estilo { get; set; }

        public byte Codigo_Moneda { get; set; }

        public byte Codigo_Color { get; set; }

        public byte Codigo_Combustible { get; set; }

        public byte Codigo_Transmision { get; set; }

        public byte Codigo_Provincia { get; set; }

        public long Codigo_Usuario { get; set; }

        [Required]
        [StringLength(10)]
        public string Placa { get; set; }

        public short Cilindrada { get; set; }

        public short Anno { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Precio { get; set; }

        public short Kilometraje { get; set; }

        public bool Tipo_Kilometraje { get; set; }

        public bool Inscrito { get; set; }

        public byte Numero_Puertas { get; set; }

        [StringLength(500)]
        public string Comentario { get; set; }

        public DateTime Fecha_Ingreso { get; set; }

        public DateTime? Fecha_Expiracion { get; set; }

        public virtual Color Colores { get; set; }

        public virtual Combustible Combustibles { get; set; }

        public virtual Estilo Estilos { get; set; }

        public virtual Modelo Modelos { get; set; }

        public virtual Moneda Monedas { get; set; }

        public virtual Provincia Provincias { get; set; }

        public virtual Transmision Transmisiones { get; set; }

        public virtual Usuario Usuarios { get; set; }

        public virtual ICollection<Equipamiento> Equipamientos { get; set; }
    }
}
