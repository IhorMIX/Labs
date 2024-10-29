using Lab9.Entities;

namespace Lab9.Visitors.Interface;

public interface ISalaryReportVisitor
{
    void VisitCompany(Company company);
    void VisitDepartment(Department department);
    void VisitEmployee(Employee employee);
}