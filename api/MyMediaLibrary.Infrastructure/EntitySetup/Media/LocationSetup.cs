using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure.EntitySetup.Media
{
    public class LocationSetup : DescriptiveMediaEntitySetupBase
    {
        public override void Setup(ModelBuilder builder)
        {
            var entity = builder.Entity<Location>();
            entity.Property(x => x.VolumeName).HasMaxLength(100);
            base.Setup(builder);
        }
    }
}
