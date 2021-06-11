using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCare.DataAccessLayer.Data
{
    public class OlifransHealthCareDbContext : DbContext
    {
        public OlifransHealthCareDbContext(DbContextOptions<OlifransHealthCareDbContext> options) : base(options)
        {

        }
        public DbSet<Consulta> Consulta { get; set; }
        public DbSet<Especialidade> Especialidade { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UsuarioNome).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(50);
            });


            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(50);
                entity.Property(e => e.DocumentoIndentificadorTipo).IsRequired().HasMaxLength(50);
                entity.Property(e => e.NumeroDocumentoIndentificador).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Endereco).IsRequired().HasMaxLength(50);
                entity.Property(e => e.EnderecoNumero).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Cep).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Bairro).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Cidade).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Estado).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Pais).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Telefone).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Peso).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Altura).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Imc).IsRequired().HasMaxLength(50);
                entity.Property(e => e.UsuarioNome).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Senha).IsRequired().HasMaxLength(50);
                entity.Property(e => e.CVNomeArquivo).HasMaxLength(350);
                entity.Property(e => e.ImagemNomeArquivo).HasMaxLength(450);
               // entity.HasOne(e => e.Groups).WithMany(p => p.Estudante).HasForeignKey(d => d.GroupsId);
            });


            modelBuilder.Entity<Medico>(entity =>
            {
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.CrmMedico).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Telefone).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
                entity.Property(e => e.UsuarioNome).IsRequired().HasMaxLength(150);
                entity.Property(e => e.CVNomeArquivo).IsRequired().HasMaxLength(150);
                entity.Property(e => e.ImagemNomeArquivo).IsRequired().HasMaxLength(150);
                //entity.HasOne(e => e.Exame).WithMany(p => p.QnAs).HasForeignKey(d => d.ExameId).OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Especialidade>(entity =>
            {
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(150);
                entity.Property(e => e.DescricaoEspecialidade).HasMaxLength(3550);
                //entity.HasOne(e => e.Usuario).WithMany(p => p.Groups).HasForeignKey(d => d.UsuarioId).OnDelete(DeleteBehavior.ClientSetNull);
            });


            modelBuilder.Entity<Consulta>(entity =>
            {
                entity.Property(e => e.Observacao).IsRequired().HasMaxLength(150);
                //entity.Property(e => e.Observacao).HasMaxLength(3550);
                //entity.HasOne(e => e.Groups).WithMany(p => p.Exame).HasForeignKey(d => d.GroupsId).OnDelete(DeleteBehavior.ClientSetNull);
            });


            //modelBuilder.Entity<ExameResultado>(entity =>
            //{
            //    entity.HasOne(e => e.Exame).WithMany(p => p.ExameResultado).HasForeignKey(d => d.ExameId);
            //    entity.HasOne(e => e.QnAs).WithMany(p => p.ExameResultado).HasForeignKey(d => d.QnAsId).OnDelete(DeleteBehavior.ClientSetNull);
            //    entity.HasOne(e => e.Estudante).WithMany(p => p.ExameResultado).HasForeignKey(d => d.EstudanteId).OnDelete(DeleteBehavior.ClientSetNull);
            //});

            base.OnModelCreating(modelBuilder);
        }

        /*
         * Adção de migração via Nuget
         * 
         * add-migration Init
         * update-database
         * 
         */


    }
}
