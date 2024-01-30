using MyMediaLibrary.Domain.Users;
using MyMediaLibrary.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Application.Users.Services
{
    public class UserService
    {
        private IRepository<MediaLibraryUser> _userRepository;

        public UserService(IRepository<MediaLibraryUser> userRepository)
        { 
            _userRepository = userRepository;
        }
    }
}
