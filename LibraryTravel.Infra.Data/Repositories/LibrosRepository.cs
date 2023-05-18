using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using LibraryTravel.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryTravel.Infra.Data.Repositories
{
    public class LibrosRepository : ILibrosRepository
    {
        public LibraryDbContext context;
        public LibrosRepository(LibraryDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Libros>> GetLibros()
        {
            return await context.Libros.ToListAsync();
        }
        public async Task<Libros> GetLibro(int id)
        {
            return await context.Libros.Where(x => x.ISBN == id).FirstOrDefaultAsync();
        }
        public async Task<Libros> CreateLibro(Libros libros)
        {
            context.Libros.Add(libros);
            await context.SaveChangesAsync();
            return libros;
        }
        public async Task<Libros> UpdateLibro(Libros libros)
        {
            context.Entry(libros).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return libros;
        }
        public void DeleteLibro(int Id)
        {
            Libros libros = new Libros();
            Autores_Has_Libros autores_Has_Libros= new Autores_Has_Libros();
            libros = context.Libros.Where(x => x.ISBN == Id).FirstOrDefault();
            autores_Has_Libros = context.Autores_Has_Libros.Where(x => x.Libros_ISBN == Id).FirstOrDefault();
            context.Autores_Has_Libros.Remove(autores_Has_Libros);
            context.Libros.Remove(libros);
            context.SaveChanges();
        }
    }
}
