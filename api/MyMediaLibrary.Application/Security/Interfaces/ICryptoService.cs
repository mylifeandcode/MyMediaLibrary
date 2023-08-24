namespace MyMediaLibrary.Application.Security.Interfaces
{
    public interface ICryptoService
    {
        string GenerateSalt();
        string ComputeHash(string valueToHash, string salt);
        bool VerifyValuesMatch(string clearTextPassword, string hashedPassword, string salt);
        string GeneratePasswordResetCode();
    }
}
