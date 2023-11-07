using System;

namespace SolidOrnekler15
{
    class Program
    {
        static void Main(string[] args)
        {
            Uretim uretim = new Uretim(new Araba());
            uretim.Monteleme();

            Uretim uretim2 = new Uretim(new Gemi());
            uretim2.Monteleme();
        }
    }
}
