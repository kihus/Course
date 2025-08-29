using Course100.Entities;
using Course100.Entities.Enums;
using System.Globalization;

Console.WriteLine("Enter cliente data: ");
Console.Write("Name: ");
string? name = Console.ReadLine();

Console.Write("Email: ");
string? email = Console.ReadLine();

Console.Write("Birth Date (DD/MM/YYYY): ");
DateTime birthDate = (DateTime.ParseExact(Console.ReadLine() ?? "0", "dd/MM/yyyy", CultureInfo.InvariantCulture));
Console.WriteLine();

Client client = new(name, email, birthDate);

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
string? status = Console.ReadLine();
OrderStatus orderStatus = Enum.Parse<OrderStatus>(status ?? "PendingPayment");

Console.Write("How many items to this order? ");
var itemsToOrder = int.Parse(Console.ReadLine() ?? "0");

Order order = new(DateTime.Now, orderStatus, client);


for (int i = 1; i <= itemsToOrder; i++)
{
	Console.WriteLine($"Enter #{i} item data: ");
	Console.Write("Product name: ");
	var productName = Console.ReadLine();

	Console.Write("Product price: ");
	var productPrice = double.Parse(Console.ReadLine() ?? "0");

	Console.Write("Quantity: ");
	var quantity = int.Parse(Console.ReadLine() ?? "0");

	Product product = new(productName, productPrice);
	OrderItem orderItem = new(quantity, productPrice, product);
	order.AddItem(orderItem);
}

Console.WriteLine(order);
