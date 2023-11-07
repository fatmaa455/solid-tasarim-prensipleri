using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler12
{
    class wsFinder : IFinder
    {
        public string Find(string name)
        {
            return name + " isimli ürün web servis bulundu";
        }
    }
}
