using System;
using OrderClient.Entities;
using OrderClient.Entities.Enums;

namespace OrderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);
            Console.WriteLine("Enter order data:");
            OrderStatus status = OrderStatus.Processing;
            Console.Write("Status: " + status.ToString());
            Order order = new Order(DateTime.Now, status, client);
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string pName = Console.ReadLine();
                Console.Write("Product price: ");
                double pPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int pQuantity = int.Parse(Console.ReadLine());
                Product product = new Product(pName, pPrice);
                OrderItem item = new OrderItem(pQuantity, pPrice, product);
                order.AddItem(item);
            }

            Console.WriteLine("----------------------------------------------"); /* EXIBE O RESUMO DO PEDIDO */
        }
    }
}
