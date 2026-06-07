using Mediator.Interfaces;

namespace Mediator.Entity;

public abstract class User
{
    protected IChatRoom _chatRoom;

    public User(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}