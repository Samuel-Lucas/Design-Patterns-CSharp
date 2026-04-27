using PrototypePattern.Interfaces;

namespace PrototypePattern.Prototypes;

public class EnemyPrototypeA : Enemy, IEnemyPrototype
{
    public Enemy Clone()
    {
        return (Enemy)this.MemberwiseClone();
    }
}