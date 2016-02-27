using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9) declare object of OnlineShop 
            OnlineShop Otvertka = new OnlineShop();

            // 10) declare several objects of Customer
            Customer c1 = new Customer("Jhon");
            Customer c2 = new Customer("Alex");
            Customer c3 = new Customer("George");

            // 11) subscribe method GotNewGoods() of every Customer instance 
            // to event NewGoodsInfo of object of OnlineShop
            Otvertka.ev += c1.GotNewGoods;
            Otvertka.ev += c2.GotNewGoods;
            Otvertka.ev += c3.GotNewGoods;

            // 12) invoke method NewGoods() of object of OnlineShop
            // discuss results
            Otvertka.NewGoods("Samsung TV", 4000);
            Otvertka.NewGoods("Planshet Lenovo",2000);
            Otvertka.NewGoods("Coca-cola bottle", 30);

        }
    }
}
