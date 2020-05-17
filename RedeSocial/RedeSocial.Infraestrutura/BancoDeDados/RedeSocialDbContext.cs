using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using RedeSocial.Dominio.Modelo;

namespace RedeSocial.Infraestrutura.BancoDeDados
{
    public class RedeSocialDbContext : DbContext
    {
        public RedeSocialDbContext()
        {

        }

        public RedeSocialDbContext(DbContextOptions<RedeSocialDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb;Database=RedeSocialDbContext;Trusted_Connection=True;MultipleActiveResultSets=true";

            optionsBuilder.UseSqlServer(connectionString);

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Post> Post { get; set; }
    }
}
