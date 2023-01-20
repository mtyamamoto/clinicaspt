using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AgendamentoOnline.Models;

namespace AgendamentoOnline.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AgendamentoOnline.Models.Especialidade> Especialidade { get; set; }
        public DbSet<AgendamentoOnline.Models.Especialista> Especialista { get; set; }
    }
}