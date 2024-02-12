﻿using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Domain.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure.EntitySetup.Media
{
    public class CategorySetup : EntitySetupBase, IEntitySetup
    {
        public void Setup(ModelBuilder builder)
        {
            base.Setup<Category>(builder);
        }
    }
}
