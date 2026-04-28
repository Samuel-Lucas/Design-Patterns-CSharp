using Bridge;
using Bridge.Dialogue;

AbstractWindow window = new WindowDialogue(new LinuxWindow());
window.Draw();

window = new WindowDialogue(new MacWindow());
window.Draw();