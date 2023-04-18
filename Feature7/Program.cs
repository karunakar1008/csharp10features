Console.WriteLine("Extended property pattern");

var salary = new EmployeeSalary(1, 1000);
var employee = new Employee(1, "kk", salary);

if (employee is { EmpSalary: { Salary: <= 1000 } }) //c# 9.0
{
    Console.WriteLine("Employee is not costly");
}

if (employee is { EmpSalary.Salary: >= 1000 }) //c# 10.0 Improvement
{
    Console.WriteLine("Employee is costly");
}
