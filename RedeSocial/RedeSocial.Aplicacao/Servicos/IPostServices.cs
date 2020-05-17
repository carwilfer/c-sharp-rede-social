using RedeSocial.Dominio.Modelo;
using RedeSocial.Dominio.Repositorio;
using System.Collections.Generic;

namespace RedeSocial.Aplicacao.Servicos
{
    public interface IPostServices
    {
        IPostRepository PostRepository { get; }

        void CriarPost(PostRequest postData);
        IEnumerable<Post> ObterTodosPosts();
    }
}