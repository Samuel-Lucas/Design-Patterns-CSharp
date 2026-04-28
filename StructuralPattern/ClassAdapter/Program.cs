using ClassAdapter.Libs;

Console.Write("Type the file which you want to execute: ");
string file = Console.ReadLine();

var splittedFile = file!.Split(".");

switch (splittedFile[1])
{
    case "mp3":
    {
        Mp3Player mp3Player = new(file);
        mp3Player.Run();
        break;
    }
    case "mp4":
    {
        Mp4Player.Execute(file);
        break;
    }
    default:
    {
        Console.WriteLine("File is incompatible !");
        break;
    }
}