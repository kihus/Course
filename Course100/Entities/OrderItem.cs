using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course100.Entities
{
	internal class OrderItem
	{
		public int Quantity { get; set; }
		public double Price { get; set; }
		public Product Product { get; set; }

		public OrderItem() { }

		public OrderItem(int quantity, double price, Product product)
		{
			Quantity = quantity;
			Price = price;
			Product = product;
		}

		public double SubTotal()
		{
			return Quantity * Price;
		}

		public override string ToString()
		{
			return	$"{Product.Name}, ${Product.Price}, Quantity: {Quantity}, Subtotal: ${SubTotal().ToString("F2")}";
		}
	}
}
