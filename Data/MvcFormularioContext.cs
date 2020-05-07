using Microsoft.EntityFrameworkCore;
using MvcFormulario.Models;

namespace MvcFormulario.Data
{
    public class MvcFormularioContext : DbContext
    {
        public MvcFormularioContext(DbContextOptions<MvcFormularioContext> options)
            : base(options)
        {
        }

        public DbSet<Formulario> Formulario { get; set; }
    }
}