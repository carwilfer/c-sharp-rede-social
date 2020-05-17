using RedeSocial.Dominio.Modelo;
using System.Collections;
using System.Collections.Generic;

namespace RedeSocial.Dominio.Repositorio
{
    public interface IPostRepository
    {
        void Salvar(Post post);
        IEnumerable<Post> ObterTodos();
    }
}
