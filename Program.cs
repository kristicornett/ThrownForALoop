// See https://aka.ms/new-console-template for more information
using System.Net;

string greeting = @"Welcome to Thrown For a Loop
Your one-stop shop for used sporting equipment.";

// Console.WriteLine(greeting);
// Console.WriteLine("Please enter a product name: ");

// string response = Console.ReadLine().Trim();

// while (string.IsNullOrEmpty(response))
// {
//     Console.WriteLine("You didn't choose anything, try again!");
//     response = Console.ReadLine().Trim();
// }
// //Console.WriteLine($"You chose: {response}");

// Console.WriteLine(@"Products:
// 1. Football
// 2. Hockey Stick
// 3. Boomerang
// 4. Frisbee
// 5. Golf Putter");
// Console.WriteLine("PLease enter a product number: ");
// int response = int.Parse(Console.ReadLine().Trim());

// while (response > 5 || response < 1)
// {
// Console.WriteLine("Choose a number between 1 and 5!");
// response = int.Parse(Console.ReadLine().Trim());
// }
// Console.WriteLine($"You chose: {response}.");



List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Football",
        Price = 14.00M,
        Sold = false,
        InStock = true,
        //why does new have to go in front of DateTime when it's a property on an instance?
        StockDate = new DateTime(2022, 10, 20),
        ManufactureYear = 2010,
        Condition = 4.2
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12.45M,
        Sold = false,
        InStock = true,
        StockDate = new DateTime(2023, 08, 02),
        ManufactureYear = 2015,
        Condition = 1
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 8.45M,
        Sold = true,
        InStock = false,
        StockDate = new DateTime(2021, 11, 15),
        ManufactureYear = 2000,
        Condition = 3.7
    },
    new Product()
    {
        Name = "Baseball bat",
        Price = 32.99M,
        Sold = false,
        InStock = false,
        StockDate = new DateTime(2023, 09, 24),
        ManufactureYear = 1999,
        Condition = 4.1
    },
    new Product()
    {
        Name = "Soccer ball",
        Price = 25.98M,
        Sold = false,
        InStock = true,
        StockDate = new DateTime(2023, 10, 1),
        ManufactureYear = 2023,
        Condition = 4.9
    },
    new Product()
    {
        Name = "Cleats",
        Price = 66.75M,
        Sold = false,
        InStock = true,
        StockDate = new DateTime(2023, 10, 10),
        ManufactureYear = 2023,
        Condition = 5
    }
};

Console.WriteLine("Products:");

for (int i = 0; i< products.Count; i++)
{
Console.WriteLine($"{i + 1}. {products[i].Name}");
}
decimal totalValue = 0.0M;
foreach (Product product in products)
{
    if (!product.Sold)
    {
        totalValue += product.Price;
    }
}
Console.WriteLine($"Total inventory value: {totalValue}");
// Console.WriteLine("Please enter a product number: ");
// int response = int.Parse(Console.ReadLine().Trim());
// while (response > products.Count || response < 1)
// {
// Console.WriteLine("Choose a number between 1 and 5!");
// response = int.Parse(Console.ReadLine().Trim());
// }
//Product chosenProduct = products[response -1];

Product chosenProduct = null;
while (chosenProduct == null)
{
    Console.WriteLine("Please enter a product number: ");
    try
    {
        int response = int.Parse(Console.ReadLine().Trim());
        chosenProduct = products[response - 1];
    }
    catch (FormatException)
    {
        Console.WriteLine("Please type only integers!");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("Please choose an existing item only!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
        Console.WriteLine("Do better!");
    }
}
DateTime now = DateTime.Now;
TimeSpan timeInStock = now - chosenProduct.StockDate;
Console.WriteLine(@$"You chose: 
{chosenProduct.Name}, which costs {chosenProduct.Price} dollars.
It is {now.Year - chosenProduct.ManufactureYear} years old. 
It {(chosenProduct.Sold ? "is not available." : $"has been in stock for {timeInStock.Days} days.")} It's condition is: {chosenProduct.Condition} out of 5");