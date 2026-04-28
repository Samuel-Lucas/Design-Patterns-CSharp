namespace ClassAdapter.Libs;

public class Mp3Player
{
    private string File = "";

    public Mp3Player() { }

    public Mp3Player(string file) => File = file;

    public void Run()
    {
        Console.WriteLine($"Executing file MP3: {File}");
    }
}