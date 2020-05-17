using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Apresentacao.Models.PostModels;
using RedeSocial.Apresentacao.Services;
using RedeSocial.Infraestrutura.Arquivos;

namespace RedeSocial.Apresentacao.Controllers
{
    [Authorize]
    public class PostsController : Controller
    {
        private IRedeSocialApi RedeSocialApi { get; }
        private IArmazenamentoDeFotos ArmazenamentoDeFotos { get; }

        public PostsController(IRedeSocialApi redeSocialApi, IArmazenamentoDeFotos armazenamentoDeFotos)
        {
            RedeSocialApi = redeSocialApi;
            ArmazenamentoDeFotos = armazenamentoDeFotos;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var posts = await RedeSocialApi.Get<IEnumerable<PostViewModel>>("posts", null);

            return View(posts);
        }

        [HttpPost]
        public ActionResult Create(PostInputModel post, IFormFile foto)
        {
            //var uri = ArmazenamentoDeFotos.ArmazenarFotoDoPost(foto);

            //post.UrlIagem = uri.ToString();

            post.Proprietario = User.Identity.Name;

            RedeSocialApi.Post("post", post);

            return RedirectToAction(nameof(Index));
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
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