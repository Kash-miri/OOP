using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessApplication_OOP_.BL;
using BusinessApplication_OOP_.UI;

namespace BusinessApplication_OOP_.DL
{
    internal class profitDL
    {
        public static void calculateProfit(List<Cars> cars)
        {
            double profit = 0;
            if(cars != null)
            {
                foreach(Cars car in cars)
                {
                    profit = profit + car.price;
                }
                profitUI.viewProfit(profit);
            }
        }
    }
}
