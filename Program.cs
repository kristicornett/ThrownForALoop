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
        Price = 14,
        Sold = false,
        InStock = true
    },
    new Product()
    {
        Name = "Hockey Stick",
        Price = 12,
        Sold = false,
        InStock = true
    },
    new Product()
    {
        Name = "Frisbee",
        Price = 8,
        Sold = true,
        InStock = false
    },
    new Product()
    {
        Name = "Baseball bat",
        Price = 32,
        Sold = false,
        InStock = false
    },
    new Product()
    {
        Name = "Soccer ball",
        Price = 25,
        Sold = false,
        InStock = true
    },
    new Product()
    {
        Name = "Cleats",
        Price = 66,
        Sold = false,
        InStock = true
    }
};

Console.WriteLine("Products:");

for (int i = 0; i< products.Count; i++)
{
Console.WriteLine($"{i + 1}. {products[i].Name}");
}
Console.WriteLine("Please enter a product number: ");
int response = int.Parse(Console.ReadLine().Trim());
while (response > products.Count || response < 1)
{
Console.WriteLine("Choose a number between 1 and 5!");
response = int.Parse(Console.ReadLine().Trim());
}
Product chosenProduct = products[response -1];
Console.WriteLine($"You chose: {chosenProduct.Name}, which costs {chosenProduct.Price}. Product stock: {chosenProduct.InStock}");
