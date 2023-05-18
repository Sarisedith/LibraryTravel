using LibraryTravel.Application.Interfaces;
using LibraryTravel.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Threading.Tasks;

namespace LibraryTravel.Web.Controllers
{
    [Authorize]
    public class LibrosController : Controller
    {
        private ILibrosService librosService;
        private IAutoresService autoresService;
        private IEditorialesService editorialesService;
        private IAutores_Has_LibrosServices autores_Has_LibrosServices;

        public LibrosController(ILibrosService librosService, IAutoresService autoresService, IEditorialesService editorialesService, IAutores_Has_LibrosServices autores_Has_LibrosServices)
        {
            this.librosService = librosService;
            this.autoresService = autoresService;
            this.editorialesService = editorialesService;
            this.autores_Has_LibrosServices = autores_Has_LibrosServices;
        }
        // GET: LibrosController
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await this.librosService.GetLibros());
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar obtener los libros :{ex.Message}");
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
                return View(await this.librosService.GetLibro(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar obtener el libro :{ex.Message}");
            }
        }
        // GET: LibrosController/Create
        public async Task<ActionResult> Create()
        {
            var autores = await autoresService.GetAutoresAll();
            ViewBag.ListAutores = new SelectList(autores, "Id", "Nombre");
            var editoriales = await editorialesService.GetEditorialesAll();
            ViewBag.ListEditoriales = new SelectList(editoriales, "Id", "Nombre");
            return View();
        }
        // POST: LibrosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Libros libros, int dpAutores, int dpEditoriales)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var editorial = await this.editorialesService.GetEditorial(dpEditoriales);
                    libros.EditorialesId = editorial.Id;
                    libros = await this.librosService.CreateLibro(libros);
                    await this.autores_Has_LibrosServices.CreateAutor_Libro(dpAutores, libros.ISBN);
                    return RedirectToAction("Index");
                }
                return View(libros);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar inserta el libro :{ex.Message}");
            }
        }
        // GET: LibrosController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.librosService.GetLibro(id));
        }
        // POST: LibrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Libros libros)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await this.librosService.UpdateLibro(libros);
                    return RedirectToAction("Index");
                }
                return View(libros);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar actualizar el libro :{ex.Message}");
            }
        }
        // GET: LibrosController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.librosService.GetLibro(id));
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
                this.librosService.DeleteLibro(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar eliminar el libro :{ex.Message}");
            }
        }

    }
}