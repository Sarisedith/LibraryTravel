using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using LibraryTravel.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryTravel.Infra.Data.Repositories
{
    public class AutoresRepository : IAutoresRepository
    {
        public LibraryDbContext context;
        public AutoresRepository(LibraryDbContext context)
        {
            this.context = context;
        }

        public async Task<Autores> CreateAutores(Autores autores)
        {
            context.Autores.Add(autores);
            await context.SaveChangesAsync();
            return autores;
        }

        public void DeleteAutor(int id)
        {
            Autores autores = new Autores();
            autores = context.Autores.Where(x => x.Id == id).FirstOrDefault();
            context.Autores.Remove(autores);
            context.SaveChanges();
        }

        public async Task<Autores> GetAutor(int id)
        {
            return await context.Autores.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Autores>> GetAutores()
        {
            return await context.Autores.ToListAsync();
        }

        public async Task<IEnumerable<Autores>> GetAutoresAll()
        {
            return await context.Autores.ToListAsync();
        }

        public async Task<Autores> UpdateAutores(Autores autores)
        {
            context.Entry(autores).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return autores;
        }
    }
}
