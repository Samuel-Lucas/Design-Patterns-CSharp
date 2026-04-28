using Bridge.Interfaces;

namespace Bridge;

public class LinuxWindow : IWindowBridge
{
    public void DrawWButton(string title)
    {
        Console.WriteLine($"{title} linux button");
    }

    public void DrawWindow(string title)
    {
        Console.WriteLine($"{title} linux window");
    }
}