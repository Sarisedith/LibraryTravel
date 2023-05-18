using LibraryTravel.Application.Interfaces;
using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Services
{
    public class AutoresService : IAutoresService
    {
        public IAutoresRepository autoresRepository;
        public AutoresService(IAutoresRepository autoresRepository)
        {
            this.autoresRepository = autoresRepository;
        }

        public async Task<Autores> CreateAutores(Autores autores)
        {
            return await this.autoresRepository.CreateAutores(autores);
        }

        public void DeleteAutor(int id)
        {
            this.autoresRepository.DeleteAutor(id);
        }

        public async Task<Autores> GetAutor(int id)
        {
            return await this.autoresRepository.GetAutor(id);
        }

        public async Task<AutoresViewModel> GetAutores()
        {
            return new AutoresViewModel()
            {
                Autores = await autoresRepository.GetAutores()
            };
        }

        public async Task<IEnumerable<Autores>> GetAutoresAll()
        {
            return await autoresRepository.GetAutoresAll();
        }

        public async Task<Autores> UpdateAutores(Autores autores)
        {
            return await this.autoresRepository.UpdateAutores(autores);
        }
    }
}
