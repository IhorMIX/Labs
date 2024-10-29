using Lab9.Visitors.Interface;

namespace Lab9.Entities.Interface;

public interface IVisitable
{
    void Accept(ISalaryReportVisitor visitor);
}