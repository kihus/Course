using Course100.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course100.Entities
{
	internal class Order
	{
		public DateTime Moment { get; set; }
		public OrderStatus Status { get; set; }
		public List<OrderItem> Items { get; set; } = [];
		public Client Client { get; set; }

		public Order() { }

		public Order(DateTime moment, OrderStatus status, Client client)
		{
			Moment = moment;
			Status = status;
			Client = client;
		}

		public void AddItem(OrderItem item)
		{
			Items.Add(item);
		}

		public void RemoveItem(OrderItem item)
		{
			Items.Remove(item);
		}

		public double Total()
		{
			double sum = 0.0;
			foreach(OrderItem item in Items)
			{
				sum += item.SubTotal();
			}
			return sum ;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new();
			stringBuilder.AppendLine("ORDER SUMMARY:");
			stringBuilder.Append("Order moment:");
			stringBuilder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
			stringBuilder.Append("Order status:");
			stringBuilder.AppendLine(Status.ToString());
			stringBuilder.Append("Client:");
			stringBuilder.Append(Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyy") + ")");
			stringBuilder.Append(" - " + Client.Email);
			stringBuilder.AppendLine("Order items: ");

			foreach(OrderItem orderItem in Items)
			{
				stringBuilder.AppendLine(orderItem.ToString());
			}			

			return stringBuilder.ToString();
		}
	}
}
