using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_1
{
    class OnlineShop
    {
        // 4) declare event of type EventHandler<GoodsInfoEventArgs>
        public event EventHandler<GoodsInfoEventArgs> ev;
        
        // 5) declare method NewGoods for event initiation
        // use parameter string to get GoodsName
        public void NewGoods(string GoodsName, float GoodCost)
        {
            if (ev != null)
                ev(this, new GoodsInfoEventArgs(GoodsName, GoodCost));
        }
        
        // don't forget to check if event is not null
        // in true case intiate the event
        // use next line

        // your_event_name(this, new GoodsInfoEventArgs(GoodsName));

    }
}
