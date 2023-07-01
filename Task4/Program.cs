var numbers = new List<int>() { 1, 5, 8, 1, 45, 20 };
var result = numbers.OrderByDescending(n =>n).Take(3);
System.Console.WriteLine(string.Join("\n", result));
