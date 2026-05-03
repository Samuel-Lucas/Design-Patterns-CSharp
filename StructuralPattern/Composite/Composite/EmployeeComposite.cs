using Composite.Entity;

namespace Composite.Composite;

public class EmployeeComposite : Employee
{
    protected List<Employee> _children = new();

    public EmployeeComposite(string name) : base(name) { }

    public override void Add(Employee component)
    {
        this._children.Add(component);
    }

    public override void Remove(Employee component)
    {
        this._children.Remove(component);
    }

    public override string Operation()
    {
        int i = 0;
        string result = $"Led by {this.Name} (";

        foreach(Employee component in this._children)
        {
            result += component.Name;

            if (i != this._children.Count - 1)
            {
                result += ", ";
            }

            i++;
        }

        return result + ")";
    }
}