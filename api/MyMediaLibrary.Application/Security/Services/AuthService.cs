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
        public bool IsValidUser(UserCredentials userCredentials)
        {
            return true; //TODO: Implement
        }
    }
}
