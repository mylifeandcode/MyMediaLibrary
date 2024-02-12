using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Infrastructure.EntitySetup.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure.EntitySetup
{
    public class EntitySetupManager
    {
        //This class forgoes IoC and DI because it's used just during app startup.
        //Though I still feel a little off about it! :)

        private List<IEntitySetup> _setups;

        public EntitySetupManager()
        {
            _setups = new List<IEntitySetup>(9);
            _setups.Add(new CategorySetup());
        }

        public void SetupEntities(ModelBuilder builder)
        {
            _setups.ForEach(x => x.Setup(builder));
        }
    }
}
