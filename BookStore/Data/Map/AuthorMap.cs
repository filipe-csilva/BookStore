using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.Data.Map
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(60).IsRequired();

            builder.HasMany(x => x.Books)
                   .WithMany(x => x.Authors)
                   .UsingEntity(x => x.ToTable("BookByAuthor"));

            //.Map(x => x.ToTable("BookByAuthor"));
        }
    }
}
