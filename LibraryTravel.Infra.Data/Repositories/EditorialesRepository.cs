using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using LibraryTravel.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Infra.Data.Repositories
{
    public class EditorialesRepository : IEditorialesRepository
    {
        public LibraryDbContext context;
        public EditorialesRepository(LibraryDbContext context)
        {
            this.context = context;
        }

        public async Task<Editoriales> CreateEditoriales(Editoriales editoriales)
        {
            context.Editoriales.Add(editoriales);
            await context.SaveChangesAsync();
            return editoriales;
        }

        public void DeleteEditoriales(int id)
        {
            Editoriales editoriales = new Editoriales();
            editoriales = context.Editoriales.Where(x => x.Id == id).FirstOrDefault();
            context.Editoriales.Remove(editoriales);
            context.SaveChanges();
        }

        public async Task<Editoriales> GetEditorial(int editorialeId)
        {
            return await context.Editoriales.Where(x => x.Id == editorialeId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Editoriales>> GetEditoriales()
        {
            return await context.Editoriales.ToListAsync();
        }

        public async Task<IEnumerable<Editoriales>> GetEditorialesAll()
        {
            return await context.Editoriales.ToListAsync();
        }

        public async Task<Editoriales> UpdateEditoriales(Editoriales editoriales)
        {
            context.Entry(editoriales).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return editoriales;
        }
    }
}
