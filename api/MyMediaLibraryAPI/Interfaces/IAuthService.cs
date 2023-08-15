namespace MyMediaLibrary.API.Interfaces
{
    public interface IAuthService
    {
        string GenerateJwtToken(string userId, string username, string role);
    }
}
