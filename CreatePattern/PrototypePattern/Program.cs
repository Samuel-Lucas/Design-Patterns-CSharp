using System.Text.Json;
using System.Text.Json.Serialization;
using PrototypePattern;
using PrototypePattern.Entities;
using PrototypePattern.Prototypes;

EnemyPrototypeA enemy1 = new();
enemy1.Name = "enemy1";
enemy1.Color = "blue";
enemy1.Gun = new Gun("knife");

Enemy enemy2 = new EnemyPrototypeA();
// enemy2 = enemy1.ShallowCopy();  // same reference in both enemies, same behaviour
enemy2 = enemy1.DeepCopy();   // differs reference and behaviours if ones changes properties

enemy1.Gun!.Name = "sword";

var serializedEnemy1 = JsonSerializer.Serialize(enemy1);
var serializedEnemy2 = JsonSerializer.Serialize(enemy2);

Console.WriteLine(serializedEnemy1);
Console.WriteLine("***************");
Console.WriteLine(serializedEnemy2);