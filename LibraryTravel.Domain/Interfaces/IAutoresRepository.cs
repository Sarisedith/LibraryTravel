using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Domain.Interfaces
{
    public interface IAutoresRepository
    {
        Task<IEnumerable<Autores>> GetAutores();
        Task<IEnumerable<Autores>> GetAutoresAll();
        Task<Autores> CreateAutores(Autores autores);
        void DeleteAutor(int id);
        Task<Autores> GetAutor(int id);
        Task<Autores> UpdateAutores(Autores autores);
    }
}
