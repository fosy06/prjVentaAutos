namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Combustible
    {
        public Combustible()
        {
            VEHICULOS = new HashSet<Vehiculo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Codigo_Combustible { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual ICollection<Vehiculo> VEHICULOS { get; set; }
    }
}
