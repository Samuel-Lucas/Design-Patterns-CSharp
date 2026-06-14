namespace Memento.Memento;

public class CaretakerMemento
{
    private List<ConcreteMemento> savedStates = new();

    public void AddMemento(ConcreteMemento memento)
    {
        savedStates.Add(memento);
    }

    public ConcreteMemento GetMemento(int index) // undo
    {
        return savedStates[index];
    }

    public List<ConcreteMemento> GetTotalMementos()
    {
        return savedStates;
    }
}