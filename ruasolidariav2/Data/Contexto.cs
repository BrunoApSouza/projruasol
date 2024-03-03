using Microsoft.EntityFrameworkCore;
using ruasolidariav2.Controllers;

namespace ruasolidariav2.Data
{
    public class Contexto : DbContext

    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        public DbSet<Voluntario> Voluntario { get; set; }
    }
}
