using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Apresentacao.Models.PerfilModels;
using RedeSocial.Apresentacao.Services;
using RedeSocial.Infraestrutura;

namespace RedeSocial.Apresentacao.Controllers
{
    public class PerfilsController : Controller
    {
        public IArmazenamentoDeFotos ArmazenamentoDeFotos { get; }
        public IRedeSocialApi RedeSocialApi { get; }

        public PerfilsController(
            IArmazenamentoDeFotos armazenamentoDeFotos,
            IRedeSocialApi redeSocialApi)
        {
            ArmazenamentoDeFotos = armazenamentoDeFotos;
            RedeSocialApi = redeSocialApi;
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Perfils/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Perfils/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Perfils/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PerfilInputModel model, IFormFile foto)
        {
            try
            {
                var uri = await ArmazenamentoDeFotos.ArmazenarFotoDePerfil(foto);

                model.UrlFoto = uri.AbsoluteUri;

                await RedeSocialApi.Post("perfil", model);

                return RedirectToAction("index", "home");
            }
            catch (Exception)
            {
                return base.ValidationProblem();
            }
        }

        // GET: Perfils/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Perfils/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Perfils/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Perfils/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}