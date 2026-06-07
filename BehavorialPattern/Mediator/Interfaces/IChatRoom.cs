using Mediator.Entity;

namespace Mediator.Interfaces;

public interface IChatRoom
{
    void Register(User user);
    void Send(string message, User user);
}