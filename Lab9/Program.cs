using Lab9.Entities;
using Lab9.Visitors;

// create employees
var employee1 = new Employee("Project Manager", 4000);
var employee2 = new Employee("Developer", 5000);
var employee3 = new Employee("HR", 3000);

// create departments
var department1 = new Department("IT Department", new List<Employee> { employee1, employee2 });
var department2 = new Department("HR Department", new List<Employee> { employee3 });

// create company
var company = new Company("Corporation", new List<Department> { department1, department2 });

// create visitor
var salaryReportVisitor = new SalaryReportVisitor();

// getting report for company
Console.WriteLine("Company-wide Salary Report:");
company.Accept(salaryReportVisitor);

// getting report for department
Console.WriteLine("\nDepartment-specific Salary Report:");
department1.Accept(salaryReportVisitor);