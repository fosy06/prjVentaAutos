namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Provincia
    {
        public Provincia()
        {
            VEHICULOS = new HashSet<Vehiculo>();
        }

        [Key]
        public byte Codigo_Provincia { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        public virtual ICollection<Vehiculo> VEHICULOS { get; set; }
    }
}
