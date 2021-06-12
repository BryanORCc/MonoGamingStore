using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonoGamingStore.Models
{
    [Table("t_producto")]
    public class Producto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("ProductoId")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "Por favor llenar todos los campos")]
        [Column("Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor llenar todos los campos")]
        [Column("Foto")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "Por favor llenar todos los campos")]
        [Column("Detalle")]
        public string Detalle { get; set; }

        [Required(ErrorMessage = "Por favor llenar todos los campos")]
        [Column("Precio")]
        public double Precio { get; set; }

        [Required(ErrorMessage = "Por favor llenar todos los campos")]
        [Column("Categoria")]
        public string Categoria { get; set; }
    }
}