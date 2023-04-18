internal record EmployeeSalary(int EmployeeId, int Salary);
internal record Employee(int EmployeeId, string Name, EmployeeSalary? EmpSalary = null);

//class Employee
//{
//    public int EmployeeId { get; set; }
//    public string? Name { get; set; }
//    public EmployeeSalary? EmpSalary  { get; set; }
//}
//class EmployeeSalary
//{
//    public int EmployeeId { get; set; }
//    public int Salary { get; set; }
//}