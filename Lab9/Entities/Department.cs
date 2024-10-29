using Lab9.Entities.Interface;
using Lab9.Visitors.Interface;

namespace Lab9.Entities;

public class Department : IVisitable
{
    public string Name { get; }
    public List<Employee> Employees { get; }

    public Department(string name, List<Employee> employees)
    {
        Name = name;
        Employees = employees;
    }

    public void Accept(ISalaryReportVisitor visitor)
    {
        visitor.VisitDepartment(this);
        foreach (var employee in Employees)
        {
            employee.Accept(visitor);
        }
    }
}