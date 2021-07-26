using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConsoleApp1.Models.FluentAPIConfiguration
{
    class EditorConfiguration : IEntityTypeConfiguration<Editor>
    {

        public void Configure(EntityTypeBuilder<Editor> modelBuilder)
        {
            modelBuilder.HasKey(e => e.EditorId);

            modelBuilder
                    .Property(e => e.Nome)
                    .HasMaxLength(100)
                    .IsRequired();

        }

    }
}
