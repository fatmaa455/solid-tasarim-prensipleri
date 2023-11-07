using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler12
{
    class Stock
    {
        private IFinder fnd; // bulur
        private IRenderer rnd; // gösterir
        public Stock(IFinder f,IRenderer r)
        {
            fnd = f;
            rnd = r;
        }
        public void DisplayStockInfo(string name)
        {
            rnd.Display(fnd.Find(name));
        }
    }
}
