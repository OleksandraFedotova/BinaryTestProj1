using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car=new Auto(1223,"Ford",1243581);
            string a = Auto.GetInformation(car);
        }
    }

    class Auto
    {
        private int number;
        public string model;
        protected int price;

        public Auto (int number, string model,int price)
        {
            this.number = number;
            this.model = model;
            this.price = price;
        }

        public static string GetInformation(Auto a)
        {
            return "model" + a.model + ",id=" + a.number + " costs" + a.price;
        }
    }
}
