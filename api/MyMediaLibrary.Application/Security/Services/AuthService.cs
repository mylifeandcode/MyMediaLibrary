using MyMediaLibrary.Application.Security.Interfaces;
using MyMediaLibrary.Application.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Application.Security.Services
{
    public class AuthService : IAuthService
    {
        public Guid? GetUserId(UserCredentials userCredentials)
        {
            return Guid.NewGuid(); //TODO: Implement
        }

        public bool IsValidUser(UserCredentials userCredentials)
        {
            return true; //TODO: Implement
        }
    }
}
