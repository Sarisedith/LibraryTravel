
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryTravel.Domain.Models
{
    public class Autores_Has_Libros
    {
        [Key]
        public int Autores_Has_Libros_Id { get; set; }
        public int Autores_Id { get; set; }
        public int Libros_ISBN { get; set; }
    }
}
