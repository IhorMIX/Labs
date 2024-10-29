using Lab9.Entities.Interface;
using Lab9.Visitors.Interface;

namespace Lab9.Entities;

public class Employee : IVisitable
{
    public string Position { get; }
    public decimal Salary { get; }

    public Employee(string position, decimal salary)
    {
        Position = position;
        Salary = salary;
    }

    public void Accept(ISalaryReportVisitor visitor)
    {
        visitor.VisitEmployee(this);
    }
}