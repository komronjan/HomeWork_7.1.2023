var employees = new List<Employee>
{
 new Employee { Name = "Alice", Department = "Sales", Salary = 50000
},
 new Employee { Name = "Bob", Department = "IT", Salary = 60000 },
 new Employee { Name = "Charlie", Department = "Sales", Salary =
55000 },
 new Employee { Name = "Dave", Department = "IT", Salary = 65000 },
 new Employee { Name = "Eve", Department = "HR", Salary = 45000 }
};
var result = (
    from e in employees
    group e by e.Department into groupes
    select new
    {
        Department = groupes.Key,
        Average = groupes.Average(n => n.Salary)
    }
).ToList();
System.Console.WriteLine(string.Join("\n ",result));
class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}