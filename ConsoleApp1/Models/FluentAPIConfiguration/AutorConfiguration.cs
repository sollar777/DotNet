using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Models.FluentAPIConfiguration
{
    class AutorConfiguration : IEntityTypeConfiguration<Autor>
    {

        public void Configure(EntityTypeBuilder<Autor> modelBuilder)
        {
            modelBuilder.HasKey(a => a.AutorId);

            modelBuilder
                    .Property(p => p.Nome)
                    .HasMaxLength(100)
                    .IsRequired();

            modelBuilder
                    .Property(p => p.Email)
                    .HasMaxLength(200)
                    .IsRequired();
        }

    }
}
