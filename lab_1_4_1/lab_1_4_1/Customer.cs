using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_1
{
    class Customer
    {
        // 6) declare private field name
        private string __name;

        // 7) declare constructor to initialize name
        public Customer(string name)
        {
            __name = name;
        }

        // 8) declare method GotNewGoods with 2 parameters:
        // 1 - object type
        // 2 - GoodsInfoEventArgs type

        public void GotNewGoods(object sender, GoodsInfoEventArgs e)
        {
            Console.WriteLine(@"Dear {0}, in {3} is new goods, its ""{1}"", cost - {2}griven", __name, e.GoodsName, e.Cost, e.ShopName);
        }

    }
}
