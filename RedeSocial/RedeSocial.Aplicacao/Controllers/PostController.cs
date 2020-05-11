using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RedeSocial.Aplicacao.Servicos;
using RedeSocial.Dominio;

namespace RedeSocial.Aplicacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        public PostController(IPostRepository db)
        {
            Db = db;
        }

        public IPostRepository Db { get; }

        // POST: api/Post
        [HttpPost]
        public void Post([FromBody]PostRequest request)
        {
            var postServices = new PostServices(Db);

            postServices.CriarPost(request);
        }
    }
}
