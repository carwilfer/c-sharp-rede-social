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
        public IRedeSocialApi RedeSocialApi { get; }
        public IArmazenamentoDeFotos ArmazenamentoDeFotos { get; }

        public PostsController(IRedeSocialApi redeSocialApi, IArmazenamentoDeFotos armazenamentoDeFotos)
        {
            RedeSocialApi = redeSocialApi;
            ArmazenamentoDeFotos = armazenamentoDeFotos;
        }

        // GET: Posts
        public ActionResult Index()
        {
            var posts = Posts.Where(x => x.Proprietario == User.Identity.Name);

            return View(Posts);
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            var post = Posts.Find(x => x.Id == id);

            return View(post);
        }


        static List<PostViewModel> Posts = new List<PostViewModel>();

        // POST: Posts/Create
        [HttpPost]
        public ActionResult Create(PostInputModel post, IFormFile foto)
        {
            try
            {
                var uri = ArmazenamentoDeFotos.ArmazenarFotoDoPost(foto);

                post.UrlIagem = uri.ToString();

                RedeSocialApi.Post("post", post);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
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