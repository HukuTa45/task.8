using System;
using System.Collections.Generic;
using System.Text;

namespace task8.Dogs
{
    public class Terrier : Dog
    {
        public Terrier(string name) : base(name)
        {
        }

        public override double Coefficient => 0.5;
    }
}
