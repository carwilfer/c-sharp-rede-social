using Microsoft.EntityFrameworkCore;
using RedeSocial.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedeSocial.Aplicacao.Servicos
{
    public class PostServices
    {
        public PostServices(IPostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public IPostRepository PostRepository { get; }

        public void CriarPost(PostRequest postData)
        {
            var post = new Post();
            post.Texto = postData.Texto;
            post.UrlFoto = postData.UrlImagem;

            PostRepository.Salvar(post);
        }
    }
}
