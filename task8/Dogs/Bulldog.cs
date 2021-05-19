using System;
using System.Collections.Generic;
using System.Text;


namespace task8.Dogs
{
    public class Bulldog : Dog
    {
        public Bulldog(string name) : base(name)
        {
        }

        public override double Coefficient => 1.2;
    }
}
