using Microsoft.EntityFrameworkCore;

namespace JslApi.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {

        }

        public DbSet<Motorista> Motorista { get; set; }
        public DbSet<Viagem> Viagem { get; set; }
    }
}
