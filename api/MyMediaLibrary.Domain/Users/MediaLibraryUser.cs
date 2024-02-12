using Microsoft.AspNetCore.Identity;
using MyMediaLibrary.Domain.Media;
using System.Text.Json.Serialization;

namespace MyMediaLibrary.Domain.Users
{
    public class MediaLibraryUser : IdentityUser
    {
        //Extending IdentityUser in the event I want to add some properties at a later date (which is likely)
    }
}
