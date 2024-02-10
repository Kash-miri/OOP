using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.BL
{
    internal class CoffeeShop
    {
        public CoffeeShop(string name)
        {
            this.name = name;
        }

        public string name;
        List<MenuItem> items = new List<MenuItem>();
        List<MenuItem> order = new List<MenuItem>();
    }
}
