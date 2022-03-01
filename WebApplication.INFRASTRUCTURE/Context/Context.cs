using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.DOMAIN.Entites;
using WebApplication.INFRA.Map;

namespace WebApplication.INFRA.Context
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public Context()
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>(new PedidoMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);

            base.OnModelCreating(modelBuilder);
        }
    }
}
