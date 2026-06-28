using State.Class;
using State.Interfaces;

namespace State.States;

public class StateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Executando ação do estado A");
        context.State = new StateB();
    }
}