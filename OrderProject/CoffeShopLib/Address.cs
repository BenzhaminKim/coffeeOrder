using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShopLib
{
    public struct Address
    {

        public string Street;
        public string City;
        public string Province;

        public string GetInfo()
        {
            return $"{Street} {City} {Province}";
        }
    }
}
