namespace NotClean.Services.Interfaces
{
    public interface ICurrentUserService
    {
        int Id { get; }
        bool IsAuthenticated { get; }
        string Email { get; set; }
    }
}
