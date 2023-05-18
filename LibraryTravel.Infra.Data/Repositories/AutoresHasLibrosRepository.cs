using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using LibraryTravel.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Infra.Data.Repositories
{
    public class AutoresHasLibrosRepository : IAutor_Has_LibrosRepository
    {
        public LibraryDbContext context;
        public AutoresHasLibrosRepository(LibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<Autores_Has_Libros> CreateAutor_Libro(int AutorId, int ISBN)
        {
            Autores_Has_Libros autores_Has_Libros = new Autores_Has_Libros();
            autores_Has_Libros.Autores_Id = AutorId;
            autores_Has_Libros.Libros_ISBN = ISBN;
            context.Autores_Has_Libros.Add(autores_Has_Libros);
            await context.SaveChangesAsync();
            return autores_Has_Libros;
        }
    }
}
