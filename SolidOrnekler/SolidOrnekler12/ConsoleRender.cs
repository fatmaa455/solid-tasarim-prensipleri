using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler12
{
    class ConsoleRender : IRenderer
    {
        public void Display(string content)
        {
            Console.WriteLine(content);
        }
    }
}
