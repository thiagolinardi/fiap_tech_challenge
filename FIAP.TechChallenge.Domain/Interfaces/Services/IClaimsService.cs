namespace FIAP.TechChallenge.Domain.Interfaces.Services
{
    public interface IClaimsService
    {
        Guid GetCurrentUserId();
        List<string> GetCurrentUserRoles();
    }
}
