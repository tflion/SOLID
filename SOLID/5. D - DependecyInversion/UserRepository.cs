
namespace SOLID.D;

public class UserRepository : IUserRepository
{
    public IEnumerable<string> GetUsers()
    {
        return ["User 1", "User 2", "User 3"];
    }
}
