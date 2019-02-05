using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopLib
{
    public class OrderItem
    {
        private MenuItem menuItems;

        public MenuItem MenuItems
        {
            get { return menuItems; }
            set { menuItems = value; }
        }

        public OrderItem(MenuItem menuItem)
        {
            MenuItems = menuItem;
        }

        public string GetInfo()
        {
            return $"\n\t Orderd Food: {menuItems.Name} description:{menuItems.Description} Cost: {MenuItems.Cost}\n";
        }
    }
}
