using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProject.Infrastructure.Configurations;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(user => user.Id);

        builder.Property(user => user.Username).HasConversion(
            username => username.Value,
            value => Username.Create(value).Value)
            .HasMaxLength(Username.MaxLength)
            .IsRequired();

        builder.Property(user => user.Email).HasConversion(
            email => email.Value,
            value => UserEmail.Create(value).Value)
            .HasMaxLength(UserEmail.MaxLength)
            .IsRequired();

        builder.Property(user => user.Password).HasConversion(
            password => password.Value,
            value => UserPassword.CreateWithoutEncryption(value).Value)
            .HasMaxLength(UserPassword.MaxLength)
            .IsRequired();

        builder.Property(user => user.FirstName).HasConversion(
            firstName => firstName!.Value,
            value => UserFirstName.Create(value).Value)
            .HasMaxLength(UserFirstName.MaxLength);

        builder.Property(user => user.SecondName).HasConversion(
            secondName => secondName!.Value,
            value => UserSecondName.Create(value).Value)
            .HasMaxLength(UserSecondName.MaxLength);

        builder.Property(user => user.Birthday).HasConversion(
            birthday => birthday.DateInUTC,
            value => UserBirthday.Create(value).Value)
            .IsRequired();

        builder.Property(user => user.ProfilePicture).HasConversion(
            image => image!.Id,
            value => UserProfilePicture.Create(value).Value);

        builder.HasMany(user => user.Library)
            .WithMany()
            .UsingEntity(builder => builder.ToTable("Libraries"));

        builder.HasMany(user => user.Friends)
            .WithMany()
        
            .UsingEntity(builder => builder.ToTable("Friends"));

        builder.HasMany(user => user.Comments)
            .WithOne()
            .HasForeignKey(comment => comment.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(user => user.CreatedGames)
            .WithOne()
            .HasForeignKey(game => game.AuthorId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasIndex(user => user.Username).IsUnique();

        builder.HasIndex(user => user.Email).IsUnique();
    }
}
