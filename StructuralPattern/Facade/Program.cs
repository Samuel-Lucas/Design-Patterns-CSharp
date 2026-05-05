using Facade;

ClientScoreFacade clientScoreFacade = new();
var result = clientScoreFacade.Score("12345678901", "2345");

Console.WriteLine($"Client score is {Math.Round(result)}");