using System.Collections.Generic;
using RedeSocial.Dominio.Modelo;
using RedeSocial.Dominio.Repositorio;

namespace RedeSocial.Infraestrutura.BancoDeDados.Repositorios
{
    public class PostRepositoryEntityFramework : IPostRepository
    {
        public PostRepositoryEntityFramework(RedeSocialDbContext Db)
        {
            this.Db = Db;
        }

        public RedeSocialDbContext Db { get; }

        public IEnumerable<Post> ObterTodos()
        {
            return Db.Post;
        }

        public void Salvar(Post post)
        {
            Db.Post.Add(post);
            Db.SaveChanges();
        }
    }
}