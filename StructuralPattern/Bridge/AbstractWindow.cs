using Bridge.Interfaces;

namespace Bridge;

public abstract class AbstractWindow
{
    protected IWindowBridge window;

    public AbstractWindow(IWindowBridge window)
    {
        this.window = window;
    }

    public void DrawWindow(string title)
    {
        this.window.DrawWindow(title);
    }

    public void DrawButton(string title)
    {
        this.window.DrawWButton(title);
    }

    public abstract void Draw();
}