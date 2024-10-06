using CourseProject.Domain.Entities;
using CourseProject.Domain.ValueObjects.Transaction;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CourseProject.Infrastructure.Configurations;

internal class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
{
    public void Configure(EntityTypeBuilder<Transaction> builder)
    {
        builder.ToTable("Transactions");

        builder
            .HasKey(transcation => transcation.Id);

        builder.Property(transcation => transcation.PurchaseDate).HasConversion(
            transcation => transcation.DateInUTC,
            value => PurchaseDate.Create(value).Value)
            .IsRequired();

        builder.OwnsOne(transcation => transcation.Price, priceBuilder =>
        {
            priceBuilder.Property(money => money.Currency).HasMaxLength(3);
        });

        builder.HasOne(t => t.Receiver)
            .WithMany()
            .HasForeignKey(t => t.ReceiverId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(t => t.Payer)
            .WithMany()
            .HasForeignKey(t => t.PayerId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(t => t.Game)
            .WithMany()
            .HasForeignKey(t => t.GameId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
