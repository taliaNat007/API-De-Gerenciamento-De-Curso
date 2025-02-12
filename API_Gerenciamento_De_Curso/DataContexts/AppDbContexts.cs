using API_Gerenciamento_De_Curso.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Gerenciamento_De_Curso.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Professor> Professor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Campus>()
            //    .HasMany(e => e.Servidores)
            //    .WithOne(e => e.Campus)
            //    .HasForeignKey(e => e.CampusId)
            //    .IsRequired(false);

            
            //Relacionamento Professor_Curso
            modelBuilder.Entity<Professor>()
                .HasOne(e => e.Cursos)
                .WithMany(e => e.Professores)
                .HasForeignKey(e => e.CursoId)
                .IsRequired(false)

            //Relacinamento Curso_Aluno
             modelBuilder.Entity<Curso>()
                .HasOne(e => e.Cursos)
                .WithMany(e => e.Alunos)
                .HasForeignKey(e => e.AlunoId)
                .IsRequired(false)

            //Relacionamento Materia_Professor
             modelBuilder.Entity<Materia>()
                .HasOne(e => e.Professores)
                .WithMany(e => e.Materias)
                .HasForeignKey(e => e.ProfessoresId)
                .IsRequired(false)

            //Relacionamento N p/ N Aluno_Materia
            modelBuilder.Entity<Aluno>()
                .HasMany(s => s.Alunos) 
                .WithMany(f => f.Materias) 
                .UsingEntity<Dictionary<string, object>>(
                    "Aluno_Materia", // Nome da tabela de junção
                    j => j.HasOne<Aluno>().WithMany().HasForeignKey("fk_Aluno_id_aluno"), // Chave estrangeira para Funcao
                    j => j.HasOne<Materia>().WithMany().HasForeignKey("fk_Materia_id_materia"), // Chave estrangeira para Servidor
                    j => j.ToTable("Aluno_Materia") // Nome da tabela de junção
        );
        }

    }


}