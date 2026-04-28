using Bridge.Interfaces;

namespace Bridge.Dialogue;

public class WindowDialogue : AbstractWindow
{
    public WindowDialogue(IWindowBridge window) : base(window) { }

    public override void Draw()
    {
        DrawWindow("Attention ! want to quit without saving ?");
        DrawButton("yes");
        DrawButton("no");
    }
}