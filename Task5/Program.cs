var names = new List<string>() { "Alice", "Anny", "Amy", "Dave", "Alex" };
var result = names.OrderByDescending(n => n.Length);
System.Console.WriteLine(string.Join(", ", result));
