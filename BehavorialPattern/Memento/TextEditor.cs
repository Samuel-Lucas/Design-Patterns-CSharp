using Memento.Interfaces;

namespace Memento;

public class TextEditor : IOriginator
{
    private string text;

    public TextEditor(string text)
    {
        this.text = text;
    }

    public ConcreteMemento Save()
    {
        Console.WriteLine("Saving state, actual text: " + text);
        return new ConcreteMemento(text);
    }

    public void Write(string newText)
    {
        Console.WriteLine("Writing: " + newText);
        text = newText;
    }

    public void Restore(ConcreteMemento memento)
    {
        text = memento.GetText();
        Console.WriteLine("Restored text, actual text: " + text);
    }

    public void ViewText()
    {
        Console.WriteLine("Actual text: " + text);
    }
}