namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Equipamiento
    {
        public Equipamiento()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        [Key]
        public byte Codigo_Equipamiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public byte Tipo_Categoria { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
