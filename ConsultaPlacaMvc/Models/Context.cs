using Microsoft.EntityFrameworkCore;

namespace ConsultaPlacaMvc.Models
{
    public class Context : DbContext
    {
        public Context() : base()
        {

        }

        public DbSet<Veiculo> Veiculo { get; set; }

        public DbSet<VeiculosConsulta> VeiculosConsulta { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Placamvc;Integrated Security=true");
        }
    }
}
