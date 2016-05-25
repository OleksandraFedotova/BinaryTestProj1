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
            Auto car = new Auto(1223, "Ford", 1243581);
            string a = Auto.GetInfo(car);
            Console.WriteLine(a);
			/*int a =Convert.Toint16(Console.ReadLine());
			int b =Convert.Toint16(Console.ReadLine());
			res=ToDoCounting(a,b);
			  Console.WriteLine(res);*/
        }

        public static int ToDoCounting(int a, int b)
        {
            return a + b;
        }
    }

    class Auto
    {
        private int number;
        public string model;
        protected int price;

        public Auto(int number, string model, int price)
        {
            this.number = number;
            this.model = model;
            this.price = price;
        }

        public static string GetInfo(Auto a)
        {
            return "model" + a.model + ",id=" + a.number + " costs" + a.price;
        }
    }
}
