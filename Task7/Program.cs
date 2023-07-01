List<Person> people = new List<Person>
{
 new Person { Name = "Alice", Age = 20 },
 new Person { Name = "Bob", Age = 30 },
 new Person { Name = "Charlie", Age = 20 },
 new Person { Name = "Dave", Age = 30 },
 new Person { Name = "Eve", Age = 20 }
};
var result = (
    from p in people
    group p by p.Age into groupes
    select new
    {
        Age = groupes.Key,
        Name = groupes.Select(n => n.Name).ToList()
    }
).ToList();
foreach (var p in result)
{
    System.Console.WriteLine(p.Age);
    System.Console.WriteLine(string.Join(", ", p.Name));
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
