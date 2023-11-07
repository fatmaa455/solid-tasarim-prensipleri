using System;

namespace SolidOrnekler16
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateManager cm = new CreateManager(new Post());
            cm.Hazirla();

            CreateManager cm2 = new CreateManager(new Gonderi());
            cm2.Hazirla();
        }
    }
}
