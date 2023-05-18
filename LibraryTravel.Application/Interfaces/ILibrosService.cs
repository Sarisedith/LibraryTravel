using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Interfaces
{
    public interface ILibrosService
    {
        Task<LibrosViewModel> GetLibros();
        Task<Libros> GetLibro(int id);
        Task<Libros> CreateLibro(Libros libros);
        Task<Libros> UpdateLibro(Libros libros);
        void DeleteLibro(int id);
    }
}
