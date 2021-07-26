using ConsoleApp1.Models.FluentAPIConfiguration;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Models
{
    class AppDbContext : DbContext
    {

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Biografia> Biografias { get; set; }
        public DbSet<Editor> Editores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Data Source = localhost,5433;" +
                  "Initial Catalog=CursoEFCOreModulo11DB;Integrated Security=True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new BiografiaConfiguration());
            modelBuilder.ApplyConfiguration(new EditorConfiguration());

            // um para muitos: Livro / autor
            modelBuilder.Entity<Livro>()
                .HasOne<Autor>(s => s.Autor)
                    .WithMany(g => g.Livros)
                        .HasForeignKey(s => s.AutorId);

            // um para muitos : livro-editor
            modelBuilder.Entity<Livro>()
                .HasOne<Editor>(s => s.Editor)
                    .WithMany(g => g.Livros)
                        .OnDelete(DeleteBehavior.Cascade);

            // um para um: autor-biografia
            modelBuilder.Entity<Autor>()
                .HasOne<Biografia>(s => s.Biografia)
                    .WithOne(ad => ad.Autor)
                        .HasForeignKey<Biografia>(ad => ad.AutorId);

        }
    }
}
