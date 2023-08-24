using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMediaLibrary.Application.Security.Interfaces
{
    public interface ITokenService
    {
        string GenerateJwtToken(string userId, string username, string role);
    }
}
