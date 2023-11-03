using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.Game;
using CourseProject.Domain.ValueObjects.Identificators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProject.Infrastructure.Configurations;

internal class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.ToTable("Games");

        builder
            .HasKey(game => game.Id);

        builder.Property(game => game.Title).HasConversion(
            title => title.Value,
            value => GameTitle.Create(value).Value)
            .HasMaxLength(GameTitle.MaxLength)
            .IsRequired();

        builder.Property(game => game.CreationDate).HasConversion(
            creationDate => creationDate.DateInUTC,
            value => GameCreationDate.Create(value).Value)
            .IsRequired();

        builder.Property(game => game.Description).HasConversion(
            description => description.Value,
            value => GameDescription.Create(value).Value)
            .IsRequired();

        builder.Property(game => game.Image).HasConversion(
            image => image.Id,
            value => GameIcon.Create(value).Value)
            .IsRequired();

        builder.OwnsOne(game => game.Price, priceBuilder =>
        {
            priceBuilder.Property(money => money.Currency).HasMaxLength(3);
        });

        builder.HasMany(game => game.Comments)
            .WithOne()
            .HasForeignKey(comment => comment.GameId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(game => game.Title).IsUnique();
    }
}
