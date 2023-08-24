using MyMediaLibrary.Domain.Media;
using System.Text.Json.Serialization;

namespace MyMediaLibrary.Domain.Users
{
    public class User : MediaLibraryEntity
    {
        public string EmailAddress { get; set; }

        [JsonIgnore]
        public string HashedPassword { get; set; }

        public UserRole Role { get; set; }

        [JsonIgnore]
        public string Salt { get; set; }

        [JsonIgnore]
        public string PasswordResetCode { get; set; }
    }
}
