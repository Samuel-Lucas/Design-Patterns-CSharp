using ClassAdapter.Adapters;
using ClassAdapter.Adapters.Interfaces;

Console.Write("Type the file which you want to execute: ");
string file = Console.ReadLine()!;

if (!file.Contains(".") || string.IsNullOrEmpty(file.Trim()))
{
    Console.WriteLine("File format is incompatible !");
    return;
} 

var splittedFile = file!.Split(".");

IPlayer player;

switch (splittedFile![1])
{
    case "mp3":
    {
        player = new Mp3PlayerAdapter();
        player.Play(file!);
        break;
    }
    case "mp4":
    {
        player = new Mp4PlayerAdapter();
        player.Play(file!);
        break;
    }
    default:
    {
        Console.WriteLine("File format is incompatible !");
        break;
    }
}