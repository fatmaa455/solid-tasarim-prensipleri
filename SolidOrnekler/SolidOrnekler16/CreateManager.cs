using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler16
{
    class CreateManager
    {
        ICreate create;
        public CreateManager(ICreate c)
        {
            this.create = c;
        }
        public void Hazirla()
        {
            create.Create();
        }
    }
}
