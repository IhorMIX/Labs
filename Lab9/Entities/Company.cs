using Lab9.Entities.Interface;
using Lab9.Visitors.Interface;

namespace Lab9.Entities;

public class Company : IVisitable
{
    public string Name { get; }
    public List<Department> Departments { get; }

    public Company(string name, List<Department> departments)
    {
        Name = name;
        Departments = departments;
    }

    public void Accept(ISalaryReportVisitor visitor)
    {
        visitor.VisitCompany(this);
        foreach (var department in Departments)
        {
            department.Accept(visitor);
        }
    }
}