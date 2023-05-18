using LibraryTravel.Application.Interfaces;
using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Services
{
    public class LibrosService : ILibrosService
    {
        public ILibrosRepository librosRepository;
        public LibrosService(ILibrosRepository librosRepository)
        {
            this.librosRepository = librosRepository;
        }

        public async Task<Libros> CreateLibro(Libros libros)
        {
            return await this.librosRepository.CreateLibro(libros);
        }

        public void DeleteLibro(int id)
        {
            this.librosRepository.DeleteLibro(id);
        }

        public async Task<Libros> GetLibro(int id)
        {
            return await this.librosRepository.GetLibro(id);
        }

        public async Task<LibrosViewModel> GetLibros()
        {
            return new LibrosViewModel
            {
                Libros = await this.librosRepository.GetLibros()
            };
        }

        public async Task<Libros> UpdateLibro(Libros libros)
        {
            return await this.librosRepository.UpdateLibro(libros);
        }
    }
}
