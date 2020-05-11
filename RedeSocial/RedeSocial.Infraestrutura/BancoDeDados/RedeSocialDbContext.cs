using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Dominio;

namespace RedeSocial.Infraestrutura.BancoDeDados
{
    public class RedeSocialDbContext : DbContext
    {
        public RedeSocialDbContext(DbContextOptions<RedeSocialDbContext> options)
            : base(options)
        {
        }

        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}
