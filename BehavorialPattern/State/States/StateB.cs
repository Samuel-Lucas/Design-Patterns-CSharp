using State.Class;
using State.Interfaces;

namespace State.States;

public class StateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do estado B");
        context.State = new StateA();
    }
}