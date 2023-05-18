using LibraryTravel.Application.Interfaces;
using LibraryTravel.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryTravel.Web.Controllers
{
    [Authorize]
    public class AutoresController : Controller
    {
        private IAutoresService autoresService;
        public AutoresController(IAutoresService autoresService)
        {
            this.autoresService = autoresService;
        }
        // GET: ProjectController
        public async Task<ActionResult> Index()
        {
            try
            {
                return View(await this.autoresService.GetAutores());
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar consultar los autores :{ex.Message}");
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
                return View(await this.autoresService.GetAutor(id));
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar obtener el autor :{ex.Message}");
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
        public async Task<ActionResult> Create(Autores autores)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await this.autoresService.CreateAutores(autores);
                    return RedirectToAction("Index");
                }
                return View(autores);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar crear el autor :{ex.Message}");
            }
        }
        // GET: LibrosController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.autoresService.GetAutor(id));
        }
        // POST: LibrosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Autores autores)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await this.autoresService.UpdateAutores(autores);
                    return RedirectToAction("Index");
                }
                return View(autores);
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar actualizar el autor :{ex.Message}");
            }
        }
        // GET: LibrosController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest("El id no puede ser nulo.");
            }
            return View(await this.autoresService.GetAutor(id));
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
                this.autoresService.DeleteAutor(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return BadRequest($"Se presento un errro al intentar eliminar el autor :{ex.Message}");
            }
        }

    }
}