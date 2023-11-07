using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler12
{
    class DBFinder : IFinder
    {
        public string Find(string name)
        {
            return name + " isimli ürün veritabanında bulundu";
        }
    }
}
