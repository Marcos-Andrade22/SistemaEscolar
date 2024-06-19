using Microsoft.EntityFrameworkCore;
using SistemaEscolar1.Models;

namespace SistemaEscolar1.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Materia> Materias { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Nota> Notas { get; set; }
        public DbSet<ProfessorMateria> ProfessoresMaterias { get; set; } // DbSet para a relação muitos-para-muitos

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurações adicionais do modelo, se necessário
            modelBuilder.Entity<Materia>().ToTable("Materias");
            modelBuilder.Entity<Professor>().ToTable("Professores");
            modelBuilder.Entity<Aluno>().ToTable("Alunos");
            modelBuilder.Entity<Nota>().ToTable("Notas");
            modelBuilder.Entity<ProfessorMateria>().ToTable("ProfessorMateria");

            // Chaves primárias compostas na tabela de junção (ProfessorMateria)
            modelBuilder.Entity<ProfessorMateria>()
                .HasKey(pm => new { pm.ProfessorId, pm.MateriaId });

            // Relacionamentos
            modelBuilder.Entity<ProfessorMateria>()
                .HasOne(pm => pm.Professor)
                .WithMany(p => p.ProfessoresMaterias)
                .HasForeignKey(pm => pm.ProfessorId);

            modelBuilder.Entity<ProfessorMateria>()
                .HasOne(pm => pm.Materia)
                .WithMany(m => m.ProfessoresMaterias)
                .HasForeignKey(pm => pm.MateriaId);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Aluno)
                .WithMany(a => a.Notas)
                .HasForeignKey(n => n.AlunoId);

            modelBuilder.Entity<Nota>()
                .HasOne(n => n.Materia)
                .WithMany(m => m.Notas)
                .HasForeignKey(n => n.MateriaId);
        }
    }
}
