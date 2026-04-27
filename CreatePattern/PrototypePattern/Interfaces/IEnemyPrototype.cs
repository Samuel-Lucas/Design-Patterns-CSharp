namespace PrototypePattern.Interfaces;

public interface IEnemyPrototype
{
    Enemy ShallowCopy();
    Enemy DeepCopy();
}