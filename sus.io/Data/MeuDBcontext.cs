using Microsoft.EntityFrameworkCore;
using sus.io.Models;

namespace sus.io.Data
{
    public class MeuDBcontext : DbContext
    {
        public MeuDBcontext(DbContextOptions<MeuDBcontext> options)
        :base(options)
        {

        }


        public DbSet<aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
