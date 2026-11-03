using System;
using System.Collections.Generic;
using System.Text;

namespace ImageEditor.Models
{
    internal class BlackWhiteFilter:Filter
    {
        public override void Apply()
        {
            Console.WriteLine("Qara ag filter tedbiq olundu");
        }
    }
}
