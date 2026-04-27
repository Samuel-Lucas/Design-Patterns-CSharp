using PrototypePattern;
using PrototypePattern.Prototypes;

EnemyPrototypeA enemy1 = new();
enemy1.Name = "enemy1";
enemy1.Color = "blue";

Enemy enemy2 = new EnemyPrototypeA();
enemy2 = enemy1.Clone();


Console.WriteLine($"");