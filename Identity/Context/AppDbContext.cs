using Microsoft.EntityFrameworkCore;
using Identity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Identity.Context
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        {  }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    AlunoId = 1,
                    Nome = "Henrique",
                    Email = "henrique@gmail.com",
                    Idade = 22,
                    Curso = "C#/.NET"
                });
        }
    }
}
