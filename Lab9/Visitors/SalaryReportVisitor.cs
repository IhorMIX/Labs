using Lab9.Entities;
using Lab9.Visitors.Interface;

namespace Lab9.Visitors;

public class SalaryReportVisitor : ISalaryReportVisitor
{
    public void VisitCompany(Company company)
    {
        Console.WriteLine($"Generating salary report for company: {company.Name}");
    }

    public void VisitDepartment(Department department)
    {
        Console.WriteLine($"Generating salary report for department: {department.Name}");
    }

    public void VisitEmployee(Employee employee)
    {
        Console.WriteLine($"Employee: {employee.Position}, Salary: {employee.Salary}");
    }
}