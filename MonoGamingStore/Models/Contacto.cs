using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonoGamingStore.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column ("Id")]
        public int Id { get; set; }
        // [Required(ErrorMessage ="Ingrese un mensaje, no sea tarao")]
        // [Display(Name ="Mensaje")]
        [Column("Mensaje")]
        public string Mensaje { get; set; }
    }
}