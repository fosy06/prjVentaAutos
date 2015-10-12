namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Modelo
    {
        public Modelo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        [Key]
        [Column(Order = 0)]
        public byte Codigo_Marca { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Codigo_Modelo { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual Marca Marcas { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
