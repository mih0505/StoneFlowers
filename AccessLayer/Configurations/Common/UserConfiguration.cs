using Domain.Common;
using Domain.OrderModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessLayer.Configurations.Common
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.IdentityId)
                .IsRequired()
                .HasMaxLength(256);

            builder.OwnsOne(u => u.UserName, username =>
            {
                username.Property(c => c.Lastname)
                .IsRequired()
                .HasMaxLength(128);

                username.Property(c => c.Firstname)
                .IsRequired()
                .HasMaxLength(128);

                username.Property(c => c.Middlename)
                .IsRequired(false)
                .HasMaxLength(128);
            });            
        }
    }
}
