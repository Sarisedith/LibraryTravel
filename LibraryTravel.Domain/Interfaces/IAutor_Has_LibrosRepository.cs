using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Domain.Interfaces
{
    public interface IAutor_Has_LibrosRepository
    {
        Task<Autores_Has_Libros> CreateAutor_Libro(int AutorId, int ISBN);
    }
}
