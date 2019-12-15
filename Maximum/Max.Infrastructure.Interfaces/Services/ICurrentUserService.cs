namespace Max.Infrastructure.Interfaces.Services
{
    internal interface ICurrentUserService
    {
        int Id { get; }
        bool IsAuthenticated { get; }
        string Email { get; set; }
    }
}
