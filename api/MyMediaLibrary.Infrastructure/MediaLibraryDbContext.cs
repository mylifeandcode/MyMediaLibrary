using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyMediaLibrary.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Infrastructure
{
    public class MediaLibraryDbContext : IdentityDbContext<MediaLibraryUser>
    {
        public MediaLibraryDbContext(DbContextOptions<MediaLibraryDbContext> options) : base(options) { }
    }
}
