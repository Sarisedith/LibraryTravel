using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Domain.Interfaces
{
    public interface IEditorialesRepository
    {
        Task<IEnumerable<Editoriales>> GetEditoriales();
        Task<IEnumerable<Editoriales>> GetEditorialesAll();
        Task<Editoriales> GetEditorial(int editorialeId);
        Task<Editoriales> CreateEditoriales(Editoriales editoriales);
        void DeleteEditoriales(int id);
        Task<Editoriales> UpdateEditoriales(Editoriales editoriales);
    }
}
