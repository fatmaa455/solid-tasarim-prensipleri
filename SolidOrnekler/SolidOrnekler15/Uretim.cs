using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler15
{
    class Uretim
    {
        ITasit tasit;

        public Uretim(ITasit t)
        {
            this.tasit = t;
        }
        public void Monteleme()
        {
            tasit.ParcalariMonteEt();
        }
    }
}
