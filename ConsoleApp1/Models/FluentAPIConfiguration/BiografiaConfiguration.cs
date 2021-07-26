using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Models.FluentAPIConfiguration
{
    class BiografiaConfiguration : IEntityTypeConfiguration<Biografia>
    {

        public void Configure(EntityTypeBuilder<Biografia> modelBuilder)
        {
            modelBuilder.HasKey(a => a.BiografiaId);

            modelBuilder
                    .Property(p => p.BiografiaAutor)
                    .HasMaxLength(400)
                    .IsRequired();

            modelBuilder
                    .Property(p => p.Nacionalidade)
                    .HasMaxLength(80)
                    .IsRequired();
        }
    }
}
