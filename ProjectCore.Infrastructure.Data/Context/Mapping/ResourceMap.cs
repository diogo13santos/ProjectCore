using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectCore.Domain.Entities;

namespace ProjectCore.Infrastructure.Data.Context.Mapping
{
    internal class ResourceMap : DbEntityConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> entity)
        {
            entity.HasKey(x => x.Id);
            entity.Property(x => x.Name).HasMaxLength(80).IsRequired();

            entity.HasOne(r => r.Module)
                .WithMany(m => m.Resources)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
