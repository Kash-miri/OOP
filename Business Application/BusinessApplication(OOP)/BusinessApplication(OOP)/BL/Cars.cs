using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.BL
{
    internal class Cars
    {
        public Cars(string brand, string carName, int model, string color, string carNumber, double price)
        {
            this.brand = brand;
            this.carName = carName;
            this.model = model;
            this.color = color;
            this.carNumber = carNumber;
            this.price = price;
        }

        public Cars(string brand, string carName, int model, string color, int code)
        {
            this.brand = brand;
            this.carName = carName;
            this.model = model;
            this.color = color;
            this.code = code;
        }

        public Cars(string brand, string carNumber)
        {
            this.brand = brand;
            this.carNumber=carNumber;
        }

        public string brand;
        public string carName;
        public int model;
        public string color;
        public double price;
        public string carNumber;
        public int code;
    }
}
