using System.ComponentModel.DataAnnotations.Schema;

namespace MonoGamingStore.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column("Id")]
        public int Id { get; set; }

        [Column("Mensaje")]
        public string Mensaje { get; set; }
    }
}