using System.ComponentModel.DataAnnotations.Schema;

namespace MonoGamingStore.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductoId")]
        public int ProductoId { get; set; }

        [Column("Nombre")]
        public string Nombre { get; set; }

        [Column("Foto")]
        public string Foto { get; set; }

        [Column("Detalle")]
        public string Detalle { get; set; }

        [Column("Precio")]
        public double Precio { get; set; }

        [Column("Categoria")]
        public string Categoria { get; set; }
    }
}