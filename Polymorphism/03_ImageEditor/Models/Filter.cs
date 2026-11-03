using System;
using System.Collections.Generic;
using System.Text;

namespace ImageEditor.Models
{
    internal class Filter
    {
        public  virtual void Apply()
        {
            Console.WriteLine("Filter tedbiq edilir!");
        }
    }
}
