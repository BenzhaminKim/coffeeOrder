using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopLib
{
    public class Customer
    {

        ///----------------- Instance variables ---------------------------------
        /// customer's id, name, address and telephone number.
        /// order array is to store the order the customer has made
        private uint idNumber;
        private string name;
        public Address MyAddress;
        private string telephoneNumber;
        private Order[] orders;

        ///----------------- Proerties --------------------------------- 
        public uint IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// if the length of phone number is 10, allow to store the value
        /// </summary>
        public string TelephoneNumber
        {
            get { return telephoneNumber; }
            set
            {
                if (value.Length == 10)
                {
                    telephoneNumber = value;
                }
            }
        }
        public Order[] Orders
        {
            get { return orders; }
            private set { orders = value; }
        }


        /// <summary>
        /// _size is to limitation of number of orders a customer can order.
        ///  numberOfOrders is to count the index of orders array.
        /// </summary>
        private const uint _size = 50;
        private uint numberOfOrders = 0;

        /// <summary>
        /// it is to increase the number of customer ID.
        /// </summary>
        private static uint numberOfId;

        /// <summary>
        /// it is only run when this class is used at the first time.
        /// start customer id from zero.
        /// </summary>
        static Customer()
        {
            numberOfId = 0;
        }


        ///------------------ Constructor ---------------------------------
        /// <summary>
        /// set all customer information 
        /// </summary>
        /// <param name="name"> customer name</param>
        /// <param name="street">customer's street info</param>
        /// <param name="city">customer's city info</param>
        /// <param name="province">customer's province info</param>
        /// <param name="phoneNum">customer's telophone number info</param>
        public Customer(string name, string street, string city, string province, string phoneNum)
        {
            //increase the customer's id number by passing thhe static numberOfId variable
            //and numberOfId will be  increaed everytime Customer class has been created.
            IdNumber = numberOfId++;

            /// it's to set the size of the array.
            Orders = new Order[_size];

            Name = name;
            MyAddress.Street = street;
            MyAddress.City = city;
            MyAddress.Province = province;
            TelephoneNumber = phoneNum;
        }

        /// <summary>
        /// It's to create customer's order wth type of order.
        /// </summary>
        /// <param name="typeOfOrder">it's to get type of order which are phone order or restaurant order</param>
        /// <returns>it returns order that customer made</returns>
        public Order CreateOrder(OrderType typeOfOrder)
        {
            Order newOrder = new Order(this, DateTime.Now);
            newOrder.orderType = typeOfOrder;

            Orders[numberOfOrders++] = newOrder;
            return newOrder;
        }

        public string GetInfo()
        {
            string result = "";
            result += $"customer id:{IdNumber}, name:{Name} address:{MyAddress.GetInfo()} phone:{TelephoneNumber}\n\n";

            foreach (Order item in Orders)
            {
                if (item != null)
                {
                    result += $"{item.GetInfo()}\n\n";
                }
            }
            return result;
        }

    }
}
