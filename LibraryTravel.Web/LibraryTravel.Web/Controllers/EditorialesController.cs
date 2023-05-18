using LibraryTravel.Application.Interfaces;
using LibraryTravel.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LibraryTravel.Web.Controllers
{
    [Authorize]
    public class EditorialesController : Controller
    {
        private IEditorialesService editorialesService;
        public EditorialesController(IEditorialesService editorialesService)
        {
            this.editorialesService = editorialesService;
        }
        // GET: ProjectController
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await this.editorialesService.GetEditoriales());
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al consultar las editoriales :{ex.Message}");
            }
        }
        // GET: LibrosController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("El id no puede ser nulo.");
                }
                return View(await this.editorialesService.GetEditorial(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar obtener la editorial :{ex.Message}");
            }
        }
        // GET: LibrosController/Create
        public ActionResult Create()
        {
            return View();
        }
        // POST: LibrosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Editoriales editoriales)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await this.editorialesService.CreateEditoriales(editoriales);
                    return RedirectToAction("Index");
                }
                return View(editoriales);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar guardar la editorial :{ex.Message}");
            }
        }
        // GET: LibrosController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.editorialesService.GetEditorial(id));
        }
        // POST: LibrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Editoriales editoriales)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await this.editorialesService.UpdateEditoriales(editoriales);
                    return RedirectToAction("Index");
                }
                return View(editoriales);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar editar la editorial :{ex.Message}");
            }
        }
        // GET: LibrosController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.editorialesService.GetEditorial(id));
        }
        // POST: LibrosController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                if (id == 0)
                {
                    return BadRequest("El id no puede ser nulo.");
                }
                this.editorialesService.DeleteEditoriales(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar eliminar la editorial :{ex.Message}");
            }
        }

    }
}