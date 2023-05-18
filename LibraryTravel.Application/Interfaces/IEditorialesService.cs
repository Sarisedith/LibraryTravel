using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Interfaces
{
    public interface IEditorialesService
    {
        Task<EditorialesViewModel> GetEditoriales();
        Task<IEnumerable<Editoriales>> GetEditorialesAll();
        Task<Editoriales> GetEditorial(int EditorialeId);
        Task<Editoriales> CreateEditoriales(Editoriales editoriales);
        Task<Editoriales> UpdateEditoriales(Editoriales editoriales);
        void DeleteEditoriales(int id);
    }
}
