using RedeSocial.Dominio.Modelo;
using RedeSocial.Dominio.Repositorio;
using System.Collections.Generic;

namespace RedeSocial.Aplicacao.Servicos.PostsServices
{
    public interface IPostServices
    {
        IPostRepository PostRepository { get; }

        PostCreateResult CriarPost(PostRequest postData);
        IEnumerable<Post> ObterTodosPosts();
    }
}