var numbers = new List<int>() { 1, 5, 8, 2, 15, 20 };
var result = numbers.Where(n => n %2 ==0).Sum(n => n);
System.Console.WriteLine(string.Join( " ", result));