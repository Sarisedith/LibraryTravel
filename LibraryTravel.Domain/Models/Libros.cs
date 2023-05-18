using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Domain.Models
{
    public class Libros
    {
        [Key]
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Sinopsis { get; set; }
        public string N_Paginas { get; set; }
        public int EditorialesId { get; set; }
    }
}
