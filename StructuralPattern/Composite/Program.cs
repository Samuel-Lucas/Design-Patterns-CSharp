using Composite;
using Composite.Composite;

EmployeeComposite tree = new("Steve jobs");
EmployeeLeaf employee1 = new("Samuel");
EmployeeLeaf employee2 = new("Lucas");
EmployeeComposite employee3 = new("Emanuel");
EmployeeLeaf employee4 = new("Gabriel");
EmployeeLeaf employee5 = new("Maria");

tree.Add(employee1);
tree.Add(employee2);
employee3.Add(employee4);
employee3.Add(employee5);

Console.WriteLine(tree.Operation());
Console.WriteLine(employee3.Operation());