using Microsoft.EntityFrameworkCore;
using webWhyPark.Models;
namespace webWhyPark.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Add DSet 
        // prop aperte tab
        public DbSet<Estacionamento> Estacionamentos { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<RedeSocial> RedesSociais { get; set; } = null!;
        public DbSet<Cliente> Clientes { get; set; } = null!;


    }
}