using System;
using System.Collections.Generic;
using System.Text;

namespace ImageEditor.Models
{
    internal class BlurFilter:Filter
    {
        public override void Apply()
        {
            Console.WriteLine("Sekil bulaniqlasdirildi");
        }
    }
}
