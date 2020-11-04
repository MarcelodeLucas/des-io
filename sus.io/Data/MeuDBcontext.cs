using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
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
    }
}
