using State.Class;

namespace State.Interfaces;

public interface IState
{
    void Handle(Context context);
}