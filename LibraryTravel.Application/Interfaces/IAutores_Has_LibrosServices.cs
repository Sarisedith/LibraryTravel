using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Interfaces
{
    public interface IAutores_Has_LibrosServices
    {
        Task<Autores_Has_Libros> CreateAutor_Libro(int AutorId, int ISBN);
    }
}
