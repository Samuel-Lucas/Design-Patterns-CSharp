namespace Memento.Memento;

public class CaretakerMemento
{
    private List<ConcreteMemento> savedStates = new List<ConcreteMemento>();

    public void AddMemento(ConcreteMemento memento)
    {
        savedStates.Add(memento);
    }

    public ConcreteMemento GetMemento(int index)
    {
        return savedStates[index];
    }
}