using Mediator.Entity;
using Mediator.Interfaces;

namespace Mediator.Mediator.ConcreteMediator;

public class ChatRoom : IChatRoom
{
    private List<User> _users = new();

    public void Register(User user)
    {
        _users.Add(user);
    }

    public void Send(string message, User sender)
    {
        foreach (User user in _users)
        {
            if (user != sender)
            {
                user.Receive(message);
            }
        }
    }
}