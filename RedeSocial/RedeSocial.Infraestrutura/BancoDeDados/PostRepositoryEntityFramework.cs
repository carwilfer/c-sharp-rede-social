using System;
using RedeSocial.Dominio;

namespace RedeSocial.Infraestrutura.BancoDeDados
{
    public class PostRepositoryEntityFramework : IPostRepository
    {
        public PostRepositoryEntityFramework(RedeSocialDbContext Db)
        {
            this.Db = Db;
        }

        public RedeSocialDbContext Db { get; }

        public void Salvar(Post post)
        {
            Db.Post.Add(post);
            Db.SaveChanges();
        }
    }
}
