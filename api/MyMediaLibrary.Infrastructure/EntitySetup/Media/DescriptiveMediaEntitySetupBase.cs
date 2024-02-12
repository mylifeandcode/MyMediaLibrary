using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Domain.Media;

namespace MyMediaLibrary.Infrastructure.EntitySetup.Media
{
    public abstract class DescriptiveMediaEntitySetupBase : EntitySetupBase
    {
        public virtual void Setup(ModelBuilder builder)
        {
            var entity = builder.Entity<DescriptiveMediaEntity>();
            entity.Property(x => x.Description).IsRequired().HasMaxLength(255);
            base.Setup<DescriptiveMediaEntity>(builder);
        }
    }
}
