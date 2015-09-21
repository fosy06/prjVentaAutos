namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Color
    {
        public Color()
        {
            VEHICULOS = new HashSet<Vehiculo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Codigo_Color { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(10)]
        public string Codigo_Html { get; set; }

        public virtual ICollection<Vehiculo> VEHICULOS { get; set; }
    }
}
