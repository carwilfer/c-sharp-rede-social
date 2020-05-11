using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedeSocial.Dominio;

namespace RedeSocial.Aplicacao.Data
{
    public class RedeSocialDbContext : DbContext
    {
        public RedeSocialDbContext (DbContextOptions<RedeSocialDbContext> options)
            : base(options)
        {
        }

        public DbSet<RedeSocial.Dominio.Perfil> Perfil { get; set; }
    }
}
