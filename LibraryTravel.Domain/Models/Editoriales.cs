
using System.ComponentModel.DataAnnotations;

namespace LibraryTravel.Domain.Models
{
    public class Editoriales
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sede { get; set; }
    }
}
