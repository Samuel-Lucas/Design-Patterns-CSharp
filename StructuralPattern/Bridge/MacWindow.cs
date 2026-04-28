using Bridge.Interfaces;

namespace Bridge;

public class MacWindow : IWindowBridge
{
    public void DrawWButton(string title)
    {
        Console.WriteLine($"{title} mac os button");
    }

    public void DrawWindow(string title)
    {
        Console.WriteLine($"{title} mac os button");
    }
}