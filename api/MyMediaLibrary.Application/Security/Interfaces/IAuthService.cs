using MyMediaLibrary.Application.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Application.Security.Interfaces
{
    public interface IAuthService
    {
        bool IsValidUser(UserCredentials userCredentials);
    }
}
