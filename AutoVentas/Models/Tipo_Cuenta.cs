namespace AutoVentas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tipo_Cuenta
    {
        public Tipo_Cuenta()
        {
            Usuarios = new HashSet<Usuario>();
        }

        [Key]
        public byte Codigo_Cuenta { get; set; }

        [Required]
        [StringLength(25)]
        public string Descripcion { get; set; }

        public byte Cantidad_Carros { get; set; }

        public byte Cantidad_Fotografias { get; set; }

        public bool Anuncio_Ilimitado { get; set; }

        public bool Destacado { get; set; }

        public bool Sugerencias { get; set; }

        public bool Gifs { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Costo_Cuenta { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
