using System;
using CoffeShopLib;

namespace CoffeeShopDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem pasta = new MenuItem("pasta", "pasta description", 10.4M);
            MenuItem pizza = new MenuItem("pizza", "pizza description", 12.4M);
            MenuItem rice = new MenuItem("rice", "rice description", 6.2M);
            MenuItem chicken = new MenuItem("chicken", "chicken description", 8.3M);


            Customer customer1 = new Customer("Young", "46 Lehar", "Toronto", "Ontario", "4167315950");
            Customer customer2 = new Customer("Ben", "46 Lehar", "Toronto", "Ontario", "4167315950");

            Order order1 = customer1.CreateOrder(OrderType.phoneOrder);
            Order order2 = customer2.CreateOrder(OrderType.RestaurantOrder);

            OrderItem orderItemList1 = new OrderItem(pizza);
            OrderItem orderItemList2 = new OrderItem(pasta);
            OrderItem orderItemList3 = new OrderItem(rice + rice);

            order1.AddOrderItem(orderItemList1);
            order1.AddOrderItem(orderItemList2);
            order1.AddOrderItem(orderItemList3);

            order2.AddOrderItem(orderItemList1);
            order2.AddOrderItem(orderItemList2);

            Console.WriteLine("----------menu------------");
            Console.WriteLine(pasta.GetInfo());
            Console.WriteLine(pizza.GetInfo());
            Console.WriteLine(rice.GetInfo());
            Console.WriteLine(chicken.GetInfo());

            Console.WriteLine("------customer-----------");
            Console.WriteLine(customer1.GetInfo());
            Console.WriteLine(customer2.GetInfo());

            Console.WriteLine("--------Order-----");
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(order2.GetInfo());

            Console.WriteLine("-----order is deliverd------");
            order1.Delivered();
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(order2.GetInfo());

        }
    }
}
