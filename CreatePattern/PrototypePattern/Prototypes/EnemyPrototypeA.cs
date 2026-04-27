using PrototypePattern.Entities;
using PrototypePattern.Interfaces;

namespace PrototypePattern.Prototypes;

public class EnemyPrototypeA : Enemy, IEnemyPrototype
{
    public Enemy DeepCopy()
    {
        var result = (Enemy)this.MemberwiseClone();
        result.Gun = new Gun("knife");   
        return result;
    }

    public Enemy ShallowCopy()
    {
        return (Enemy)this.MemberwiseClone();
    }
}