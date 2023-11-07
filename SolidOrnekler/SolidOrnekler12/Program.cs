using System;

namespace SolidOrnekler12
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock stk = new Stock(new DBFinder(), new WebRender());
            stk.DisplayStockInfo("Buzdolabı");
        }
    }
}
