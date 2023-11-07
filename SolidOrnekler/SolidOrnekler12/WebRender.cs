using System;
using System.Collections.Generic;
using System.Text;

namespace SolidOrnekler12
{
    class WebRender : IRenderer
    {
        public void Display(string content)
        {
            Console.WriteLine("<b>" + content + "</b>");
        }
    }
}
