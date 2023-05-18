
using System.ComponentModel.DataAnnotations;

namespace LibraryTravel.Domain.Models
{
    public class Autores
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
