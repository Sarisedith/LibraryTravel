using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Interfaces
{
    public interface IAutoresService
    {
        Task<AutoresViewModel> GetAutores();
        Task<IEnumerable<Autores>> GetAutoresAll();
        Task<Autores> GetAutor(int id);
        Task<Autores> CreateAutores(Autores autores);
        Task<Autores> UpdateAutores(Autores autores);
        void DeleteAutor(int id);
    }
}
