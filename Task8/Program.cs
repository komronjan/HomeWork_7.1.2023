using System.ComponentModel.Design;
var customers = new List<Customer>
{
 new Customer { CustomerId = 1, Name = "Alice" },
 new Customer { CustomerId = 2, Name = "Bob" },
 new Customer { CustomerId = 3, Name = "Charlie" },
};
var orders = new List<Order>
{
 new Order { OrderId = 1, CustomerId = 1, Amount = 10 },
 new Order { OrderId = 2, CustomerId = 3, Amount = 20 },
 new Order { OrderId = 3, CustomerId = 3, Amount = 30 },
 new Order { OrderId = 4, CustomerId = 3, Amount = 40 },
 new Order { OrderId = 5, CustomerId = 2, Amount = 50 },
 new Order { OrderId = 6, CustomerId = 1, Amount = 60 },
};
var result = (
    from c in customers
    join o in orders on c.CustomerId equals o.CustomerId
    group o by c.Name into groupes
    orderby groupes.Sum(x=> x.Amount) descending
    select new
    {
        Customer = groupes.Key,
        TotalAmount = groupes.Sum(n => n.Amount)
    }
).Take(2).ToList();
foreach (var c in result)
{
    System.Console.WriteLine(c.Customer + " " + c.TotalAmount);
}
public class Customer
{
    public int CustomerId { get; set; }
    public String Name { get; set; }
}
public class Order
{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int Amount { get; set; }
}