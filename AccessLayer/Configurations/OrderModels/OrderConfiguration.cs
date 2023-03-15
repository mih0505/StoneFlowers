using Domain.OrderModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessLayer.Configurations.OrderModels
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.Number)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasOne(c => c.Customer)
                .WithOne(o => o.Order)
                .HasForeignKey<Customer>("OrderId");

            builder.Property(o => o.CreationDate)
                .IsRequired()
                .HasDefaultValue(DateTime.Today);

            builder.Property(o => o.ExecutionDate)
                .IsRequired(false);

            builder.Property<Guid>("OrderTypeId")
                .IsRequired();

            builder.Property(o => o.CountPayments)
                .IsRequired()
                .HasDefaultValue(1);

            builder.Property<Guid>("OrderCreatorId")
                .IsRequired();

            builder.Property<Guid>("DepartmentMakingOrderId")
                .IsRequired();

            builder.Property<Guid>("DepartmentOfExecutionId")
                .IsRequired();

            builder.Property(o => o.Description)
                .IsRequired(false)
                .HasMaxLength(1500);

            builder.Property(o => o.Verified)
                .IsRequired()
                .HasDefaultValue(false);
        }
    }
}
