using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Mvc_App_Crud.Models;

namespace Mvc_App_Crud.Contexto
{
    public class VendaContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public VendaContext(DbContextOptions<VendaContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();

                optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            }

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }

}
