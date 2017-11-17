using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Domain.Entities;

namespace ProjectCore.Infrastructure.Data.Context.Mapping
{
    internal class PrivilegeMap : DbEntityConfiguration<Privilege>
    {
        public override void Configure(EntityTypeBuilder<Privilege> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();
            entity.Property(x => x.Status).IsRequired();

            entity.HasOne(p => p.Role).WithMany(r => r.Privileges);
            entity.HasOne(p => p.Resource).WithMany(r => r.Privileges);
        }
    }
}
