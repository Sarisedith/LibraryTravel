using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Domain.Interfaces
{
    public interface ILibrosRepository
    {
        Task<IEnumerable<Libros>> GetLibros();
        Task<Libros> GetLibro(int id);
        Task<Libros> CreateLibro(Libros libros);
        Task<Libros> UpdateLibro(Libros libros);
        void DeleteLibro(int Id);
    }
}
