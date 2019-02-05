using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopLib
{
    public class MenuItem
    {
        private string name;
        private string description;
        private decimal cost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public static MenuItem operator +(MenuItem first, MenuItem second)
        {
            string newName;
            string newDesctipion;
            decimal newCost;

            newName = $"{first.Name} and {second.Name}";
            newDesctipion = $"{first.Description} and {second.Description}";
            newCost = first.Cost + second.Cost;

            return (new MenuItem(newName, newDesctipion, newCost));
        }
        public MenuItem(string name, string description, decimal cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }


        public string GetInfo()
        {
            return $"Food: {Name}, Description:{Description} Cost:{Cost}";
        }
    }
}
