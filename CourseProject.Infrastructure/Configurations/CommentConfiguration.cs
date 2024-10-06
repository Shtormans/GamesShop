using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.Comment;
using CourseProject.Domain.ValueObjects.Identificators;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProject.Infrastructure.Configurations;

internal class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("Comments");

        builder.HasKey(comment => comment.Id);

        builder.Property(comment => comment.Text).HasConversion(
            text => text.Value,
            value => CommentText.Create(value).Value)
            .IsRequired();

        builder.Property(comment => comment.CreationDate).HasConversion(
            creationDate => creationDate.DateInUTC,
            value => CommentCreationDate.Create(DateTime.SpecifyKind(value, DateTimeKind.Utc)).Value)
            .IsRequired();
    }
}
