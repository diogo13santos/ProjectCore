using ProjectCore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ProjectCore.Infrastructure.Data.Context.Mapping
{
    internal class UserMap : DbEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();
            entity.Property(x => x.Email).HasMaxLength(200).IsRequired();
            entity.Property(x => x.Password).HasMaxLength(200).IsRequired();
            entity.Property(x => x.Status).IsRequired();
            entity.Property(x => x.CreationDate).IsRequired();

            entity.HasIndex(x => x.Email).IsUnique();

            entity.HasOne(u => u.Role).WithMany(r => r.Users);
        }
    }
}
