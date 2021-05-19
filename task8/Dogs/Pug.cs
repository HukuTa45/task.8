using System;
using System.Collections.Generic;
using System.Text;


namespace task8.Dogs
{
    public class Pug : Dog
    {
        public Pug(string name) : base(name)
        {
        }

        public override double Coefficient => 1.7;
    }
}
