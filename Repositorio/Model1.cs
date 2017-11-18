namespace Repositorio
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<COMENTARIO> COMENTARIO { get; set; }
        public virtual DbSet<PERFIL_USUARIO> PERFIL_USUARIO { get; set; }
        public virtual DbSet<POSTAGEM> POSTAGEM { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<COMENTARIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<COMENTARIO>()
                .HasMany(e => e.USUARIO1)
                .WithMany(e => e.COMENTARIO1)
                .Map(m => m.ToTable("LIKE").MapLeftKey("ID_COMENTARIO").MapRightKey("ID_USUARIO"));

            modelBuilder.Entity<PERFIL_USUARIO>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<PERFIL_USUARIO>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.PERFIL_USUARIO)
                .HasForeignKey(e => e.ID_PERFIL)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<POSTAGEM>()
                .Property(e => e.TITULO)
                .IsUnicode(false);

            modelBuilder.Entity<POSTAGEM>()
                .Property(e => e.DESCRICAO)
                .IsUnicode(false);

            modelBuilder.Entity<POSTAGEM>()
                .HasMany(e => e.COMENTARIO)
                .WithRequired(e => e.POSTAGEM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.NOME)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.COMENTARIO)
                .WithRequired(e => e.USUARIO)
                .HasForeignKey(e => e.ID_USUARIO_CRIADOR)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.POSTAGEM)
                .WithRequired(e => e.USUARIO)
                .HasForeignKey(e => e.ID_USUARIO_CRIADOR)
                .WillCascadeOnDelete(false);
        }
    }
}
