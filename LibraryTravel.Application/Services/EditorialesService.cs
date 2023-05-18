using LibraryTravel.Application.Interfaces;
using LibraryTravel.Application.ViewModels;
using LibraryTravel.Domain.Interfaces;
using LibraryTravel.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryTravel.Application.Services
{
    public class EditorialesService : IEditorialesService
    {
        public IEditorialesRepository editorialesRepository;
        public EditorialesService(IEditorialesRepository editorialesRepository)
        {
            this.editorialesRepository = editorialesRepository;
        }

        public async Task<Editoriales> CreateEditoriales(Editoriales editoriales)
        {
            return await this.editorialesRepository.CreateEditoriales(editoriales);
        }

        public void DeleteEditoriales(int id)
        {
            this.editorialesRepository.DeleteEditoriales(id);
        }

        public async Task<Editoriales> GetEditorial(int EditorialeId)
        {
            return await editorialesRepository.GetEditorial(EditorialeId);
        }

        public async Task<EditorialesViewModel> GetEditoriales()
        {
            return new EditorialesViewModel()
            {
                Editoriales = await editorialesRepository.GetEditoriales()
            };
        }

        public async Task<IEnumerable<Editoriales>> GetEditorialesAll()
        {
            return await editorialesRepository.GetEditorialesAll();
        }

        public async Task<Editoriales> UpdateEditoriales(Editoriales editoriales)
        {
            return await this.editorialesRepository.UpdateEditoriales(editoriales);
        }
    }
}
