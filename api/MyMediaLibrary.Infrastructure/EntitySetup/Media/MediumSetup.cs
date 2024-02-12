using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMediaLibrary.Domain.Media;

namespace MyMediaLibrary.Infrastructure.EntitySetup.Media
{
    public class MediumSetup : DescriptiveMediaEntitySetupBase
    {
        public override void Setup(ModelBuilder builder)
        {
            var entity = builder.Entity<Medium>();

            base.Setup(builder);
        }
    }
}
