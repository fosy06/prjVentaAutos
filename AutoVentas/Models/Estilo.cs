namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estilo
    {
        public Estilo()
        {
            VEHICULOS = new HashSet<Vehiculo>();
        }

        [Key]
        public byte Codigo_Estilo { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual ICollection<Vehiculo> VEHICULOS { get; set; }
    }
}
