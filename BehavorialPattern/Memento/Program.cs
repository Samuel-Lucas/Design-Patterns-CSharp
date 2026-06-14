using Memento;
using Memento.Memento;

TextEditor editor = new("Hello World !");
CaretakerMemento management = new();

editor.ViewText();
management.AddMemento(editor.Save());

editor.Write("Hi There !");
editor.ViewText();
management.AddMemento(editor.Save());

editor.Write("Hey there world !");
editor.ViewText();
management.AddMemento(editor.Save());

var totalMementos = management.GetTotalMementos().Count;
int item = 0;

while (item < totalMementos)
{
    editor.Restore(management.GetMemento(item));
    item++;
}