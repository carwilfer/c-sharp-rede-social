using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Aplicacao.Servicos;
using RedeSocial.Dominio.Repositorio;

namespace RedeSocial.Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        public PostsController(IPostServices postServices)
        {
            PostServices = postServices;
        }

        public IPostServices PostServices { get; }

        [HttpGet]
        public IActionResult Get()
        {
            var posts = PostServices.ObterTodosPosts();

            return Ok(posts);
        }

        [HttpPost]
        public void Post([FromBody]PostRequest request)
        {
            PostServices.CriarPost(request);
        }
    }
}
