using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessApplication_OOP_.BL
{
    internal class customer
    {
        
        public customer(string customerName, string customerPhone, string customerEmail, string customerAdress, double payment, int code)
        {
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone;
            this.CustomerEmail = customerEmail;
            this.CustomerAdress = customerAdress;
            this.payment = payment;
            this.code = code;
        }

        public string CustomerName;
        public string CustomerPhone;
        public string CustomerEmail;
        public string CustomerAdress;
        public double payment;
        public int code;
    }
}
