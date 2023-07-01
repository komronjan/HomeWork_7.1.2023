var names = new List<string>() {"Alice", "Anny", "Amy", "Dave", "Alexa"};
var result = names.Where(n => n.StartsWith("A") && n.EndsWith("a"));
System.Console.WriteLine(string.Join(" ", result));
