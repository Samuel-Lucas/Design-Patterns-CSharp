using Composite.Entity;

namespace Composite;

public class EmployeeLeaf : Employee
{
    public EmployeeLeaf(string name) : base(name) { }

    public override string Operation()
    {
        return "Leaf";
    }
}