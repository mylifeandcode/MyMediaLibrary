using Microsoft.EntityFrameworkCore;

namespace MyMediaLibrary.Infrastructure.EntitySetup
{
    public interface IEntitySetup
    {
        void Setup(ModelBuilder builder);
    }
}
