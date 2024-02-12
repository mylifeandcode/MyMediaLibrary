using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Domain.Media;

namespace MyMediaLibrary.Infrastructure.EntitySetup
{
    public abstract class EntitySetupBase
    {
        public virtual void Setup<T>(ModelBuilder builder) where T : MediaLibraryEntity
        {
            var entity = builder.Entity<T>();

            entity.Property(x => x.Id).IsRequired();
            entity.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entity.Property(x => x.CreatedByUserId).IsRequired();
            entity.Property(x => x.CreatedDateTime).IsRequired();

            entity.HasIndex(x => x.Id);
            entity.HasIndex(x => x.Name);

            entity.HasIndex(x => new
            {
                x.CreatedByUserId,
                x.CreatedDateTime,
                x.ModifiedByUserId,
                x.ModifiedDateTime
            });
        }
    }
}
