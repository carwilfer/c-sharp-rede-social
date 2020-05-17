using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Aplicacao.Servicos.PostsServices;
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

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody]PostRequest request)
        {
            var result = PostServices.CriarPost(request);

            if (result.Sucesso)
                return Ok();
            else
                return UnprocessableEntity(result.Erros);
        }
    }
}
