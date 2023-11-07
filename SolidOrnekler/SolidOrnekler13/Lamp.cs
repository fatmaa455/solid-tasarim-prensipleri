using System;

namespace SolidOrnekler13
{
    class Lamp : ICikis
    {
        public void TurnOff()
        {
            Console.WriteLine("Lamba söndü");
        }

        public void TurnOn()
        {
            Console.WriteLine("Lamba yandi");
        }
    }
}
