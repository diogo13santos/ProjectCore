using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Domain.Entities;

namespace ProjectCore.Infrastructure.Data.Context.Mapping
{
    internal class RoleMap : DbEntityConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();

            entity.HasMany(r => r.Users).WithOne(u => u.Role);
        }
    }
}
