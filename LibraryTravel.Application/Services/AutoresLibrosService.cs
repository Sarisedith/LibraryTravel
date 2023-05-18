using LibraryTravel.Application.Interfaces;
using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Services
{
    public class AutoresLibrosService : IAutores_Has_LibrosServices
    {
        public IAutor_Has_LibrosRepository autor_Has_LibrosRepository;
        public AutoresLibrosService(IAutor_Has_LibrosRepository autor_Has_LibrosRepository)
        {
            this.autor_Has_LibrosRepository = autor_Has_LibrosRepository;
        }
        public async Task<Autores_Has_Libros> CreateAutor_Libro(int AutorId, int ISBN)
        {
            return await this.autor_Has_LibrosRepository.CreateAutor_Libro(AutorId, ISBN);
        }
    }
}
