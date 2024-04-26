namespace SOLID.D;

public class UserService(IUserRepository userRepository)
{
    public string ListFirstUser()
    {
        var users = userRepository.GetUsers();

        return users.First();
    }
}
