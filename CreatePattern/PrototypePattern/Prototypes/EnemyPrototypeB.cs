using PrototypePattern.Interfaces;

namespace PrototypePattern.Prototypes;

public class EnemyPrototypeB : Enemy, IEnemyPrototype
{
    public Enemy Clone()
    {
        return (Enemy)this.MemberwiseClone();
    }
}