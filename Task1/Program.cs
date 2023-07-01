var numbers = new List<int>() { 1, 5, 8, 1, 15, 20 };
var result = numbers.Where(n => n >10).Select(n =>n);
System.Console.WriteLine(string.Join(" ", result));