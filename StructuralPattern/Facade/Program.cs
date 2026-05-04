using Facade.Api;

DetranApi detran = new();
SerasaApi serasa = new();
ReceitaFederalApi receita = new();

var cpf = "12345678901";
var cnhValida = detran.ValidCNH("12343215678");
var scoreSerasa = serasa.Score(cpf);
var activecPF = receita.isCpfActive(cpf);

var score = 0;


Console.WriteLine($"Client score is {score}");
