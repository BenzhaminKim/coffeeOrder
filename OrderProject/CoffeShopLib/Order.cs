using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopLib
{
    public class Order
    {

        private uint id;
        private Customer customer;
        private DateTime orderTime;
        private DateTime deliveryTime;
        private Address deliveryAddress;
        private decimal cost;
        public OrderType orderType;
        private OrderItem[] orderItems;
        private bool isDeliverd;

        private uint numberOfItems = 0;
        private const int _maxItems = 50;
        private static uint numberOfOrders;

        public uint Id
        {
            get { return id; }
            set { id = value; }
        }
        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public DateTime OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            private set { deliveryTime = value; }
        }
        public Address DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }

        public OrderItem[] OrderItems
        {
            get { return orderItems; }
            set { orderItems = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public bool Deliverd
        {
            get { return isDeliverd; }
            set
            {
                isDeliverd = value;
                if (isDeliverd)
                {
                    deliver();
                }
            }
        }
        static Order()
        {
            numberOfOrders = 0;
        }
        public Order(Customer customer, DateTime orderTime)
        {
            //increse order id
            numberOfOrders++;
            Id = numberOfOrders;

            //set customer address
            DeliveryAddress = customer.MyAddress;

            //set order time
            OrderTime = orderTime;

            //set customer
            Customer = customer;

            //order
            OrderItems = new OrderItem[_maxItems];
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            Cost += orderItem.MenuItems.Cost;
            OrderItems[numberOfItems++] = orderItem;
        }

        public string GetInfo()
        {
            string result = "";
            result += $"\n order id: {Id} order Type:{orderType} customer name: {Customer.Name} customer Id: {Customer.IdNumber} deliverty address:{DeliveryAddress.GetInfo()} order Time: {OrderTime}\n delivery Time:{DeliveryTime}";
            foreach (OrderItem item in OrderItems)
            {
                if (item != null)
                {
                    result += $"{item.GetInfo()}\n";
                }
            }
            result += $"\tTotal Cost{Cost}\n";
            return result;
        }

        /// <summary>
        /// set the delivery time
        /// </summary>
        private void deliver()
        {
            DeliveryTime = DateTime.Now;
        }
        /// <summary>
        /// This method will be called when the order is deliverd.
        /// </summary>
        public void Delivered()
        {
            Deliverd = true;
        }
    }
}
