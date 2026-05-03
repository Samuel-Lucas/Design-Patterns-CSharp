namespace Composite.Entity;

// Component
public abstract class Employee
{
    public string Name { get; set; }

    public Employee(string name) {Name = name; }

    public abstract string Operation();

    public virtual void Add(Employee component)
    {
        
    }

    public virtual void Remove(Employee component)
    {
        
    }

    public virtual void Get(int index)
    {
        throw new NotImplementedException();
    }
}