using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Models.FluentAPIConfiguration
{
    class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {

        public void Configure(EntityTypeBuilder<Livro> modelBuilder)
        {
            modelBuilder.HasKey(l => l.LivroId);

            modelBuilder
                    .Property(p => p.Titulo)
                    .HasMaxLength(200)
                    .IsRequired();

            modelBuilder
                    .Property(p => p.Tipo)
                    .HasMaxLength(50)
                    .IsRequired();
        }

    }
}
